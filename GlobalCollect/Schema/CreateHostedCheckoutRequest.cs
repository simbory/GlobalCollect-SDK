using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreateHostedCheckoutRequest
    {
        /// <summary>
        /// Object containing the specific input details for bank transfer payments
        /// </summary>
        [JsonProperty("bankTransferPaymentMethodSpecificInput")]
        public BankTransferPaymentMethodSpecificInputBase BankTransferPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        [JsonProperty("cardPaymentMethodSpecificInput")]
        public CardPaymentMethodSpecificInputBase CardPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for cash payments
        /// </summary>
        [JsonProperty("cashPaymentMethodSpecificInput")]
        public CashPaymentMethodSpecificInputBase CashPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        [JsonProperty("fraudFields")]
        public FraudFields FraudFields { get; set; }

        /// <summary>
        /// Object containing hosted checkout specific data
        /// </summary>
        [JsonProperty("hostedCheckoutSpecificInput")]
        public HostedCheckoutSpecificInput HostedCheckoutSpecificInput { get; set; }

        /// <summary>
        /// Order object containing order related data Required
        /// </summary>
        [JsonProperty("order")]
        public Order Order { get; set; }

        /// <summary>
        /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
        /// </summary>
        [JsonProperty("redirectPaymentMethodSpecificInput")]
        public RedirectPaymentMethodSpecificInputBase RedirectPaymentMethodSpecificInput { get; set; }
    }
}