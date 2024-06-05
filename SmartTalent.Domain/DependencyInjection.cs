using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartTalent.Domain.DB;
using SmartTalent.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTalent.Domain
{
    public static class DependencyInjection
    {
        //Injection del DB Context
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<SmartTalentContext>(
                options => options.UseMySql(Configuration.GetConnectionString("Conn_mysql"),
                ServerVersion.AutoDetect(Configuration.GetConnectionString("Conn_mysql")),
                null));
            return services;
        }

        //Injection del Repositorio
        public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
