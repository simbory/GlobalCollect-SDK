using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentProduct882SpecificInput
    {
        /// <summary>
        /// ID of the issuing bank of the consumer. A list of available issuerIDs can be obtained by using the retrieve payment product directory API. Required for the creation of a payment using the /payments API.
        /// </summary>
        [JsonProperty("issuerId")]
        public string IssuerId { get; set; }
    }
}