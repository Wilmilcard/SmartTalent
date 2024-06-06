using SmartTalent.Domain;

namespace SmartTalent
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static WebApplication InicializarApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Add services to the container.
            ConfigurationManager configuration = builder.Configuration;

            //Dependencias de Domain
            builder.Services.AddCustomizedDataStore(configuration);
            builder.Services.AddCustomizedServicesProject();
            builder.Services.AddCustomizedRepository();

            //Eliminar referencias circulares
            builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        public static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseCors(x => x
            //.AllowAnyOrigin()
            //.AllowAnyMethod()
            //.AllowAnyHeader());

            //app.UseRouting();

            //app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("Policy");

            app.MapControllers();
        }
    }
}
