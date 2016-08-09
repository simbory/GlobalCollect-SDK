using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class FixedListValidator
    {
        /// <summary>
        /// List of the allowed values that the field will be validated against
        /// </summary>
        [JsonProperty("allowedValues")]
        public string[] AllowedValues { get; set; }
    }
}