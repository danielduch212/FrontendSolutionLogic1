using Amazon.Lambda.AspNetCoreServer;

namespace FrontendSolutionLogic1
{
    public class LambdaEntryPoint : APIGatewayHttpApiV2ProxyFunction
    {
        protected override void Init(IHostBuilder builder)
        {
            base.Init(builder);
        }
    }
}
