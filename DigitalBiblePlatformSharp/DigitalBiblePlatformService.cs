using DigitalBiblePlatformSharp.ApiModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        public async Task<LanguageListingResponse[]> LanguageListingAsync(LanguageListingRequest request)
        {
            return await this.ExecuteGetApiAsync<LanguageListingResponse[]>(request);
        }

        /// <summary>
        /// A general API call for all calls. TResponse can be <typeparamref name="System.Dynamic"/> for
        /// dynamic typed.
        /// </summary>
        public async Task<TResponse> ExecuteGetApiAsync<TResponse>(BaseApiRequest request)
        {
            var restRequest = this.CreateRequest(request.RestUrl, Method.GET);

            var properties = request.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(request);

                if (propertyValue != null)
                {
                    var jsonAttribute = property
                        .GetCustomAttributes(typeof(JsonPropertyAttribute), false)
                        .FirstOrDefault() as JsonPropertyAttribute;

                    var name = jsonAttribute == null ? property.Name : jsonAttribute.PropertyName;

                    restRequest.AddQueryParameter(name, propertyValue.ToString());
                }
            }

            var response = await this.RestClient.ExecuteTaskAsync(restRequest);
            response.EnsureStatus(System.Net.HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<TResponse>(response.Content);
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
