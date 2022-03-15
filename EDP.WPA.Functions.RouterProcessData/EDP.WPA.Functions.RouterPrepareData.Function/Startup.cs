using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(EDP.WPA.Functions.RouterPrepareData.Function.Startup))]
namespace EDP.WPA.Functions.RouterPrepareData.Function
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //builder.Services.AddTransient<Interface, Class>();
        }
    }
}
