using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreatePaymentRequest
    {
        /// <summary>
        /// Object containing the specific input details for bank transfer payments
        /// </summary>
        [JsonProperty("bankTransferPaymentMethodSpecificInput", Required = Required.Default)]
        public BankTransferPaymentMethodSpecificInput BankTransferPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        [JsonProperty("cardPaymentMethodSpecificInput", Required = Required.Default)]
        public CardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for cash payments
        /// </summary>
        [JsonProperty("cashPaymentMethodSpecificInput")]
        public CashPaymentMethodSpecificInput CashPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for direct debit payments
        /// </summary>
        [JsonProperty("directDebitPaymentMethodSpecificInput")]
        public NonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Data that was encrypted client side containing all consumer entered data elements like card data. Note: Because this data can only be submitted once to our system and contains encrypted card data you should not store it. As the data was captured within the context of a client session you also need to submit it to us before the session has expired.
        /// </summary>
        [JsonProperty("encryptedCustomerInput")]
        public string EncryptedCustomerInput { get; set; }

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        //[JsonProperty("fraudFields")]
        //public FraudFields FraudFields { get; set; }

        /// <summary>
        /// Object containing the specific input details for invoice payments
        /// </summary>
        [JsonProperty("invoicePaymentMethodSpecificInput")]
        public InvoicePaymentMethodSpecificInput InvoicePaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Order object containing order related data Please note that this object is required to be able to submit the amount. Required
        /// </summary>
        [JsonProperty("order")]
        public Order Order { get; set; }

        /// <summary>
        /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
        /// </summary>
        [JsonProperty("redirectPaymentMethodSpecificInput")]
        public RedirectPaymentMethodSpecificInput RedirectPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object containing the specific input details for SEPA direct debit payments
        /// </summary>
        [JsonProperty("sepaDirectDebitPaymentMethodSpecificInput")]
        public SepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; }
    }
}