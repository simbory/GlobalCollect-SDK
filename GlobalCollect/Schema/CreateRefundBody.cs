using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreateRefundBody
    {
        [JsonProperty("refundReferences")]
        public RefundReferences RefundReferences { get; set; }

        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("refundDate")]
        public string RefundDate { get; set; }

        [JsonProperty("cardPaymentMethodSpecificInput")]
        public CardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; }

    }
}
