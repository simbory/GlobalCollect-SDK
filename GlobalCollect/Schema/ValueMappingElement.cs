using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ValueMappingElement
    {
        /// <summary>
        /// Key name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Value corresponding to the key
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}