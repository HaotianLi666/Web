/* File: ServiceExtensions.cs
 * Authors: Jonathan Wenek
 * Purpose: To provide a space for the custom service extension functions which are used by Startup.cs
 * Functions: 
 *      ConfigureCors(), ConfigureIISIntegration(), ConfigureRepositoryContext(), ConfigureSerilog(),
 *      ConfigureRepositoryWrapper(), ConfigureAuthorization() */

using Sprouty.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;
using Sprouty.Contracts;
using Sprouty.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Sprouty.Extensions 
{
    public static class ServiceExtensions
    {
        /* Function: ConfigureCors()
         * Authors: Jonathan Wenek
         * Purpose: To define the configuration options for the Cors service to be used in Startup.cs
         * Parameters: services<IServiceCollection>, specfies the contract for a collection of service descriptors
         * Algorithm:
         *      1) define the AddCors configuration with a CorsOption anon function
         *      2) define the AddPolicy configuration with a CorsPolicyBuilder anon function
         *      3) define the builder configuration with AllowAnyOrigin(), AllowAnyMethod(), and AllowAnyHeader() */
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

        /* Function: ConfigureIISIntegration()
         * Authors: Jonathan Wenek
         * Purpose: To define the configuration options for the IIS Integration service to be used in Startup.cs
         * Parameters: services<IServiceCollection>, specifies the contract for a collection of service descriptors */
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { }); // this uses default configuration
        }

        /* Function: ConfigureRepositoryContext()
         * Authors: Jonathan Wenek
         * Purpose: To define the configuration options for the RepositoryContext and initialize a singeton instance
         * Parameters: 
         *      services<IServiceCollection>, specifies the contract for a collection of service descriptors
         *      config<IConfiguration>, set of key/value pairs that define the configuration options
         * Algorithm:
         *      1) check that there are config options present; if not, return
         *      2) configure mongo settings using options present in config (appsettings.json)
         *      3) add a singleton of type IMongoSettings to the services
         *      4) add a singleton of type RepositoryContext to the services to be used by dependancy injection */
        public static void ConfigureRepositoryContext(this IServiceCollection services, IConfiguration config)
        {
            if (config == null)
                return; // TODO : add logging

            services.Configure<MongoSettings>(config.GetSection(nameof(MongoSettings)));
            services.AddSingleton<IMongoSettings>(sp => sp.GetRequiredService<IOptions<MongoSettings>>().Value);
            services.AddSingleton<RepositoryContext>();
        }

        /* Function: ConfigureSerilog()
         * Authors: Jonathan Wenek
         * Purpose: To define the configuration options for the logging service and initialize a singleton instance
         * Parameters:
         *      services<IServiceCollection>, specifies the contract for a collection of service descriptors
         *      config<IConfiguration>, set of key/value pairs that define the configuration options
         * Algorithm:
         *      1) check that there are config options present; if not, return
         *      2) add a singleton instance of the ILogger interface to the services
         *      3) configure the logger settings using options present in config (appsettings.json) */
        public static void ConfigureSerilog(this IServiceCollection services, IConfiguration config)
        {
            if (config == null)
                return; // TODO : add logging

            services.AddSingleton<ILogger>(logger => new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger());
        }

        /* Function: ConfigureRepositoryWrapper()
         * Authors: Jonathan Wenek
         * Purpose: To add the RepositoryWrapper interface as a scoped service to be used for depenancy injection
         * Parameters: services<IServiceCollection>, specifies the contract for a collection of service descriptors */
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        /* Function: ConfigureAuthorization
         * Authors: Jonathan Wenek
         * Purpose: To define the configuration options for the Authorization service
         * Parameters: services<IServiceCollection>, specifies the contract for a collection of service descriptors
         * Algorithm:
         *      1) define the AddAuthorization function with an anon function
         *      2) define the AddPolicy function as type Bearer, using the AuthorizationPolicyBuilder
         *      3) configure the AuthenticationScheme using JwtBearerDefaults
         *      4) configure RequireAuthenticatedUser */
        public static void ConfigureAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                            .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                            .RequireAuthenticatedUser()
                            .Build()
                );
            });
        }
    }
}
