using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.DB;
using SmartTalent.Domain.Models;
using SmartTalent.HttpRequest;
using SmartTalent.Utils;
using System.IdentityModel.Tokens.Jwt;

namespace SmartTalent.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly SmartTalentContext _context;

        public AuthController(IConfiguration configuration, SmartTalentContext context)
        {
            Configuration = configuration;
            _context = context;
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.username) || string.IsNullOrEmpty(request.password))
                    return new BadRequestObjectResult(new { success = false, data = "El usuario y/o contraseña estan vacios" });

                var user = _context.Users.Where(x => x.Username == request.username).FirstOrDefault();
                if (user == null)
                    return new BadRequestObjectResult(new { success = false, data = "El usuario no se encuentra registrado" });

                var person = _context.Persons.Include(x => x.User).Where(x => x.UserId == user.UserId).FirstOrDefault();

                var pass = Encrypt.MD5(request.password);
                if (pass != user.PasswordHash)
                {
                    if (user.AccessFailCount <= 2)
                    {
                        user.AccessFailCount++;
                        user.UpdatedAt = Globals.ActualDate();
                        _context.Users.Update(user);
                        _context.SaveChanges();
                        return new BadRequestObjectResult(new { success = false, data = $"Lleva {user.AccessFailCount}/3 intentos" });
                    }
                    else
                    {
                        user.IsActive = false;
                        user.UpdatedAt = Globals.ActualDate();
                        _context.Users.Update(user);
                        _context.SaveChanges();
                        return new BadRequestObjectResult(new { success = false, data = "No tiene mas intentos y sera bloqueado, comuniquese con el administrador" });
                    }
                }

                //Tiempo de Tokenn
                var expiration_date = Globals.ActualDate().AddHours(5).AddHours(8);//8 horas de vida para el token
                var jwtHelper = new JWTHelper(this.Configuration.GetValue<string>("SecurityKey"));
                var token = jwtHelper.CreateToken(request.username, expiration_date);

                //Validamos la sesion
                var _sesion = _context.Sessions
                    .Include(x => x.User)
                    .Where(x => x.UserId == user.UserId)
                    .FirstOrDefault();

                if (_sesion == null)
                {
                    var sesion = new Session
                    {
                        UserId = user.UserId,
                        Token = token,
                        Expiration_Date = expiration_date,
                        CreatedAt = Globals.ActualDate(),
                        CreatedBy = Globals.UserSystem()
                    };
                    _context.Sessions.Add(sesion);

                    user.AccessFailCount = 0;
                    user.UpdatedAt = Globals.ActualDate();
                    _context.Users.Update(user);
                    _context.SaveChanges();

                    _sesion = _context.Sessions
                        .Include(x => x.User)
                        .Where(x => x.UserId == user.UserId)
                        .FirstOrDefault();
                }
                else
                {
                    _sesion.Token = token;
                    _sesion.Expiration_Date = expiration_date;
                    _sesion.UpdatedAt = Globals.ActualDate();
                    _context.Sessions.Update(_sesion);
                }

                user.AccessFailCount = 0;
                user.UpdatedAt = Globals.ActualDate();
                _context.Users.Update(user);

                _context.SaveChanges();

                var response = new
                {
                    success = true,
                    data = new
                    {
                        _sesion.User.Username,
                        token
                    },
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    data = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult,
                        InnerError = ex.InnerException
                    }
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
