using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class KeyValuePair
    {
        /// <summary>
        /// Name of the key or field
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Value of the key or field
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}