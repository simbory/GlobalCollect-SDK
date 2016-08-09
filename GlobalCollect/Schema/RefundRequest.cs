using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundRequest
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the specific input details for a bank refund
        /// </summary>
        [JsonProperty("bankRefundMethodSpecificInput")]
        public BankRefundMethodSpecificInput BankRefundMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the details of the consumer
        /// </summary>
        [JsonProperty("customer")]
        public RefundCustomer Customer { get; set; }

        /// <summary>
        /// Refund date Format: YYYYMMDD
        /// </summary>
        [JsonProperty("refundDate")]
        public string RefundDate { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this refund
        /// </summary>
        [JsonProperty("refundReferences")]
        public RefundReferences RefundReferences { get; set; }
    }
}