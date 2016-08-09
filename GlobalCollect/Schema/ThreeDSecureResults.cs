using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ThreeDSecureResults
    {
        /// <summary>
        /// CAVV or AVV result indicating authentication validation value
        /// </summary>
        [JsonProperty("cavv")]
        public string Cavv { get; set; }

        /// <summary>
        /// Indicates Authentication validation results returned after AuthenticationValidation
        /// </summary>
        [JsonProperty("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// Transaction ID for the Authentication
        /// </summary>
        [JsonProperty("xid")]
        public string Xid { get; set; }
    }
}