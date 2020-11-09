using System;
using System.Diagnostics;
using System.Net;
using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace HybridAnalysisNet.Tests.TestInternals
{
    public abstract class BaseTest
    {
        protected readonly string ApiKey;
        protected readonly WebProxy webProxy;
        protected readonly ITestOutputHelper testOutputHelper;

        //public IConfiguration Configuration { get; }
        protected BaseTest(ITestOutputHelper testOutputHelper)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ApiKey = config["APIKey"];
            string proxyConfig = config["Proxy"];

            if (proxyConfig != null)
                webProxy = new WebProxy { Address = new Uri(proxyConfig) };

            this.testOutputHelper = testOutputHelper;
        }

    }
}
