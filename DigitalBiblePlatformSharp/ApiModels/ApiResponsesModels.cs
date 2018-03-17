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
    public class LanguageListingResponse
    {

        /// <summary>
        /// <para>DBP language code </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>DBP native language language name </para>
        /// </summary>
        [JsonProperty("language_name")]
        public string LanguageName { get; set; }

        /// <summary>
        /// <para>DBP English language language name </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>ISO 639-3 language code </para>
        /// </summary>
        [JsonProperty("language_iso")]
        public string LanguageIso { get; set; }

        /// <summary>
        /// <para>ISO 639-2B language code </para>
        /// </summary>
        [JsonProperty("language_iso_2B")]
        public string LanguageIso2B { get; set; }

        /// <summary>
        /// <para>ISO 639-2T language code </para>
        /// </summary>
        [JsonProperty("language_iso_2T")]
        public string LanguageIso2T { get; set; }

        /// <summary>
        /// <para>ISO 639-1 language code </para>
        /// </summary>
        [JsonProperty("language_iso_1")]
        public string LanguageIso1 { get; set; }

        /// <summary>
        /// <para>ISO language name </para>
        /// </summary>
        [JsonProperty("language_iso_name")]
        public string LanguageIsoName { get; set; }

        /// <summary>
        /// <para>The language code for the language family to which this language belongs </para>
        /// </summary>
        [JsonProperty("language_family_code")]
        public string LanguageFamilyCode { get; set; }


    }

    /// <summary>
    /// <para>Add a language to the language list. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-create/"/>
    /// </summary>
    public class LanguageCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] The new DBP language code will be returned with Success. An 
        /// error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Edit the name of a language. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/language-update/"/>
    /// </summary>
    public class LanguageUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Get the list of versions defined in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-listing/"/>
    /// </summary>
    public class VersionListingResponse
    {

        /// <summary>
        /// <para>The three letter version code. </para>
        /// </summary>
        [JsonProperty("version_code")]
        public string VersionCode { get; set; }

        /// <summary>
        /// <para>The version name in native language. </para>
        /// </summary>
        [JsonProperty("version_name")]
        public string VersionName { get; set; }

        /// <summary>
        /// <para>The version name in English. </para>
        /// </summary>
        [JsonProperty("version_english")]
        public string VersionEnglish { get; set; }


    }

    /// <summary>
    /// <para>Add a version to the version list. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-create/"/>
    /// </summary>
    public class VersionCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Edit the name of a version. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/version-update/"/>
    /// </summary>
    public class VersionUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the list of available volumes in the system according 
    /// to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-listing/"/>
    /// </summary>
    public class VolumeListingResponse
    {

        /// <summary>
        /// <para>volumes (array): an array of volumes with the following fields: </para>
        /// <para>dam_id: DAM ID of volume. </para>
        /// <para>fcbh_id : the volume FCBH DAM ID. </para>
        /// <para>volume_name: Name of volume. </para>
        /// <para>status: [live|disabled|incomplete|waiting_review|in_review|discontinued] 
        /// Publishing status of volume. </para>
        /// <para>dbp_agreement (optional): [true|false] Whether or not a DBP Agreement has 
        /// been executed between FCBH and the organization to whom the volume belongs. </para>
        /// <para>expiration: expiration date. </para>
        /// <para>language_code: DBP language code </para>
        /// <para>language_name: native language name of the language of the volume. </para>
        /// <para>language_english: English language name of the language of the volume. </para>
        /// <para>language_iso: ISO 639-3 language code. </para>
        /// <para>language_iso_2B: ISO 639-2B language code. </para>
        /// <para>language_iso_2T: ISO 639-2T language code. </para>
        /// <para>language_iso_1: ISO 639-1 language code. </para>
        /// <para>language_iso_name: ISO  language name. </para>
        /// <para>language_family_code: DBP language code of language family to which this 
        /// language belongs. </para>
        /// <para>language_family_name: native language name of language family to which this 
        /// language belongs. </para>
        /// <para>language_family_english: English language name of language family to which 
        /// this language belongs. </para>
        /// <para>language_family_iso: ISO 639-3 language code. </para>
        /// <para>language_family_iso_2B: ISO 639-2B language code. </para>
        /// <para>language_family_iso_2T: ISO 639-2T language code. </para>
        /// <para>language_family_iso_1: ISO 639-1 language code. </para>
        /// <para>version_code: Version of volume. </para>
        /// <para>updated_on: Date and time of last update. </para>
        /// <para>right_to_left: [0|1] Boolean with TRUE (1) indicating that the language is 
        /// read right to left. </para>
        /// <para>num_art: Number of art files for this volume. </para>
        /// <para>num_sample_audio: Number of sample audio files for this volume. </para>
        /// <para>sku: Legacy stocknumber, while supported. </para>
        /// <para>media:  media format (text, audio, video,...) </para>
        /// <para>media_type: The variety of the media, such as drama and non-drama. </para>
        /// <para>delivery:  array of delivery methods </para>
        /// <para>resolution: Array of resolutions available, if applicable. </para>
        /// <para>font: If this volume has text that cannot be displayed properly using most 
        /// "standard" fonts, a custom font will be assigned. This field can either be 
        /// null (no font assigned), or a JSON object containing information about the 
        /// font. For information about the structure of this JSON object, see the 
        /// documentation for the /text/font call. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


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
    public class VolumeCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Update core information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-update/"/>
    /// </summary>
    public class VolumeUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the list of languages for available volumes and the 
    /// related volume data in the system according to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-language-list/"/>
    /// </summary>
    public class VolumeLanguageListResponse
    {

        /// <summary>
        /// <para>DBP native language language name </para>
        /// </summary>
        [JsonProperty("language_name")]
        public string LanguageName { get; set; }

        /// <summary>
        /// <para>DBP English language language name </para>
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// <para>DBP language code </para>
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>ISO 639-3 language code. </para>
        /// </summary>
        [JsonProperty("language_iso")]
        public string LanguageIso { get; set; }

        /// <summary>
        /// <para>ISO 639-2B language code. </para>
        /// </summary>
        [JsonProperty("language_iso_2B")]
        public string LanguageIso2B { get; set; }

        /// <summary>
        /// <para>ISO 639-2T language code. </para>
        /// </summary>
        [JsonProperty("language_iso_2T")]
        public string LanguageIso2T { get; set; }

        /// <summary>
        /// <para>ISO 639-1 language code. </para>
        /// </summary>
        [JsonProperty("language_iso_1")]
        public string LanguageIso1 { get; set; }

        /// <summary>
        /// <para>ISO language name </para>
        /// </summary>
        [JsonProperty("language_iso_name")]
        public string LanguageIsoName { get; set; }

        /// <summary>
        /// <para>DBP language code of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_code")]
        public string LanguageFamilyCode { get; set; }

        /// <summary>
        /// <para>native language name of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_name")]
        public string LanguageFamilyName { get; set; }

        /// <summary>
        /// <para>English language name of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_english")]
        public string LanguageFamilyEnglish { get; set; }

        /// <summary>
        /// <para>ISO 639-3 language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso")]
        public string LanguageFamilyIso { get; set; }

        /// <summary>
        /// <para>ISO 639-2B language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_2B")]
        public string LanguageFamilyIso2B { get; set; }

        /// <summary>
        /// <para>ISO 639-2T language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_2T")]
        public string LanguageFamilyIso2T { get; set; }

        /// <summary>
        /// <para>ISO 639-1 language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_1")]
        public string LanguageFamilyIso1 { get; set; }

        /// <summary>
        /// <para>array of media types </para>
        /// </summary>
        [JsonProperty("media")]
        public string Media { get; set; }

        /// <summary>
        /// <para>array of delivery methods </para>
        /// </summary>
        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        /// <summary>
        /// <para>Array of resolutions available, if applicable. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the list of language families for available volumes and 
    /// the related volume data in the system according to the filter specified. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-language-family-list/"/>
    /// </summary>
    public class VolumeLanguageFamilyListResponse
    {

        /// <summary>
        /// <para>DBP language code of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_code")]
        public string LanguageFamilyCode { get; set; }

        /// <summary>
        /// <para>native language name of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_name")]
        public string LanguageFamilyName { get; set; }

        /// <summary>
        /// <para>English language name of language family to which this language belongs. </para>
        /// </summary>
        [JsonProperty("language_family_english")]
        public string LanguageFamilyEnglish { get; set; }

        /// <summary>
        /// <para>ISO 639-3 code for the language family. </para>
        /// </summary>
        [JsonProperty("language_family_iso")]
        public string LanguageFamilyIso { get; set; }

        /// <summary>
        /// <para>ISO 639-2B language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_2B")]
        public string LanguageFamilyIso2B { get; set; }

        /// <summary>
        /// <para>ISO 639-2T language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_2T")]
        public string LanguageFamilyIso2T { get; set; }

        /// <summary>
        /// <para>ISO 639-1 language code. </para>
        /// </summary>
        [JsonProperty("language_family_iso_1")]
        public string LanguageFamilyIso1 { get; set; }

        /// <summary>
        /// <para>array of language codes of languages in family. </para>
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// <para>array of media types </para>
        /// </summary>
        [JsonProperty("media")]
        public string Media { get; set; }

        /// <summary>
        /// <para>array of delivery methods </para>
        /// </summary>
        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        /// <summary>
        /// <para>Array of resolutions available, if applicable. </para>
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }


    }

    /// <summary>
    /// <para>This call provides basic volume data by organization. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-organization-listing/"/>
    /// </summary>
    public class VolumeOrganizationListingResponse
    {

        /// <summary>
        /// <para>volumes (array): an array of volumes grouped by organization with the 
        /// following fields: </para>
        /// <para>organization_name: Name of the organization. </para>
        /// <para>organization_id : The ID of the organization. </para>
        /// <para>number_volumes: Number of volumes. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This call gets the event history for volume changes to status, expiry, basic 
    /// info, delivery, and organization association. The event reflects the previous 
    /// state of the volume. In other words, it reflects the state up to the moment 
    /// of the time of the event. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-history-list/"/>
    /// </summary>
    public class VolumeHistoryListResponse
    {

        /// <summary>
        /// <para>volume for which the event occurred. </para>
        /// </summary>
        [JsonProperty("dam_id")]
        public string DamId { get; set; }

        /// <summary>
        /// <para>the event </para>
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// <para>the timestamp of the event </para>
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }


    }

    /// <summary>
    /// <para>Gets the book order and code listing for a volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-listing/"/>
    /// </summary>
    public class BookOrderListingResponse
    {

        /// <summary>
        /// <para>array of books: </para>
        /// <para>dam_id_root: Seven character DAM ID used to define a book order. </para>
        /// <para>book_order: The absolute book order number. If only six characters of a DAM 
        /// ID are provided as input, which results in a matching OT and NT book list 
        /// being returned, the NT books will be numbered with Matthew as 55. </para>
        /// <para>book_code: The OSIS book code for the book. </para>
        /// <para>book_name: The English name of the book. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>Creates a book order for a volume that does not have a book order defined. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-create/"/>
    /// </summary>
    public class BookOrderCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Modifies a book order for a volume that already has a book order defined. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-update/"/>
    /// </summary>
    public class BookOrderUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Modifies a book order for a volume that already has a book order defined by 
    /// removing the requested books and retaining the sequence of the remaining 
    /// books in the book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-order-delete/"/>
    /// </summary>
    public class BookOrderDeleteResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the list of available books for a specified volume or 
    /// OT/NT volume set, if they exist. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-listing/"/>
    /// </summary>
    public class BookListingResponse
    {

        /// <summary>
        /// <para>books (array): an array of books for the specified DAM ID with the following 
        /// fields: </para>
        /// <para>dam_id_root: First 7 characters of DAM ID, or the full DAM ID if entered. </para>
        /// <para>book_id:  OSIS book code if the volume is a standard bible, or the book order 
        /// if a story volume. </para>
        /// <para>book_name:  Book name. </para>
        /// <para>book_order: Order of book in collection. </para>
        /// <para>number_of_chapters:  Number of chapters in book. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This call retrieves the native language book names for a DBP language code. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-listing/"/>
    /// </summary>
    public class BookNameListingResponse
    {

        /// <summary>
        /// <para>array of OSIS book codes, DBP collection codes and their associated native 
        /// language name. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This call is used to create a record of native language book and collection 
    /// names for a DBP language code if such a record does not yet exist. </para>
    /// <para>Warning: the API Explorer cannot be used to make this call. It can be used to 
    /// start building a URL for the call, but the array nature of the name parameter 
    /// is not supported by the API Explorer. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-create/"/>
    /// </summary>
    public class BookNameCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This call is used to update a record of native language book and collection 
    /// names for a DBP language code if such a record does exist. </para>
    /// <para>Warning: the API Explorer cannot be used to make this call. It can be used to 
    /// start building a URL for the call, but the array nature of the name parameter 
    /// is not supported by the API Explorer. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/book-name-update/"/>
    /// </summary>
    public class BookNameUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Lists the chapters for a book or all books in a standard bible volume. Story 
    /// volumes in DBP are defined in the same top down fashion as standard bibles. 
    /// So the first partitioning is into books, which correspond to the segments of 
    /// audio or video. So story volumes have no chapters. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/chapter-listing/"/>
    /// </summary>
    public class ChapterListingResponse
    {

        /// <summary>
        /// <para>(array): An array of chapters for the specified book(s) and volume(s) with 
        /// the following fields: </para>
        /// <para>dam_id: DAM ID of the volume requested or both NT and OT if a 6 character DAM 
        /// ID is provided for the search. </para>
        /// <para>book_id: OSIS book code. </para>
        /// <para>chapter_id: The id/number of the chapter </para>
        /// <para>chapter_name: The name of the chapter </para>
        /// <para>default: Specifies if this chapter is the default chapter for the given 
        /// volume and book. </para>
        /// </summary>
        [JsonProperty("chapters")]
        public string Chapters { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the bible verse info for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/verse-info-listing/"/>
    /// </summary>
    public class VerseInfoListingResponse
    {

        /// <summary>
        /// <para>book_id </para>
        /// <para>chapter_id </para>
        /// <para>verse_id array </para>
        /// </summary>
        [JsonProperty("verse info array")]
        public string VerseInfoArray { get; set; }


    }

    /// <summary>
    /// <para>This call is used to get native language numerals. Native language written 
    /// numbers are useful for chapters and verses. The numerals from 0 to 200 are 
    /// available. The requested numbers will be returned for a valid language code 
    /// in the native language if the language_numbers record exists, or in English 
    /// if not. Non-defined language codes return nothing. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-listing/"/>
    /// </summary>
    public class NumbersListingResponse
    {

        /// <summary>
        /// <para>array of numerals returned in sequence from the start to the end requested. </para>
        /// <para>num_*:  where * is the Hindu numeral, such as num_20 and num_0. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>Creates a numbers record for a language for which the numbers record does not 
    /// yet exist. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-create/"/>
    /// </summary>
    public class NumbersCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Updates a numbers record for a language for which the numbers record already 
    /// exists. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/numbers-update/"/>
    /// </summary>
    public class NumbersUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method returns copyright and associated organizations info. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/get-metadata/"/>
    /// </summary>
    public class MetadataListingResponse
    {

        /// <summary>
        /// <para>dam_id: DAM ID for the volume </para>
        /// <para>mark: Full copyright mark </para>
        /// <para>volume_summary: volume summary </para>
        /// <para>array of associated organizations </para>
        /// <para>organization_id: Organization id for associated organization. </para>
        /// <para>organization: Native language organization name associated with the volume. </para>
        /// <para>organization_english: English language organization name associated with the 
        /// volume. </para>
        /// <para>organization_role: Role defining organization's association. </para>
        /// <para>organization_url: URL for the organization </para>
        /// <para>organization_donation: URL for organization donations </para>
        /// </summary>
        [JsonProperty("array of volumes")]
        public string ArrayOfVolumes { get; set; }


    }

    /// <summary>
    /// <para>Create associated information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/metadata-create/"/>
    /// </summary>
    public class MetadataCreateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>Update or remove associated information about an existing volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/metadata-update/"/>
    /// </summary>
    public class MetadataUpdateResponse
    {

        /// <summary>
        /// <para>[Success|Fail] An error message will be returned with Fail. </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves information about the asset, such as artwork, 
    /// distribution servers. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/volume-asset-location/"/>
    /// </summary>
    public class VolumeAssetLocationResponse
    {

        /// <summary>
        /// <para>locations (array): An array of matching file locations given the specified 
        /// filter. Will have the following fields: </para>
        /// <para>server: Example cloud.faithcomesbyhearing.com </para>
        /// <para>root_path: Example /volumeassets </para>
        /// <para>priority: Example 6 </para>
        /// <para>volume_id: the location directory and asset file basename for the volume - 
        /// the DAM ID for new volumes or the legacy sku for legacy volumes. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This method will returns the list of organizations in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-list/"/>
    /// </summary>
    public class OrganizationListingResponse
    {

        /// <summary>
        /// <para>(array): an array of organization with the following fields: </para>
        /// <para>id: the id of the organization </para>
        /// <para>name: the native language name of the organization. </para>
        /// <para>english_name: the English name of the organization. </para>
        /// <para>description: the native language description of the organization. </para>
        /// <para>english_description: the English description of the organization. </para>
        /// <para>web_url: the Web URL for the organization </para>
        /// <para>donation_url: the URL for donations to the organization </para>
        /// <para>enabled: [true|false] whether or not the organization is enabled (active) </para>
        /// </summary>
        [JsonProperty("organizations")]
        public string Organizations { get; set; }


    }

    /// <summary>
    /// <para>This method provides the means to add an organization to the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-create/"/>
    /// </summary>
    public class OrganizationCreateResponse
    {

        /// <summary>
        /// <para>[successful|unsuccessful] </para>
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


    }

    /// <summary>
    /// <para>This method provides the means to modify a organization that already exists 
    /// in the system. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-catalog/organization-modify/"/>
    /// </summary>
    public class OrganizationModifyResponse
    {


    }

    /// <summary>
    /// <para>This method allows the caller to retrieve information about the media 
    /// distribution servers and protocols they support. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/location/"/>
    /// </summary>
    public class LocationResponse
    {

        /// <summary>
        /// <para>locations (array): An array of matching file locations given the specified 
        /// filter. Will have the following fields: </para>
        /// <para>protocol: HTTP, HTTPS, RTMP </para>
        /// <para>server: Example mp3.faithcomesbyhearing.com </para>
        /// <para>root_path: Example /mp3audiobibles2/ </para>
        /// <para>CDN: Boolean specifies if the server is a CDN and geographical distributes 
        /// requests </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This call returns the file path information for audio files for a volume. 
    /// This information can be used with the response of the /audio/location call to 
    /// create a URI to retrieve the audio files. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/path/"/>
    /// </summary>
    public class PathResponse
    {

        /// <summary>
        /// <para>chapter (array): Based on the request, any number of chapter information is 
        /// returned to the caller with the following fields: </para>
        /// <para>book_id: unique ID for the associated book for this chapter </para>
        /// <para>chapter_id: The id of the chapter </para>
        /// <para>path: relative file path for the audio file </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This method provides the bible audio verse time starts for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-audio/verse-audio-timecodes-list/"/>
    /// </summary>
    public class VerseAudioTimecodesListResponse
    {

        /// <summary>
        /// <para>verse_id: id of verse </para>
        /// <para>verse_start: time start in seconds of the verse </para>
        /// </summary>
        [JsonProperty("Array of verses")]
        public string ArrayOfVerses { get; set; }


    }

    /// <summary>
    /// <para>Some languages used by the Digital Bible Platform utilize character sets that 
    /// are not supported by "standard" fonts. This call provides a list of custom 
    /// fonts that have been made available. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/font/"/>
    /// </summary>
    public class FontResponse
    {

        /// <summary>
        /// <para>The numeric ID of the font </para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the font </para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>The server directory that the font file(s) can be found in </para>
        /// </summary>
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>A JSON object representing the files available for the font. This JSON object 
        /// is structured as follows: </para>
        /// <para>Key: The file type. Possible file types are: "ttf", "otf", "eot", "woff", 
        /// "svg", and "zip". The ZIP file contains all available formats. </para>
        /// <para>Value: The file name. Append this to the base_url to obtain a complete URL 
        /// for retrieving the desired font file. </para>
        /// </summary>
        [JsonProperty("files")]
        public string Files { get; set; }

        /// <summary>
        /// <para>A JSON object representing the platform authorized to use the font. This JSON 
        /// object is structured as follows: </para>
        /// <para>Key: The platform name. Possible platforms are: "android", "ios", and "web". </para>
        /// <para>Value: True or false. If true, the specified platform is authorized to use 
        /// this font. </para>
        /// </summary>
        [JsonProperty("platforms")]
        public string Platforms { get; set; }


    }

    /// <summary>
    /// <para>This method retrieves the bible verse text for the specified 
    /// volume/book/chapter. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/verse/"/>
    /// </summary>
    public class VerseResponse
    {

        /// <summary>
        /// <para>DBT: </para>
        /// <para>verses (array): An array of verses that match the request with the following 
        /// fields: </para>
        /// <para>book_name </para>
        /// <para>book_id </para>
        /// <para>book_order </para>
        /// <para>chapter_id </para>
        /// <para>chapter_title </para>
        /// <para>paragraph_number </para>
        /// <para>verse_id </para>
        /// <para>verse_text - verse text will contain special markup characters for 
        /// lightweight presentational purposes. Some of these markup sets include: </para>
        /// <para>{WOJ} - denotes text spoken by Jesus </para>
        /// <para>{XREF} - cross reference to another verse </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }

        /// <summary>
        /// <para>OSIS: </para>
        /// <para>Markup format will adhere to OSIS XML Schema as defined at: 
        /// http://www.bibletechnologies.net/. Please note that depending on source text 
        /// and other factors, not all features of OSIS will be exposed to caller. This 
        /// may be, but is not limited to, cross reference information and footnote 
        /// information. Depending on the input parameters, only the requested text will 
        /// be returned to the caller. Thus if only a certain verse is requested ONLY 
        /// that information will be returned in OSIS format. In the case of an error, a 
        /// native format response will be returned to the caller and will contain error 
        /// code and messaging information. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This method allows the caller to perform a full-text search within the text 
    /// of a volume. If the volume has a complementary testament, the search will be 
    /// performed over both testaments with the results ordered in Bible book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/search/"/>
    /// </summary>
    public class SearchResponse
    {

        /// <summary>
        /// <para>The total count of results found, regardless of limit. </para>
        /// </summary>
        [JsonProperty("total_results")]
        public string TotalResults { get; set; }

        /// <summary>
        /// <para>results (array): An array of results found for the specified search, each 
        /// result has the following fields: </para>
        /// <para>dam_id: DAM ID of the volume </para>
        /// <para>book_name: Book name. </para>
        /// <para>book_id: Book id. </para>
        /// <para>book_order: Order of book in volume. </para>
        /// <para>chapter_id: Chapter id. </para>
        /// <para>verse_id: Verse id. </para>
        /// <para>verse_text: The full text of the result returned. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This method allows the caller to perform a full-text search within the text 
    /// of a volume, returning the count of results per book. If the volume has a 
    /// complementary testament, the search will be performed over both testaments 
    /// with the results ordered in Bible book order. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-text/search-group/"/>
    /// </summary>
    public class SearchGroupResponse
    {

        /// <summary>
        /// <para>The total count of results found, regardless of limit. </para>
        /// </summary>
        [JsonProperty("total_results")]
        public string TotalResults { get; set; }

        /// <summary>
        /// <para>results (array): An array of results found for the specified search, each 
        /// result has the following fields: </para>
        /// <para>book_name: Book name. </para>
        /// <para>book_id: Book id. </para>
        /// <para>book_order: Order of book in volume. </para>
        /// <para>results: Number of results. </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


    }

    /// <summary>
    /// <para>This method allows the caller to retrieve information about the media 
    /// distribution servers and protocols they support. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-video/video-location/"/>
    /// </summary>
    public class VideoLocationResponse
    {

        /// <summary>
        /// <para>locations (array): An array of matching file locations given the specified 
        /// filter. Will have the following fields: </para>
        /// <para>protocol: HTTP, HTTPS </para>
        /// <para>server: Example video.dbt.io </para>
        /// </summary>
        //[JsonProperty("")]
        //public string  {get ; set; }


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
    public class VideoPathResponse
    {

        /// <summary>
        /// <para>each element contains the following </para>
        /// <para>segment_order: Order of the segment in the volume. </para>
        /// <para>title: Segment title. (Not included for DOOR International videos.) </para>
        /// <para>book_id: OSIS book code of book to which segment belongs, which is only 
        /// applicable to standard Bible video volumes. </para>
        /// <para>path: relative file path for the video file. For DOOR International videos, 
        /// this path refers to the "story" portion of the video. </para>
        /// <para>chapter_start: Chapter in which segment starts, if standard Bible volume. </para>
        /// <para>verse_start: Verse in which segment starts, if standard Bible volume. </para>
        /// <para>chapter_end: Chapter in which segment ends, if standard Bible volume. </para>
        /// <para>verse_end: Verse in which segment ends, if standard Bible volume. </para>
        /// <para>references: Array of verse references to which the video segment applies if a 
        /// story volume. </para>
        /// <para>related_videos: Array containing paths to related video segments. Used only 
        /// for DOOR International videos. Each element contains the following: </para>
        /// <para>video_type: Indicates what type of related video it is. Can be "Intro", 
        /// "Topic", or "More Info". </para>
        /// <para>path: Relative path for the video file. </para>
        /// <para>thumbnail_image: The file name for the thumbnail image that represents the 
        /// video. Used only for DOOR International videos. The base URL for thumbnails 
        /// is currently: http://cloud.faithcomesbyhearing.com/segment-art/700X510/ </para>
        /// </summary>
        //[JsonProperty("array of video segments:")]
        //public string ArrayOfVideoSegments: {get ; set; }


    }

    /// <summary>
    /// <para>The call retrieves the Jesus Film video segment listing for a Jesus Film 
    /// volume. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/library-video/jesus-film-listing/"/>
    /// </summary>
    public class JesusFilmListingResponse
    {

        /// <summary>
        /// <para>each element contains the following </para>
        /// <para>id: Id of segment. </para>
        /// <para>name: Native language name/description of the segment. </para>
        /// <para>filename: URL with which to retrieve segment. (Parameter name left over from 
        /// proof of concept. Will probably change in new API version). </para>
        /// <para>verses: Array of verse references to which the video segment applies. </para>
        /// </summary>
        //[JsonProperty("array of video segments:")]
        //public string ArrayOfVideoSegments: {get ; set; }


    }

    /// <summary>
    /// <para>This method retrieves country language information. Filter languages by a 
    /// specified country code or filter countries by specified language code. 
    /// Country flags can also be retrieved by requesting one of the permitted image 
    /// sizes. Languages can be sorted by the country code (default) and the language 
    /// code. </para>
    /// <see cref="https://www.digitalbibleplatform.com/docs/api-version-2/country-language/country-language-listing/"/>
    /// </summary>
    public class CountryLanguageListingResponse
    {

        /// <summary>
        /// <para>Numerical country id </para>
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>Language code of associated country </para>
        /// </summary>
        [JsonProperty("lang_code")]
        public string LangCode { get; set; }

        /// <summary>
        /// <para>Country Region </para>
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// <para>ISO country code </para>
        /// </summary>
        [JsonProperty("country_primary")]
        public string CountryPrimary { get; set; }

        /// <summary>
        /// <para>(if requested): Link to country flag image of requested size </para>
        /// </summary>
        [JsonProperty("country_image")]
        public string CountryImage { get; set; }

        /// <summary>
        /// <para>(if requested): Colon separated list of optional countries </para>
        /// </summary>
        [JsonProperty("country_additional")]
        public string CountryAdditional { get; set; }

        /// <summary>
        /// <para>ISO language code </para>
        /// </summary>
        [JsonProperty("iso_language_code")]
        public string IsoLanguageCode { get; set; }

        /// <summary>
        /// <para>Regional Language Name </para>
        /// </summary>
        [JsonProperty("regional_lang_name")]
        public string RegionalLangName { get; set; }

        /// <summary>
        /// <para>Language Family ID </para>
        /// </summary>
        [JsonProperty("family_id")]
        public string FamilyId { get; set; }

        /// <summary>
        /// <para>Full name of country </para>
        /// </summary>
        [JsonProperty("primary_country_name")]
        public string PrimaryCountryName { get; set; }


    }

}
