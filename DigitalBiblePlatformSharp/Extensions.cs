using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DigitalBiblePlatformSharp
{

    internal static class Extensions
    {
        public static void EnsureCompleted(this IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new ApiException($"Response is not Completed. Status is {response.ResponseStatus}.", response.Content);
            }
        }

        public static void EnsureStatus(this IRestResponse response, HttpStatusCode expected)
        {
            response.EnsureCompleted();

            if (response.StatusCode != expected)
            {
                throw new ApiException(
                    $"Response status code is not {(int)expected}. Status code: {(int)response.StatusCode} ({response.StatusDescription})",
                    response.Content);
            }
        }
    }

    public class ApiException : Exception
    {
        public string ResponseContent { get; set; }

        public ApiException()
        {
        }

        public ApiException(string message) : base(message)
        {
        }

        public ApiException(string message, string responseContent) : base(message)
        {
            this.ResponseContent = responseContent;
        }

        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
