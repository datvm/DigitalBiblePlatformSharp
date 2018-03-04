using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBiblePlatformSharp.ApiModels
{

    public abstract class BaseRequest
    {

        /// <summary>
        /// The Url (relative to host name) of the REST resource.
        /// For library internal use.
        /// </summary>
        [JsonIgnore]
        public abstract string restUrl { get; }

        /// <summary>
        /// Your DBT API key provided upon registration.
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// Specifies the version of the API requested.
        /// </summary>
        public string v { get; set; }

        /// <summary>
        /// Specifies the response type requested by the caller. Default is json.
        /// </summary>
        public ReplyType reply { get; set; }

        /// <summary>
        /// Specifies the name of the function returned when a JSONP reply is requested. (Requires reply = jsonp)
        /// </summary>
        public string callback { get; set; }

        /// <summary>
        /// If unused the results are as before. If set to \'true\', the results will be prepended with the array of
        /// calling arguments used. This does mean that the results will be one layer deeper as the results will be
        /// an array where the first element is the array of input arguments and the second element will be the results
        /// as normally returned.
        /// </summary>
        public bool? echo { get; set; }

        /// <summary>
        /// REQUIRED for PUT DBT methods - PUT is not properly supported. To effect DBT methods requiring PUT, use the GET HTTP method and &_method=put.
        /// </summary>
        public string _method { get; set; }

    }

    public enum ReplyType
    {
        json = 0,
        jsonp = 1,
        html = 2,
    }

}
