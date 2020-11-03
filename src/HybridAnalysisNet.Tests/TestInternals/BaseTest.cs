using Microsoft.Extensions.Configuration;

namespace HybridAnalysisNet.Tests.TestInternals
{
    public abstract class BaseTest
    {
        protected string ApiKey;
        public IConfiguration Configuration { get; }
        protected BaseTest()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ApiKey = config["APIKey"];

        }
    }
}
