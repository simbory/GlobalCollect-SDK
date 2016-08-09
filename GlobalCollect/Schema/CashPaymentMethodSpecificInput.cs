using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CashPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the specific data for Boleto Bancário in Brazil (payment product 1503)
        /// </summary>
        [JsonProperty("paymentProduct1503SpecificInput")]
        public CashPaymentProduct1503SpecificInput PaymentProduct1503SpecificInput { get; set; }

        /// <summary>
        /// Object that holds the specific data for Konbini in Japan (payment product 1504)
        /// </summary>
        [JsonProperty("paymentProduct1504SpecificInput")]
        public CashPaymentProduct1504SpecificInput PaymentProduct1504SpecificInput { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}