using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderRiskAssessment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        [JsonProperty("additionalInput")]
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; }

        /// <summary>
        /// Object containing amount and ISO currency code attributes Required
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the details of the consumer
        /// </summary>
        [JsonProperty("customer")]
        public CustomerRiskAssessment Customer { get; set; }
    }
}