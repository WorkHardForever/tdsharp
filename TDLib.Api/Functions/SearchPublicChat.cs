using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SearchPublicChat : Function<Chat>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "searchPublicChat";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("username")]
            public string Username { get; set; }
        }
    }
}