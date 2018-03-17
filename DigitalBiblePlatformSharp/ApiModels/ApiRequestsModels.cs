using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBiblePlatformSharp.ApiModels
{

    /// <summary>
    /// <para>This method retrieves the list of  languages defined in the system according 
    /// to the filter specified. If the possibilities parameter is ignored, the list 
    /// will be of defined DBP languages that meet all of the criteria. If the 
    /// possibilities parameter is used and set to true, the list will be of defined 
    /// DBP languages and ISO languages not defined in DBP that meet any of the 
    /// criteria. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-listing/"/>
    /// </summary>
    public class LanguageListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>Get the entry for a three letter language code. </para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>Get the entry for a part of a language name in either native language or 
        /// English. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Consider the language name as being a full word. For instance, when false, 
        /// 'new' will return volumes where the string 'new' is anywhere in the language 
        /// name, like in "Newari" and "Awa for Papua New Guinea". When true, it will 
        /// only return volumes where the language name contains the full word 'new', 
        /// like in "Awa for Papua New Guinea". Default is false. </para>
        /// </summary>
        [JsonProperty("full_word")]
        public bool? FullWord { get; set; }

        /// <summary>
        /// <para>When set to true the returned list is of only legal language families. The 
        /// default is false. </para>
        /// </summary>
        [JsonProperty("family_only")]
        public bool? FamilyOnly { get; set; }

        /// <summary>
        /// <para>; [true|false] When set to true the returned list is a combination of DBP 
        /// languages and ISO languages not yet defined in DBP that meet any of the 
        /// criteria. </para>
        /// </summary>
        [JsonProperty("possibilities")]
        public string Possibilities { get; set; }

        /// <summary>
        /// <para>Primary criteria by which to sort. 'name' refers to the native language name. 
        /// The default is 'english'. </para>
        /// </summary>
        [JsonProperty("sort_by")]
        public LanguageListingSortByEnum SortBy { get; set; }

        public override string RestUrl => "/library/language";

    }

    /// <summary>
    /// <para>Add a language to the language list. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-create/"/>
    /// </summary>
    public class LanguageCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The three letter ISO language code. </para>
        /// </summary>
        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }

        /// <summary>
        /// <para>The native language language name. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>The English language language name. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>Forces the language code creation to be a variant of the ISO code and not the 
        /// ISO code even if it is available as a DBP language code. This is used when 
        /// FCBH considers the language being defined to be a variant of an official ISO 
        /// language. </para>
        /// </summary>
        [JsonProperty("variant")]
        public bool? Variant { get; set; }

        /// <summary>
        /// <para>The language code of the family to which this language belongs. If left empty 
        /// or a non-existent language code is entered, the family_code will be set the 
        /// same as the code entered to create this language. </para>
        /// </summary>
        [JsonProperty("family_code")]
        public string FamilyCode { get; set; }

        public override string RestUrl => "/library/language";

    }

    /// <summary>
    /// <para>Edit the name of a language. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-update/"/>
    /// </summary>
    public class LanguageUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The three letter language code of the entry to be edited. </para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>The new native language language name. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new English language language name. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>The language code of the family to which this language belongs. If a 
        /// non-existent language code is entered, the family_code will remain as 
        /// previously. </para>
        /// </summary>
        [JsonProperty("family_code")]
        public string FamilyCode { get; set; }

        public override string RestUrl => "/library/language";

    }

    /// <summary>
    /// <para>Get the list of versions defined in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-listing/"/>
    /// </summary>
    public class VersionListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>Get the entry for a three letter version code. </para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>Get the entry for a part of a version name in either native language or 
        /// English. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Primary criteria by which to sort. 'name' refers to the native language name. 
        /// The default is 'english'. </para>
        /// </summary>
        [JsonProperty("sort_by")]
        public VersionListingSortByEnum SortBy { get; set; }

        public override string RestUrl => "/library/version";

    }

    /// <summary>
    /// <para>Add a version to the version list. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-create/"/>
    /// </summary>
    public class VersionCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The three letter version code. </para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>The native language version name. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>The English language version name. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        public override string RestUrl => "/library/version";

    }

    /// <summary>
    /// <para>Edit the name of a version. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-update/"/>
    /// </summary>
    public class VersionUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The three letter version code of the entry to be edited. </para>
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>The new native language version name. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new English language version name. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        public override string RestUrl => "/library/version";

    }

    /// <summary>
    /// <para>This method retrieves the list of available volumes in the system according 
    /// to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-listing/"/>
    /// </summary>
    public class VolumeListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the volume internal DAM ID. Can be used to restrict the response to only DAM 
        /// IDs that contain with 'N2' for example </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>the volume FCBH DAM ID. Can be used to restrict the response to only FCBH DAM 
        /// IDs that contain with 'N2' for example </para>
        /// </summary>
        [JsonProperty("fcbh_id")]
        public string FcbhId { get; set; }

        /// <summary>
        /// <para>the format of assets the caller is interested in. This specifies if you only 
        /// want volumes available in text or volumes available in audio. </para>
        /// </summary>
        [JsonProperty("media")]
        public VolumeListingMediaEnum Media { get; set; }

        /// <summary>
        /// <para>a criteria for approved delivery method. It is possible to OR these methods 
        /// together using '|', such as "delivery=streaming_url|mobile".  'any' means any 
        /// of the supported methods (this list may change over time) i.e. approved for 
        /// something. 'none' means volumes that are not approved for any of the 
        /// supported methods. All volumes are returned by default. </para>
        /// </summary>
        [JsonProperty("delivery")]
        public VolumeListingDeliveryEnum Delivery { get; set; }

        /// <summary>
        /// <para>Filter the versions returned to a specified native or English language 
        /// language name. For example return all the 'English' volumes. </para>
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// <para>Consider the language name as being a full word. For instance, when false, 
        /// 'new' will return volumes where the string 'new' is anywhere in the language 
        /// name, like in "Newari" and "Awa for Papua New Guinea". When true, it will 
        /// only return volumes where the language name contains the full word 'new', 
        /// like in "Awa for Papua New Guinea". Default is false. </para>
        /// </summary>
        [JsonProperty("full_word")]
        public bool? FullWord { get; set; }

        /// <summary>
        /// <para>the three letter language code. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>the three letter language code for the language family. </para>
        /// </summary>
        [JsonProperty("language_family_code")]
        public string LanguageFamilyCode { get; set; }

        /// <summary>
        /// <para>YYYY-MM-DD. This is used to get volumes that were modified since the 
        /// specified date. </para>
        /// </summary>
        [JsonProperty("updated")]
        public string Updated { get; set; }

        /// <summary>
        /// <para>Publishing status of volume. The default is 'live'. </para>
        /// </summary>
        [JsonProperty("status")]
        public VolumeListingStatusEnum Status { get; set; }

        /// <summary>
        /// <para>Whether or not a DBP Agreement has been executed between FCBH and the 
        /// organization to whom the volume belongs. </para>
        /// </summary>
        [JsonProperty("dbp_agreement")]
        public bool? DbpAgreement { get; set; }

        /// <summary>
        /// <para>Whether the volume as passed its expiration or not. </para>
        /// </summary>
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>Currently used for video volumes as they can be available in different 
        /// resolutions, basically conforming to the loose general categories of low, 
        /// medium, and high resolution. Low resolution is geared towards devices with 
        /// smaller screens. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public VolumeListingResolutionEnum Resolution { get; set; }

        /// <summary>
        /// <para>Organization id of volumes to return. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>Primary criteria by which to sort.  The default is 'dam_id'. </para>
        /// </summary>
        [JsonProperty("sort_by")]
        public VolumeListingSortByEnum SortBy { get; set; }

        public override string RestUrl => "/library/volume";

    }

    /// <summary>
    /// <para>Create the core information for a new volume in DBP. </para>
    /// <para>The volume status is the 'state' of the volume. These were predicated on a 
    /// process where a contributing organization could create and load a volume, but 
    /// a formal proofing step could be required before making live. Right now only 
    /// FCBH creates volumes. So the proofing step is unnecessary. </para>
    /// <para>incomplete - All the pieces may not yet be there. This is the default setting 
    /// when a volume is created. The volume cannot be set to anything else until the 
    /// book order and contents exist for it. The way to tell is to try to change it. 
    /// If it changes, all the pieces are there. If it doesn't, stuff is missing. </para>
    /// <para>waiting_review - pieces are there and the contributor of the volume has 
    /// requested formal proofing for release approval. </para>
    /// <para>in_review - the proofer is proofing it. </para>
    /// <para>live - available for public consumption. </para>
    /// <para>disabled - unavailable for public consumption. This is used if the agreement 
    /// with the content provider has expired, or a problem has been found with the 
    /// volume and needs to be remedied. </para>
    /// <para>Currently, only incomplete, live, and disabled are being used. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-create/"/>
    /// </summary>
    public class VolumeCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID for the new volume as defined by the format for DAM IDs. Must not 
        /// exist in system already. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The DAM ID for the new volume as provided by FCBH as defined by the format 
        /// for DAM IDs. </para>
        /// </summary>
        [JsonProperty("fcbh_id")]
        public string FcbhId { get; set; }

        /// <summary>
        /// <para>Whether available for mobile delivery or not. </para>
        /// </summary>
        [JsonProperty("mobile")]
        public bool? Mobile { get; set; }

        /// <summary>
        /// <para>Whether available for download delivery or not. </para>
        /// </summary>
        [JsonProperty("download")]
        public bool? Download { get; set; }

        /// <summary>
        /// <para>Whether available for text download delivery or not. </para>
        /// </summary>
        [JsonProperty("download_text")]
        public bool? DownloadText { get; set; }

        /// <summary>
        /// <para>Whether available for web delivery or not. </para>
        /// </summary>
        [JsonProperty("web")]
        public bool? Web { get; set; }

        /// <summary>
        /// <para>Whether available for web streaming delivery or not. </para>
        /// </summary>
        [JsonProperty("web_streaming")]
        public bool? WebStreaming { get; set; }

        /// <summary>
        /// <para>Whether available for sign language targeted applications or not. </para>
        /// </summary>
        [JsonProperty("sign_language")]
        public bool? SignLanguage { get; set; }

        /// <summary>
        /// <para>Whether part of a localized bundled Bible.is product or not. </para>
        /// </summary>
        [JsonProperty("local_bundled")]
        public bool? LocalBundled { get; set; }

        /// <summary>
        /// <para>Whether available for podcast delivery or not. </para>
        /// </summary>
        [JsonProperty("podcast")]
        public bool? Podcast { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store mp3 cd delivery or not. </para>
        /// </summary>
        [JsonProperty("mp3_cd")]
        public bool Mp3Cd { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store digital delivery or not. </para>
        /// </summary>
        [JsonProperty("digital_download")]
        public bool DigitalDownload { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store bible stick delivery or not. </para>
        /// </summary>
        [JsonProperty("bible_stick")]
        public bool BibleStick { get; set; }

        /// <summary>
        /// <para>Whether available for subsplash delivery or not. </para>
        /// </summary>
        [JsonProperty("subsplash")]
        public bool? Subsplash { get; set; }

        /// <summary>
        /// <para>Whether a low resolution version of the volume is available. Currently, only 
        /// relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("lo_res")]
        public bool? LoRes { get; set; }

        /// <summary>
        /// <para>Whether a medium resolution version of the volume is available. Currently, 
        /// only relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("med_res")]
        public bool? MedRes { get; set; }

        /// <summary>
        /// <para>Whether a high resolution version of the volume is available. Currently, only 
        /// relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("hi_res")]
        public bool? HiRes { get; set; }

        /// <summary>
        /// <para>Whether or not text is read from right to left. </para>
        /// </summary>
        [JsonProperty("is_right_to_left")]
        public bool? IsRightToLeft { get; set; }

        /// <summary>
        /// <para>Whether or not a DBP Agreement has been executed between FCBH and the 
        /// organization to which the volume belongs. </para>
        /// </summary>
        [JsonProperty("dbp_agreement")]
        public bool? DbpAgreement { get; set; }

        /// <summary>
        /// <para>Date on which the volume should automatically be made unavailable. Useful for 
        /// agreement limits. </para>
        /// </summary>
        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Name for the new volume. </para>
        /// </summary>
        [JsonProperty("volume_name")]
        public string VolumeName { get; set; }

        /// <summary>
        /// <para>Summary of the new volume. </para>
        /// </summary>
        [JsonProperty("volume_summary")]
        public string VolumeSummary { get; set; }

        /// <summary>
        /// <para>Copyright for the new volume </para>
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        public override string RestUrl => "/library/volume";

    }

    /// <summary>
    /// <para>Update core information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-update/"/>
    /// </summary>
    public class VolumeUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID for the existing volume. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The core volume information, book order, and content must all have been 
        /// created or imported to be able to change the status to anything but 
        /// 'incomplete'. </para>
        /// </summary>
        [JsonProperty("status")]
        public VolumeUpdateStatusEnum Status { get; set; }

        /// <summary>
        /// <para>Whether available for mobile delivery or not. </para>
        /// </summary>
        [JsonProperty("mobile")]
        public bool? Mobile { get; set; }

        /// <summary>
        /// <para>Whether available for download delivery or not. </para>
        /// </summary>
        [JsonProperty("download")]
        public bool? Download { get; set; }

        /// <summary>
        /// <para>Whether available for text download delivery or not. </para>
        /// </summary>
        [JsonProperty("download_text")]
        public bool? DownloadText { get; set; }

        /// <summary>
        /// <para>Whether available for web delivery or not. </para>
        /// </summary>
        [JsonProperty("web")]
        public bool? Web { get; set; }

        /// <summary>
        /// <para>Whether available for web streaming delivery or not. </para>
        /// </summary>
        [JsonProperty("web_streaming")]
        public bool? WebStreaming { get; set; }

        /// <summary>
        /// <para>Whether available for sign language targeted applications or not. </para>
        /// </summary>
        [JsonProperty("sign_language")]
        public bool? SignLanguage { get; set; }

        /// <summary>
        /// <para>Whether part of a localized bundled Bible.is product or not. </para>
        /// </summary>
        [JsonProperty("local_bundled")]
        public bool? LocalBundled { get; set; }

        /// <summary>
        /// <para>Whether available for podcast delivery or not. </para>
        /// </summary>
        [JsonProperty("podcast")]
        public bool? Podcast { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store mp3 cd delivery or not. </para>
        /// </summary>
        [JsonProperty("mp3_cd")]
        public bool Mp3Cd { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store digital delivery or not. </para>
        /// </summary>
        [JsonProperty("digital_delivery")]
        public bool DigitalDelivery { get; set; }

        /// <summary>
        /// <para>(optional Whether available for store bible stick delivery or not. </para>
        /// </summary>
        [JsonProperty("bible_stick")]
        public bool BibleStick { get; set; }

        /// <summary>
        /// <para>Whether available for subsplash delivery or not. </para>
        /// </summary>
        [JsonProperty("subsplash")]
        public bool? Subsplash { get; set; }

        /// <summary>
        /// <para>Whether a low resolution version of the volume is available. Currently, only 
        /// relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("lo_res")]
        public bool? LoRes { get; set; }

        /// <summary>
        /// <para>Whether a medium resolution version of the volume is available. Currently, 
        /// only relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("med_res")]
        public bool? MedRes { get; set; }

        /// <summary>
        /// <para>Whether a high resolution version of the volume is available. Currently, only 
        /// relevant for video volumes. </para>
        /// </summary>
        [JsonProperty("hi_res")]
        public bool? HiRes { get; set; }

        /// <summary>
        /// <para>Whether or not text is read from right to left. </para>
        /// </summary>
        [JsonProperty("is_right_to_left")]
        public bool? IsRightToLeft { get; set; }

        /// <summary>
        /// <para>Whether or not a DBP Agreement has been executed between FCBH and the 
        /// organization to which the volume belongs. </para>
        /// </summary>
        [JsonProperty("dbp_agreement")]
        public bool? DbpAgreement { get; set; }

        /// <summary>
        /// <para>Date on which the volume should automatically be made unavailable. Useful for 
        /// agreement limits. If this has been previously set and it is desired to make 
        /// the volume available indefinitely, use a very large date, like 3000-01-01. </para>
        /// </summary>
        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Name for the volume. The string 'null' (lowercase and without quotes) can be 
        /// used to clear this field. </para>
        /// </summary>
        [JsonProperty("volume_name")]
        public string VolumeName { get; set; }

        /// <summary>
        /// <para>Summary of the volume. The string 'null' (lowercase and without quotes) can 
        /// be used to clear this field. </para>
        /// </summary>
        [JsonProperty("volume_summary")]
        public string VolumeSummary { get; set; }

        /// <summary>
        /// <para>Copyright for the new volume </para>
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        public override string RestUrl => "/library/volume";

    }

    /// <summary>
    /// <para>This method retrieves the list of languages for available volumes and the 
    /// related volume data in the system according to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-language-list/"/>
    /// </summary>
    public class VolumeLanguageListRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the native language or English language language name root. Can be used to 
        /// restrict the response to only languages that start with 'Quechua' for example </para>
        /// </summary>
        [JsonProperty("root")]
        public string Root { get; set; }

        /// <summary>
        /// <para>Consider the language name as being a full word. For instance, when false, 
        /// 'new' will return volumes where the string 'new' is anywhere in the language 
        /// name, like in "Newari" and "Awa for Papua New Guinea". When true, it will 
        /// only return volumes where the language name contains the full word 'new', 
        /// like in "Awa for Papua New Guinea". Default is false. </para>
        /// </summary>
        [JsonProperty("full_word")]
        public bool? FullWord { get; set; }

        /// <summary>
        /// <para>the three letter language code. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>- the format of languages the caller is interested in. This specifies if you 
        /// want languages available in text or languages available in audio. </para>
        /// </summary>
        [JsonProperty("media")]
        public VolumeLanguageListMediaEnum Media { get; set; }

        /// <summary>
        /// <para>a criteria for approved delivery method. It is possible to OR these methods 
        /// together using '|', such as "delivery=streaming|mobile". 'any' means any of 
        /// the supported methods (this list may change over time). 'none' means assets 
        /// that are not approved for any of the supported methods. All returned by 
        /// default. </para>
        /// </summary>
        [JsonProperty("delivery")]
        public VolumeLanguageListDeliveryEnum Delivery { get; set; }

        /// <summary>
        /// <para>Publishing status of volume. The default is 'live'. </para>
        /// </summary>
        [JsonProperty("status")]
        public VolumeLanguageListStatusEnum Status { get; set; }

        /// <summary>
        /// <para>Currently used for video volumes as they can be available in different 
        /// resolutions, basically conforming to the loose general categories of low, 
        /// medium, and high resolution. Low resolution is geared towards devices with 
        /// smaller screens. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public VolumeLanguageListResolutionEnum Resolution { get; set; }

        /// <summary>
        /// <para>The id of an organization by which to filter the languages of available 
        /// volumes. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        public override string RestUrl => "/library/volumelanguage";

    }

    /// <summary>
    /// <para>This method retrieves the list of language families for available volumes and 
    /// the related volume data in the system according to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-language-family-list/"/>
    /// </summary>
    public class VolumeLanguageFamilyListRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the native language or English language language name root. Can be used to 
        /// restrict the response to only languages that start with 'Quechua' for example </para>
        /// </summary>
        [JsonProperty("root")]
        public string Root { get; set; }

        /// <summary>
        /// <para>Consider the language name as being a full word. For instance, when false, 
        /// 'new' will return volumes where the string 'new' is anywhere in the language 
        /// name, like in "Newari" and "Awa for Papua New Guinea". When true, it will 
        /// only return volumes where the language name contains the full word 'new', 
        /// like in "Awa for Papua New Guinea". Default is false. </para>
        /// </summary>
        [JsonProperty("full_word")]
        public bool? FullWord { get; set; }

        /// <summary>
        /// <para>the three letter language code. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>- the format of the volumes of the language families the caller is interested 
        /// in. This specifies if you want language families available in text or audio 
        /// or... </para>
        /// </summary>
        [JsonProperty("media")]
        public VolumeLanguageFamilyListMediaEnum Media { get; set; }

        /// <summary>
        /// <para>a criteria for approved delivery method. It is possible to OR these methods 
        /// together using '|', such as "delivery=streaming|mobile". 'any' means any of 
        /// the supported methods (this list may change over time). 'none' means assets 
        /// that are not approved for any of the supported methods. All returned by 
        /// default. </para>
        /// </summary>
        [JsonProperty("delivery")]
        public VolumeLanguageFamilyListDeliveryEnum Delivery { get; set; }

        /// <summary>
        /// <para>Publishing status of volume. The default is 'live'. </para>
        /// </summary>
        [JsonProperty("status")]
        public VolumeLanguageFamilyListStatusEnum Status { get; set; }

        /// <summary>
        /// <para>Currently used for video volumes as they can be available in different 
        /// resolutions, basically conforming to the loose general categories of low, 
        /// medium, and high resolution. Low resolution is geared towards devices with 
        /// smaller screens. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public VolumeLanguageFamilyListResolutionEnum Resolution { get; set; }

        /// <summary>
        /// <para>The id of an organization by which to filter the languages of available 
        /// volumes. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        public override string RestUrl => "/library/volumelanguagefamily";

    }

    /// <summary>
    /// <para>This call provides basic volume data by organization. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-organization-listing/"/>
    /// </summary>
    public class VolumeOrganizationListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the format of assets the caller is interested in. This specifies if you only 
        /// want volumes available in text or volumes available in audio. </para>
        /// </summary>
        [JsonProperty("media")]
        public VolumeOrganizationListingMediaEnum Media { get; set; }

        /// <summary>
        /// <para>a criteria for approved delivery method. It is possible to OR these methods 
        /// together using '|', such as "delivery=streaming|mobile".  'any' means any of 
        /// the supported methods (this list may change over time) i.e. approved for 
        /// something. 'none' means volumes that are not approved for any of the 
        /// supported methods. All volumes are returned by default. </para>
        /// </summary>
        [JsonProperty("delivery")]
        public VolumeOrganizationListingDeliveryEnum Delivery { get; set; }

        /// <summary>
        /// <para>Filter the versions returned to a specified native or English language 
        /// language name. For example return all the 'English' volumes. </para>
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// <para>Consider the language name as being a full word. For instance, when false, 
        /// 'new' will return volumes where the string 'new' is anywhere in the language 
        /// name, like in "Newari" and "Awa for Papua New Guinea". When true, it will 
        /// only return volumes where the language name contains the full word 'new', 
        /// like in "Awa for Papua New Guinea". Default is false. </para>
        /// </summary>
        [JsonProperty("full_word")]
        public bool? FullWord { get; set; }

        /// <summary>
        /// <para>the three letter language code. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>the three letter language code for the language family. </para>
        /// </summary>
        [JsonProperty("language_family_code")]
        public string LanguageFamilyCode { get; set; }

        /// <summary>
        /// <para>YYYY-MM-DD. This is used to get volumes that were modified since the 
        /// specified date. </para>
        /// </summary>
        [JsonProperty("updated")]
        public string Updated { get; set; }

        /// <summary>
        /// <para>Publishing status of volume. The default is 'live'. </para>
        /// </summary>
        [JsonProperty("status")]
        public VolumeOrganizationListingStatusEnum Status { get; set; }

        /// <summary>
        /// <para>Whether the volume as passed its expiration or not. </para>
        /// </summary>
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>Currently used for video volumes as they can be available in different 
        /// resolutions, basically conforming to the loose general categories of low, 
        /// medium, and high resolution. Low resolution is geared towards devices with 
        /// smaller screens. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public VolumeOrganizationListingResolutionEnum Resolution { get; set; }

        /// <summary>
        /// <para>Organization id by which to filter volumes. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>Organization name, either native language or English, by which to filter 
        /// volumes. </para>
        /// </summary>
        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        public override string RestUrl => "/library/volumeorganization";

    }

    /// <summary>
    /// <para>This call gets the event history for volume changes to status, expiry, basic 
    /// info, delivery, and organization association. The event reflects the previous 
    /// state of the volume. In other words, it reflects the state up to the moment 
    /// of the time of the event. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-history-list/"/>
    /// </summary>
    public class VolumeHistoryListRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the specific volume for which history is wanted. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>the date by which the change was submitted. </para>
        /// </summary>
        [JsonProperty("submitted_by")]
        public string SubmittedBy { get; set; }

        public override string RestUrl => "/library/volumehistory";

    }

    /// <summary>
    /// <para>Gets the book order and code listing for a volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-listing/"/>
    /// </summary>
    public class BookOrderListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID of the volume. If only six characters of a DAM ID are used, this 
        /// call will try to return the matching OT and NT book list, if available. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        public override string RestUrl => "/library/bookorder";

    }

    /// <summary>
    /// <para>Creates a book order for a volume that does not have a book order defined. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-create/"/>
    /// </summary>
    public class BookOrderCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DAM ID for the volume for which the book order will be created. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders with traditional Bible books): This is 
        /// actually an array of book codes of the form book_code[1]=Matt. All book 
        /// orders start with the first book being index 1. So index 7 would be the 
        /// seventh book in the volume. New Testament volumes will automatically have 
        /// their book order values adjusted to the expected output of Matthew being 55 
        /// and so on. </para>
        /// </summary>
        [JsonProperty("book_code")]
        public string BookCode { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders for story volumes): This is actually an 
        /// array of book names of the form book_name[1]=Creation. All book orders start 
        /// with the first book being index 1. So index 7 would be the seventh book in 
        /// the volume. </para>
        /// </summary>
        [JsonProperty("book_name")]
        public string BookName { get; set; }

        public override string RestUrl => "/library/bookorder";

    }

    /// <summary>
    /// <para>Modifies a book order for a volume that already has a book order defined. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-update/"/>
    /// </summary>
    public class BookOrderUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DAM ID for the volume for which the book order will be updated. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders with traditional Bible books): This is 
        /// actually an array of book codes of the form book_code[1]=Matt. All book 
        /// orders start with the first book being index 1. So index 7 would be the 
        /// seventh book in the volume. New Testament volumes will automatically have 
        /// their book order values adjusted to the expected output of Matthew being 55 
        /// and so on. </para>
        /// </summary>
        [JsonProperty("book_code")]
        public string BookCode { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders for story volumes): This is actually an 
        /// array of book names of the form book_name[1]=Creation. All book orders start 
        /// with the first book being index 1. So index 7 would be the seventh book in 
        /// the volume. </para>
        /// </summary>
        [JsonProperty("book_name")]
        public string BookName { get; set; }

        public override string RestUrl => "/library/bookorder";

    }

    /// <summary>
    /// <para>Modifies a book order for a volume that already has a book order defined by 
    /// removing the requested books and retaining the sequence of the remaining 
    /// books in the book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-delete/"/>
    /// </summary>
    public class BookOrderDeleteRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DAM ID for the volume for which the book order will be modified. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders with traditional Bible books): This is 
        /// actually an array of book codes of the form book_code[1]=Matt that will be 
        /// removed from the book order. Unlike bookorder create and update, the array 
        /// index is simply a place holder in the list of books to delete. It does not 
        /// have any relation to an actual order. For example, book_code[1]=Luke will 
        /// remove Luke regardless of its position in the order. So, for this call, the 
        /// array index should simply be sequential natural numbers. </para>
        /// </summary>
        [JsonProperty("book_code")]
        public string BookCode { get; set; }

        /// <summary>
        /// <para>(optional - required for book orders for story volumes): This is actually an 
        /// array of book names of the form book_name[1]=Creation that will be removed 
        /// from the book order. Unlike bookorder create and update, the array index is 
        /// simply a place holder in the list of books to delete. It does not have any 
        /// relation to an actual order. For example, book_name[1]=The+Last+Supper will 
        /// remove that book regardless of its position in the order. So, for this call, 
        /// the array index should simply be sequential natural numbers. </para>
        /// </summary>
        [JsonProperty("book_name")]
        public string BookName { get; set; }

        public override string RestUrl => "/library/bookorder";

    }

    /// <summary>
    /// <para>This method retrieves the list of available books for a specified volume or 
    /// OT/NT volume set, if they exist. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-listing/"/>
    /// </summary>
    public class BookListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID, DAM ID LLLVVVC (where LLL is the language code, VVV is the 
        /// version code, and C is colletion type  [N|O|S|P|B]), or DAM ID LLLVVV piece 
        /// for which to retrieve a list of books. If the six character piece, LLLVVV, 
        /// (or 8 or 9 character pieces) is used, the list will be from both OT and NT, 
        /// whichever exist. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        public override string RestUrl => "/library/book";

    }

    /// <summary>
    /// <para>This call retrieves the native language book names for a DBP language code. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-listing/"/>
    /// </summary>
    public class BookNameListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP language code. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        public override string RestUrl => "/library/bookname";

    }

    /// <summary>
    /// <para>This call is used to create a record of native language book and collection 
    /// names for a DBP language code if such a record does not yet exist. </para>
    /// <para>Warning: the API Explorer cannot be used to make this call. It can be used to 
    /// start building a URL for the call, but the array nature of the name parameter 
    /// is not supported by the API Explorer. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-create/"/>
    /// </summary>
    public class BookNameCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP language code of record to create. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>array of book and collection names indexed by OSIS book code or DBT 
        /// collection code. An example is "name[OT]=Old 
        /// Testament&amp;name[Exod]=Exodus". </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string RestUrl => "/library/bookname";

    }

    /// <summary>
    /// <para>This call is used to update a record of native language book and collection 
    /// names for a DBP language code if such a record does exist. </para>
    /// <para>Warning: the API Explorer cannot be used to make this call. It can be used to 
    /// start building a URL for the call, but the array nature of the name parameter 
    /// is not supported by the API Explorer. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-update/"/>
    /// </summary>
    public class BookNameUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP language code of record to create. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>array of book and collection names indexed by OSIS book code or DBT 
        /// collection code. An example is "name[OT]=Old 
        /// Testament&amp;name[Exod]=Exodus". </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string RestUrl => "/library/bookname";

    }

    /// <summary>
    /// <para>Lists the chapters for a book or all books in a standard bible volume. Story 
    /// volumes in DBP are defined in the same top down fashion as standard bibles. 
    /// So the first partitioning is into books, which correspond to the segments of 
    /// audio or video. So story volumes have no chapters. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/chapter-listing/"/>
    /// </summary>
    public class ChapterListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The 6 - 10 character DAM ID for which to retrieve chapters. A six character 
        /// DAM ID will return the chapter info for related OT and NT if such exist. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The ID for the book for which to retrieve chapters. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        public override string RestUrl => "/library/chapter";

    }

    /// <summary>
    /// <para>This method retrieves the bible verse info for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/verse-info-listing/"/>
    /// </summary>
    public class VerseInfoListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the DAM ID of the verse info. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>If specified returns verse text ONLY for the specified book. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>If specified returns verse text ONLY for the specified book and chapter. </para>
        /// </summary>
        [JsonProperty("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// <para>If specified without 'verse_end' returns verse text ONLY for the specified 
        /// book, chapter, and verse. If specified with 'verse_end' returns all verse 
        /// text for the specified book, chapter, and verse range from 'verse_start' to 
        /// 'verse_end'. </para>
        /// </summary>
        [JsonProperty("verse_start")]
        public string VerseStart { get; set; }

        /// <summary>
        /// <para>If specified returns of all verse text for the specified book, chapter, and 
        /// verse range from 'verse_start' to 'verse_end'. If specified requires that 
        /// 'verse' is also specified. </para>
        /// </summary>
        [JsonProperty("verse_end")]
        public string VerseEnd { get; set; }

        public override string RestUrl => "/library/verseinfo";

    }

    /// <summary>
    /// <para>This call is used to get native language numerals. Native language written 
    /// numbers are useful for chapters and verses. The numerals from 0 to 200 are 
    /// available. The requested numbers will be returned for a valid language code 
    /// in the native language if the language_numbers record exists, or in English 
    /// if not. Non-defined language codes return nothing. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-listing/"/>
    /// </summary>
    public class NumbersListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP Language code of interest. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>First number (in Hindu numerals) of range desired. </para>
        /// </summary>
        [JsonProperty("start")]
        public string Start { get; set; }

        /// <summary>
        /// <para>Last number (in Hindu numerals) of range desired. </para>
        /// </summary>
        [JsonProperty("end")]
        public string End { get; set; }

        public override string RestUrl => "/library/numbers";

    }

    /// <summary>
    /// <para>Creates a numbers record for a language for which the numbers record does not 
    /// yet exist. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-create/"/>
    /// </summary>
    public class NumbersCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP language code for a defined language. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>Array of numerals from 0 to 200 of the form num[1]=א&amp;num[2]=ב </para>
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }

        public override string RestUrl => "/library/numbers";

    }

    /// <summary>
    /// <para>Updates a numbers record for a language for which the numbers record already 
    /// exists. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-update/"/>
    /// </summary>
    public class NumbersUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DBP language code for a defined language. </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>Array of numerals from 0 to 200 of the form num[1]=א&amp;num[2]=ב </para>
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }

        public override string RestUrl => "/library/numbers";

    }

    /// <summary>
    /// <para>This method returns copyright and associated organizations info. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/get-metadata/"/>
    /// </summary>
    public class MetadataListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>Either the DAM ID for which to retrieve copyright info for the specific 
        /// volume, or the seven character DAM ID root for which to retrieve copy right 
        /// info for all matching volumes. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>Organization ID by which to filter. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        public override string RestUrl => "/library/metadata";

    }

    /// <summary>
    /// <para>Create associated information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/metadata-create/"/>
    /// </summary>
    public class MetadataCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID for the existing volume. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The id of an organization responsible for the volume. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>The role of the organizations association with the volume. Defaults to 
        /// 'partner'. </para>
        /// </summary>
        [JsonProperty("organization_role")]
        public MetadataCreateOrganizationRoleEnum OrganizationRole { get; set; }

        public override string RestUrl => "/library/metadata";

    }

    /// <summary>
    /// <para>Update or remove associated information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/metadata-update/"/>
    /// </summary>
    public class MetadataUpdateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID for the existing volume. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The id of an organization responsible for the volume. </para>
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>The role of the organizations association with the volume. </para>
        /// </summary>
        [JsonProperty("organization_role")]
        public MetadataUpdateOrganizationRoleEnum OrganizationRole { get; set; }

        /// <summary>
        /// <para>If set to true, the association of the organization with the volume will be 
        /// removed. False leaves the association as is. </para>
        /// </summary>
        [JsonProperty("disassociate")]
        public bool? Disassociate { get; set; }

        public override string RestUrl => "/library/metadata";

    }

    /// <summary>
    /// <para>This method retrieves information about the asset, such as artwork, 
    /// distribution servers. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-asset-location/"/>
    /// </summary>
    public class VolumeAssetLocationRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>To get the location directory and asset file basename for a specific volume. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        public override string RestUrl => "/library/asset";

    }

    /// <summary>
    /// <para>This method will returns the list of organizations in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-list/"/>
    /// </summary>
    public class OrganizationListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the partial or complete name of the organization in either the organization's 
        /// native language or English. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>the id of the organization </para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>the enabled status of the organization </para>
        /// </summary>
        [JsonProperty("enabled")]
        public OrganizationListingEnabledEnum Enabled { get; set; }

        public override string RestUrl => "/library/organization";

    }

    /// <summary>
    /// <para>This method provides the means to add an organization to the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-create/"/>
    /// </summary>
    public class OrganizationCreateRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the native language name of the organization. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>the English name of the organization. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>the native language description of the organization. </para>
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// <para>the English description of the organization. </para>
        /// </summary>
        [JsonProperty("english_description")]
        public string EnglishDescription { get; set; }

        /// <summary>
        /// <para>the Web URL for the organization </para>
        /// </summary>
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        /// <summary>
        /// <para>the URL for donations to the organization </para>
        /// </summary>
        [JsonProperty("donation_url")]
        public string DonationUrl { get; set; }

        /// <summary>
        /// <para>whether or not the organization is enabled (active) </para>
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        public override string RestUrl => "/library/organization";

    }

    /// <summary>
    /// <para>This method provides the means to modify a organization that already exists 
    /// in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-modify/"/>
    /// </summary>
    public class OrganizationModifyRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>id of the organization </para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>the native language name of the organization. </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>the English name of the organization. </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>the native language description of the organization. </para>
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// <para>the English description of the organization. </para>
        /// </summary>
        [JsonProperty("english_description")]
        public string EnglishDescription { get; set; }

        /// <summary>
        /// <para>the Web URL for the organization </para>
        /// </summary>
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        /// <summary>
        /// <para>the URL for donations to the organization </para>
        /// </summary>
        [JsonProperty("donation_url")]
        public string DonationUrl { get; set; }

        /// <summary>
        /// <para>whether or not the organization is enabled (active) </para>
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        public override string RestUrl => "/library/organization";

    }

    /// <summary>
    /// <para>This method allows the caller to retrieve information about the media 
    /// distribution servers and protocols they support. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/location/"/>
    /// </summary>
    public class LocationRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>Allows the caller to restrict potential servers from being returned that 
        /// don't support a specified protocol. Examples: http, https, rtmp, rtmp-amazon </para>
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        public override string RestUrl => "/audio/location";

    }

    /// <summary>
    /// <para>This call returns the file path information for audio files for a volume. 
    /// This information can be used with the response of the /audio/location call to 
    /// create a URI to retrieve the audio files. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/path/"/>
    /// </summary>
    public class PathRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID for which to retrieve file path info. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The audio encoding format desired. THIS IS CURRENTLY NOT OPERATIONAL. MP3s 
        /// will be returned regardless. </para>
        /// </summary>
        [JsonProperty("encoding")]
        public PathEncodingEnum Encoding { get; set; }

        /// <summary>
        /// <para>The order number of the book in the volume. This is particularly useful for 
        /// story volumes as there are no applicable OSIS book codes. </para>
        /// </summary>
        [JsonProperty("book_order")]
        public string BookOrder { get; set; }

        /// <summary>
        /// <para>The OSIS id of the book. If book is not specified ALL book/chapter 
        /// information for the given language is returned to the caller. Otherwise 
        /// chapter information for the specified book is returned. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>The id for the specified chapter. If chapter is specified only the specified 
        /// chapter audio information is returned to the caller. </para>
        /// </summary>
        [JsonProperty("chapter_id")]
        public string ChapterId { get; set; }

        public override string RestUrl => "/audio/path";

    }

    /// <summary>
    /// <para>This method provides the bible audio verse time starts for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/verse-audio-timecodes-list/"/>
    /// </summary>
    public class VerseAudioTimecodesListRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the DAM ID of the audio volume </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>the book for verse times desired. </para>
        /// </summary>
        [JsonProperty("osis_code")]
        public string OsisCode { get; set; }

        /// <summary>
        /// <para>the chapter for the verse times desired. </para>
        /// </summary>
        [JsonProperty("chapter_number")]
        public string ChapterNumber { get; set; }

        public override string RestUrl => "/audio/versestart";

    }

    /// <summary>
    /// <para>Some languages used by the Digital Bible Platform utilize character sets that 
    /// are not supported by "standard" fonts. This call provides a list of custom 
    /// fonts that have been made available. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/font/"/>
    /// </summary>
    public class FontRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The numeric ID of the font to retrieve </para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>Search for a specific font by name </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Only return fonts that have been authorized for the specified platform. 
        /// Available values are: "android", "ios", "web", or "all" </para>
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        public override string RestUrl => "/text/font";

    }

    /// <summary>
    /// <para>This method retrieves the bible verse text for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/verse/"/>
    /// </summary>
    public class VerseRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>the DAM ID of the verse text </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>If specified returns verse text ONLY for the specified book. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>If specified returns verse text ONLY for the specified book and chapter. </para>
        /// </summary>
        [JsonProperty("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// <para>If specified without 'verse_end' returns verse text ONLY for the specified 
        /// book, chapter, and verse. If specified with 'verse_end' returns all verse 
        /// text for the specified book, chapter, and verse range from 'verse_start' to 
        /// 'verse_end'. </para>
        /// </summary>
        [JsonProperty("verse_start")]
        public string VerseStart { get; set; }

        /// <summary>
        /// <para>If specified returns of all verse text for the specified book, chapter, and 
        /// verse range from 'verse_start' to 'verse_end'. If specified requires that 
        /// 'verse' is also specified. </para>
        /// </summary>
        [JsonProperty("verse_end")]
        public string VerseEnd { get; set; }

        /// <summary>
        /// <para>If specified returns the verse text in a variety of standardized markup 
        /// formats. By default the internal DBT format is returned. Current options 
        /// include OSIS, and native (the default DBT format). </para>
        /// </summary>
        [JsonProperty("markup")]
        public string Markup { get; set; }

        public override string RestUrl => "/text/verse";

    }

    /// <summary>
    /// <para>This method allows the caller to perform a full-text search within the text 
    /// of a volume. If the volume has a complementary testament, the search will be 
    /// performed over both testaments with the results ordered in Bible book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/search/"/>
    /// </summary>
    public class SearchRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID the caller wishes to search in. Using the first eight characters 
        /// of a DAM ID will cause a complementary testament search if the seventh 
        /// character is O or T. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The text that the caller wishes to search for in the specified text. Multiple 
        /// words or phrases can be combined with '+' for AND and '|' for OR. They will 
        /// be processed simply from left to right. So, "Saul+Paul|Ruth" will evaluate as 
        /// (Saul AND Paul) OR Ruth. </para>
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// <para>OSIS book id to limit search. For the interim, if sku is used for dam_id, 
        /// book_id needs to be the old style numerical code. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>The offset for the set of results to return. Default is 0. </para>
        /// </summary>
        [JsonProperty("offset")]
        public string Offset { get; set; }

        /// <summary>
        /// <para>The number of results to return. Default is 50. </para>
        /// </summary>
        [JsonProperty("limit")]
        public string Limit { get; set; }

        public override string RestUrl => "/text/search";

    }

    /// <summary>
    /// <para>This method allows the caller to perform a full-text search within the text 
    /// of a volume, returning the count of results per book. If the volume has a 
    /// complementary testament, the search will be performed over both testaments 
    /// with the results ordered in Bible book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/search-group/"/>
    /// </summary>
    public class SearchGroupRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>The DAM ID the caller wishes to search in. Using the first eight characters 
        /// of a DAM ID will cause a complementary testament search if the seventh 
        /// character is O or T. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The text that the caller wishes to search for in the specified text. Multiple 
        /// words or phrases can be combined with '+' for AND and '|' for OR. They will 
        /// be processed simply from left to right. So, "Saul+Paul|Ruth" will evaluate as 
        /// (Saul AND Paul) OR Ruth. </para>
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        public override string RestUrl => "/text/searchgroup";

    }

    /// <summary>
    /// <para>This method allows the caller to retrieve information about the media 
    /// distribution servers and protocols they support. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-video/video-location/"/>
    /// </summary>
    public class VideoLocationRequest : BaseApiRequest
    {

        public override string RestUrl => "/video/videolocation";

    }

    /// <summary>
    /// <para>This call returns the file path information for video files for a volume. </para>
    /// <para>This call is capable of retrieving the deaf Bible story videos provided by 
    /// DOOR International. These videos contain multiple parts: </para>
    /// <para>Topic – A very brief video signing the name of the file. </para>
    /// <para>Introduction – Introduces signs that are specific to this story. </para>
    /// <para>Story – The main story content. </para>
    /// <para>More Information – Additional teaching or application of the story. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-video/video-path/"/>
    /// </summary>
    public class VideoPathRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DAM ID for the video volume desired. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The video encoding format desired. </para>
        /// </summary>
        [JsonProperty("encoding")]
        public VideoPathEncodingEnum Encoding { get; set; }

        /// <summary>
        /// <para>Resolution of video files requested corresponding to the basic categories of 
        /// low, medium, and high. The default is 'lo'. DBT will determine if the volume 
        /// is configured for the requested resolution. If not, it will return the next 
        /// highest resolution to the requested resolution for which the volume is 
        /// configured. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public VideoPathResolutionEnum Resolution { get; set; }

        /// <summary>
        /// <para>The order number of the video segment in the volume. This is particularly 
        /// useful for story volumes as there are no applicable OSIS book codes. </para>
        /// </summary>
        [JsonProperty("segment_order")]
        public string SegmentOrder { get; set; }

        /// <summary>
        /// <para>OSIS book code to filter segments by references to book desired. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>Chapter id to filter segments by references based on book and chapter. </para>
        /// </summary>
        [JsonProperty("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// <para>Verse id to filter segments by references based on book, chapter and verse. </para>
        /// </summary>
        [JsonProperty("verse_id")]
        public string VerseId { get; set; }

        public override string RestUrl => "/video/videopath";

    }

    /// <summary>
    /// <para>The call retrieves the Jesus Film video segment listing for a Jesus Film 
    /// volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-video/jesus-film-listing/"/>
    /// </summary>
    public class JesusFilmListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>DAM ID for the Jesus Film volume desired. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>The video encoding format desired. </para>
        /// </summary>
        [JsonProperty("encoding")]
        public JesusFilmListingEncodingEnum Encoding { get; set; }

        /// <summary>
        /// <para>OSIS book code to filter segments by references to book desired. </para>
        /// </summary>
        [JsonProperty("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// <para>Chapter id to filter segments by references based on book and chapter. </para>
        /// </summary>
        [JsonProperty("chapter_id")]
        public string ChapterId { get; set; }

        /// <summary>
        /// <para>Verse id to filter segments by references based on book, chapter and verse. </para>
        /// </summary>
        [JsonProperty("verse_id")]
        public string VerseId { get; set; }

        public override string RestUrl => "/library/jesusfilm";

    }

    /// <summary>
    /// <para>This method retrieves country language information. Filter languages by a 
    /// specified country code or filter countries by specified language code. 
    /// Country flags can also be retrieved by requesting one of the permitted image 
    /// sizes. Languages can be sorted by the country code (default) and the language 
    /// code. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/country-language/country-language-listing/"/>
    /// </summary>
    public class CountryLanguageListingRequest : BaseApiRequest
    {

        /// <summary>
        /// <para>: Get records by uppercase ISO language code </para>
        /// </summary>
        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        /// <summary>
        /// <para>: Get records by uppercase ISO country code </para>
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>Get colon separated list of optional countries </para>
        /// </summary>
        [JsonProperty("additional")]
        public int Additional { get; set; }

        /// <summary>
        /// <para>Includes a country flag image of the specified file type. </para>
        /// </summary>
        [JsonProperty("img_type")]
        public CountryLanguageListingImgTypeEnum ImgType { get; set; }

        /// <summary>
        /// <para>(required if img_type is set to "png", otherwise optional): Include country 
        /// flag in entries in requested size. Note: This parameter accepts any 
        /// resolution in the format (width)x(height), however, selecting a resolution 
        /// with an aspect ratio other than 1:1 or 4:3 will likely result in distortion. 
        /// We encourage you to use a standard size (40x30, 80x60, 160X120, 320X240, 
        /// 640X480, or 1280X960) because they can be generated much more quickly than 
        /// other sizes. If this parameter is provided and img_type is omitted, img_type 
        /// is assumed to be "png". This parameter is ignored when img_type is "svg". </para>
        /// </summary>
        [JsonProperty("img_size")]
        public string ImgSize { get; set; }

        /// <summary>
        /// <para>Sort by lang_code or country_code </para>
        /// </summary>
        [JsonProperty("sort_by")]
        public CountryLanguageListingSortByEnum SortBy { get; set; }

        public override string RestUrl => "/country/countrylang";

    }

    public enum LanguageListingSortByEnum
    {
        code,
        name,
        english,
    }

    public enum VersionListingSortByEnum
    {
        code,
        name,
        english,
    }

    public enum VolumeListingMediaEnum
    {
        text,
        audio,
        video,
    }

    public enum VolumeListingDeliveryEnum
    {
        web,
        web_streaming,
        download,
        download_text,
        mobile,
        sign_language,
        streaming_url,
        local_bundled,
        podcast,
        mp3_cd,
        digital_download,
        bible_stick,
        subsplash,
        any,
        none,
    }

    public enum VolumeListingStatusEnum
    {
        live,
        disabled,
        incomplete,
        waiting_review,
        in_review,
        discontinued,
    }

    public enum VolumeListingResolutionEnum
    {
        lo,
        med,
        hi,
    }

    public enum VolumeListingSortByEnum
    {
        dam_id,
        volume_name,
        language_name,
        language_english,
        language_family_code,
        language_family_name,
        version_code,
        version_name,
        version_english,
    }

    public enum VolumeUpdateStatusEnum
    {
        live,
        disabled,
        incomplete,
        waiting_review,
        in_review,
        discontinued,
    }

    public enum VolumeLanguageListMediaEnum
    {
        text,
        audio,
        video,
    }

    public enum VolumeLanguageListDeliveryEnum
    {
        streaming,
        web_streaming,
        download,
        download_text,
        mobile,
        sign_language,
        local_bundled,
        podcast,
        mp3_cd,
        digital_download,
        bible_stick,
        subsplash,
        any,
        none,
    }

    public enum VolumeLanguageListStatusEnum
    {
        live,
        disabled,
        incomplete,
        waiting_review,
        in_review,
        discontinued,
    }

    public enum VolumeLanguageListResolutionEnum
    {
        lo,
        med,
        hi,
    }

    public enum VolumeLanguageFamilyListMediaEnum
    {
        text,
        audio,
        video,
    }

    public enum VolumeLanguageFamilyListDeliveryEnum
    {
        streaming,
        web_streaming,
        download,
        download_text,
        mobile,
        sign_language,
        local_bundled,
        podcast,
        mp3_cd,
        digital_download,
        bible_stick,
        subsplash,
        any,
        none,
    }

    public enum VolumeLanguageFamilyListStatusEnum
    {
        live,
        disabled,
        incomplete,
        waiting_review,
        in_review,
        discontinued,
    }

    public enum VolumeLanguageFamilyListResolutionEnum
    {
        lo,
        med,
        hi,
    }

    public enum VolumeOrganizationListingMediaEnum
    {
        text,
        audio,
        video,
    }

    public enum VolumeOrganizationListingDeliveryEnum
    {
        streaming,
        web_streaming,
        download,
        download_text,
        mobile,
        sign_language,
        local_bundled,
        podcast,
        mp3_cd,
        digital_download,
        bible_stick,
        subsplash,
        any,
        none,
    }

    public enum VolumeOrganizationListingStatusEnum
    {
        live,
        disabled,
        incomplete,
        waiting_review,
        in_review,
        discontinued,
    }

    public enum VolumeOrganizationListingResolutionEnum
    {
        lo,
        med,
        hi,
    }

    public enum MetadataCreateOrganizationRoleEnum
    {
        licensor,
        partner,
    }

    public enum MetadataUpdateOrganizationRoleEnum
    {
        licensor,
        partner,
    }

    public enum OrganizationListingEnabledEnum
    {
        @true,
        @false,
        either,
    }

    public enum PathEncodingEnum
    {
        mp3,
        wav,
    }

    public enum VideoPathEncodingEnum
    {
        mp4,
        m3u8,
    }

    public enum VideoPathResolutionEnum
    {
        lo,
        med,
        hi,
    }

    public enum JesusFilmListingEncodingEnum
    {
        mp4,
        m3u8,
    }


    public enum CountryLanguageListingImgTypeEnum
    {
        png,
        svg,
    }

    public enum CountryLanguageListingSortByEnum
    {
        country_code,
        lang_code,
    }

}
