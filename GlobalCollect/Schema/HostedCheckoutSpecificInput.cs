using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class HostedCheckoutSpecificInput
    {
        /// <summary>
        /// true - Only payment products that support recurring payments will be shown. Any transactions created will also be tagged as being a first of a recurring sequence. false - Only payment products that support one-off payments will be shown. The default value for this field is false.
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Locale to use to present the MyCheckout payment pages to the consumer. Please make sure that a language pack is configured for the locale you are submitting. If you submit a locale that is not setup on your account we will use the default language pack for your account. You can easily upload additional language packs and set the default language pack in the Configuration Center.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The URL that the consumer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the consumer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process. Note: The provided URL should start with http or https. URLs without will be rejected.
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// true - MyCheckout will show a result page to the consumer when applicable. false - MyCheckout will redirect the consumer back to the provided returnUrl when this is possible. The default value for this field is true.
        /// </summary>
        [JsonProperty("showResultPage")]
        public bool ShowResultPage { get; set; }

        /// <summary>
        /// String containing comma separated tokens (no spaces) associated with the consumer of this hosted checkout. Valid tokens will be used to present the consumer the option to re-use previously used payment details. This means the consumer for instance does not have to re-enter their card details again, which a big plus when the consumer is using his/her mobile phone to complete the checkout.
        /// </summary>
        [JsonProperty("tokens")]
        public string Tokens { get; set; }

        /// <summary>
        /// Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. By specifying a specific variant you can force the use of another variant then the default. This allows you to test out the effect of certain changes to your MyCheckout payment pages in a controlled manner. Please note that you need to specify the ID of the variant.
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }
    }
}