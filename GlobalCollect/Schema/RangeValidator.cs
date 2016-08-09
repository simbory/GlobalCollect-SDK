using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RangeValidator
    {
        /// <summary>
        /// Upper value of the range that is still valid
        /// </summary>
        [JsonProperty("maxValue")]
        public int MaxValue { get; set; }

        /// <summary>
        /// Lower value of the range that is still valid
        /// </summary>
        [JsonProperty("minValue")]
        public int MinValue { get; set; }
    }
}