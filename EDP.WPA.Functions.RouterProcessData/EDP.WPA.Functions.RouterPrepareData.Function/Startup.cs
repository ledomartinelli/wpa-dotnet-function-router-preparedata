using EDP.WPA.Functions.RouterPrepareData.Infra.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

[assembly: FunctionsStartup(typeof(EDP.WPA.Functions.RouterPrepareData.Function.Startup))]
namespace EDP.WPA.Functions.RouterPrepareData.Function
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            builder.ConfigurationBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {

            var context = builder.GetContext();
            var configuration = context.Configuration;
            

            //builder.Services.AddScoped<IProcessMessageService, ProcessMessageService>();//sim

            //builder.Services.AddScoped<IWorkDatabaseService, WorkDatabaseService>();//Serviço que vai no banco serão dois, mirror e work pensar um jeito de fazer

            builder.Services.AddScoped<IMirrorDatabaseService, MirrorDatabaseService>();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            builder.Services.AddLogging(lb =>
            {
                lb.ClearProviders();
                lb.AddSerilog(Log.Logger, true);
            });

            //builder.Services.AddLogging(
            //    lb => lb.ClearProviders()
            //        .AddSerilog(
            //            new LoggerConfiguration().ReadFrom
            //                .Configuration(configuration)
            //                .CreateLogger(),
            //            dispose: true));
        }
    }
}
