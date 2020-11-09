using System;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace HybridAnalysisNet.Tests.TestInternals
{
    public abstract class BaseTest
    {
        protected readonly string ApiKey;
        protected readonly WebProxy webProxy;

        public IConfiguration Configuration { get; }
        protected BaseTest()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ApiKey = config["APIKey"];
            string proxyConfig = config["Proxy"];

            if (proxyConfig != null)
                webProxy = new WebProxy { Address = new Uri(proxyConfig) };
        }
    }
}
