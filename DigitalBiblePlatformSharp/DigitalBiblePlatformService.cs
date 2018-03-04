using DigitalBiblePlatformSharp.ApiModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp
{

    public class DigitalBiblePlatformService
    {
        private const string ApiEndpoint = "https://dbt.io/";
        
        protected RestClient RestClient { get; set; }
        protected string ApiKey { get; set; }

        public DigitalBiblePlatformService(string apiKey)
        {
            this.RestClient = new RestClient(ApiEndpoint);
            this.ApiKey = apiKey;
        }
        
        public async Task<LanguageListingItem[]> ListLanguageAsync()
        {
            var request = this.CreateRequest("library/language", Method.GET);

            var response = await this.RestClient.ExecuteTaskAsync(request);
            response.EnsureStatus(System.Net.HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<LanguageListingItem[]>(response.Content);
            return result;
        }

        private IRestRequest CreateRequest(string resource, Method method)
        {
            return new RestRequest(resource, method)
                .AddQueryParameter("v", "2")
                .AddQueryParameter("key", this.ApiKey);
        }

    }

}
