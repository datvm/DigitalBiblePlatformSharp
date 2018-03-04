using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBiblePlatformSharp.ApiModels
{

    /// <summary>
    /// This method retrieves the list of  languages defined in the system according to the filter specified.
    /// If the possibilities parameter is ignored, the list will be of defined DBP languages that meet all of the criteria.
    /// If the possibilities parameter is used and set to true,
    /// the list will be of defined DBP languages and ISO languages not defined in DBP that meet any of the criteria.
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-listing/"/>
    /// </summary>
    public class LanguageListingRequest : BaseRequest
    {
        
        public string code { get; set; }

        public override string restUrl => "";
    }

    public class LanguageListingItem
    {
        public string language_code { get; set; }
        public string language_name { get; set; }
        public string english_name { get; set; }
        public string language_iso { get; set; }
        public string language_iso_2B { get; set; }
        public string language_iso_2T { get; set; }
        public string language_iso_1 { get; set; }
        public string language_iso_name { get; set; }
        public string language_family_code { get; set; }
    }

}
