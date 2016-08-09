using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CashPaymentProduct1504SpecificInput
    {
        /// <summary>
        /// The URL that the consumer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the consumer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process. Note: The provided URL should start with http or https. URLs without will be rejected.
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }
    }
}