using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp.Test
{

    [TestClass]
    public class DigitalBiblePlatformServiceTest
    {
        private const string ApiKeyEnvironmentVariableName = "DBPSharpApiKey";
        private DigitalBiblePlatformService service;

        [TestInitialize]
        public void Initialize()
        {
            var apiKey = Environment.GetEnvironmentVariable(ApiKeyEnvironmentVariableName);

            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException($"Api not found. For unit testing, please assign your API Key to environment variable named {ApiKeyEnvironmentVariableName}.");
            }

            this.service = new DigitalBiblePlatformService(apiKey);
        }

        [TestMethod]
        public async Task TestLanguageListingAsync1()
        {
            var result = await this.service.LanguageListingAsync(new ApiModels.LanguageListingRequest());
            TestUtils.WriteLogFile(nameof(TestLanguageListingAsync1), result);

            TestUtils.IsNotNullOrEmpty(result);
        }

    }
    
}
