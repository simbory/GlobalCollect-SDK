using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderApprovePayment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        [JsonProperty("additionalInput")]
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this transaction
        /// </summary>
        [JsonProperty("references")]
        public OrderReferencesApprovePayment References { get; set; }
    }
}