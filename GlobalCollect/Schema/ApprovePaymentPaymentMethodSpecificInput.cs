using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ApprovePaymentPaymentMethodSpecificInput
    {
        /// <summary>
        /// The desired date for the collection Format: YYYYMMDD
        /// </summary>
        [JsonProperty("dateCollect")]
        public string DateCollect { get; set; }

        /// <summary>
        /// Token containing tokenized bank account details
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}