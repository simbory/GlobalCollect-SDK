using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RegularExpressionValidator
    {
        /// <summary>
        /// Contains the regular expression that the value of the field needs to be validated against
        /// </summary>
        [JsonProperty("regularExpression")]
        public string RegularExpression { get; set; }
    }
}