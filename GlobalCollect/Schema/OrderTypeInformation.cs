using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderTypeInformation
    {
        /// <summary>
        /// Possible values are: good service
        /// </summary>
        [JsonProperty("purchaseType")]
        public string PurchaseType { get; set; }

        /// <summary>
        /// Possible values are: private commercial
        /// </summary>
        [JsonProperty("usageType")]
        public string UsageType { get; set; }
    }
}