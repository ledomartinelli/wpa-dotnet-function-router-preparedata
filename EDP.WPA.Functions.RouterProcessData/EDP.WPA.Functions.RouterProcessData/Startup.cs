using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

[assembly: FunctionsStartup(typeof(EDP.WPA.Functions.RouterProcessData.Console.Startup))]
namespace EDP.WPA.Functions.RouterProcessData.Console
{
    public class Startup : FunctionsStartup
    {
        private IConfiguration configuration;
        private FunctionsHostBuilderContext context;

        public override void Configure(IFunctionsHostBuilder builder)
        {
            //context = builder.GetContext();
            //configuration = context.Configuration;

            //builder.Services
            //.SetUpFileConfiguration(context)
            //.SetUpSettingModelAsOption()
            //.SetUpIoCFunction(configuration)
            //.SetUpFluentValidation();
        }

    }
}
