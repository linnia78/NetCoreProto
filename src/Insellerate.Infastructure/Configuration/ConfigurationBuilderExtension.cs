using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Insellerate.Infastructure
{
    public static class ConfigurationBuilderExtension
    {
        public static IConfigurationBuilder AddAppSettings(this IConfigurationBuilder builder, IHostingEnvironment env)
        {
            builder
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }

            return builder;
        }

        public static IConfigurationBuilder AddAppSettings(this IConfigurationBuilder builder)
        {
            return builder
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets()
                .AddEnvironmentVariables();
        }
    }
}
