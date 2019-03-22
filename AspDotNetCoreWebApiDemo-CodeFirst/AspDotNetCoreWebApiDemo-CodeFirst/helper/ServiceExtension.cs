using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreWebApiDemo_CodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspDotNetCoreWebApiDemo_CodeFirst.helper
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["sqlconnection:connectionString"];
            services.AddDbContext<TestDbContext>(o => o.UseSqlServer(connectionString));

        }

    }

}
