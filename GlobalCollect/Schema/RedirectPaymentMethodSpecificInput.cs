using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentMethodSpecificInput
    {
        /// <summary>
        /// true false
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Object contacting specific input required for Dutch iDeal payments (Payment product ID 809)
        /// </summary>
        [JsonProperty("paymentProduct809SpecificInput")]
        public RedirectPaymentProduct809SpecificInput PaymentProduct809SpecificInput { get; set; }

        /// <summary>
        /// Object contacting specific input required for German giropay payments (Payment product ID 816)
        /// </summary>
        [JsonProperty("paymentProduct816SpecificInput")]
        public RedirectPaymentProduct816SpecificInput PaymentProduct816SpecificInput { get; set; }

        /// <summary>
        /// Object contacting specific input required for Indian Net Banking payments (Payment product ID 882)
        /// </summary>
        [JsonProperty("paymentProduct882SpecificInput")]
        public RedirectPaymentProduct882SpecificInput PaymentProduct882SpecificInput { get; set; }

        /// <summary>
        /// Payment product identifier Required when this object is included and no encryptedCustomerInput or token object is supplied in the request.
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// first = This transaction is the first of a series of recurring transactions
        /// recurring = This transaction is a subsequent transaction in a series of recurring transactions
        /// Note: This field is required when isRecurring is set to true.
        /// </summary>
        [JsonProperty("recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// The URL that the consumer is redirect to after the payment flow has finished. 
        /// You can add any number of key value pairs in the query string that, for instance help you to identify the consumer when they return to your site. 
        /// Please note that we will also append some additional key value pairs that will also help you with this identification process. 
        /// Note: The provided URL should start with http or https. URLs without will be rejected. Required for the creation of a payment using the /payments API.
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// ID of the token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}