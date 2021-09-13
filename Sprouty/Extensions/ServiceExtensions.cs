using Sprouty.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

namespace Sprouty.Extensions 
{
    // class that contains configuration functions which the startup class will call, these are not called in startup yet
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        public static void ConfigureMongoContext(this IServiceCollection services, IConfiguration config)
        {
            if (config == null)
                return; // TODO : add logging

            services.Configure<MongoSettings>(config.GetSection(nameof(MongoSettings)));
            services.AddSingleton<IMongoSettings>(sp => sp.GetRequiredService<IOptions<MongoSettings>>().Value);
            services.AddSingleton<RepositoryContext>();
        }

        public static void ConfigureSerilog(this IServiceCollection services, IConfiguration config)
        {
            if (config == null)
                return; // TODO : add logging

            services.AddSingleton<ILogger>(logger => new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger());
        }
    }
}
