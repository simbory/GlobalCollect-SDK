using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class LengthValidator
    {
        /// <summary>
        /// The maximum allowed length
        /// </summary>
        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        /// <summary>
        /// The minimum allowed length
        /// </summary>
        [JsonProperty("minLength")]
        public int MinLength { get; set; }
    }
}