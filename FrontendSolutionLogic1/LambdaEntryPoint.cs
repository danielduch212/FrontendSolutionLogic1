using Amazon.Lambda.AspNetCoreServer;

namespace FrontendSolutionLogic1;

public class LambdaEntryPoint : APIGatewayHttpApiV2ProxyFunction
{
    protected override void Init(IHostBuilder builder)
    {
        builder.ConfigureWebHostDefaults(webBuilder =>
        {
            
            webBuilder.UseStartup<Startup>();
        });

        base.Init(builder);
        //
        //builder.ConfigureWebHostDefaults(webBuilder =>
        //{
        //    webBuilder.UseSetting(WebHostDefaults.ApplicationKey, typeof(Program).Assembly.FullName);
        //});
        //base.Init(builder);
    }
}
