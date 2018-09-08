using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateLanguagePackStrings : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateLanguagePackStrings";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("localization_target")]
                public string LocalizationTarget { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("language_pack_id")]
                public string LanguagePackId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("strings")]
                public LanguagePackString[] Strings { get; set; }
            }
        }
    }
}