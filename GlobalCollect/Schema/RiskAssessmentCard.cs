using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RiskAssessmentCard
    {
        /// <summary>
        /// Object containing Card object
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        [JsonProperty("fraudFields")]
        public FraudFields FraudFields { get; set; }

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        [JsonProperty("order")]
        public OrderRiskAssessment Order { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}