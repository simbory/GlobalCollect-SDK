using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class MerchantAction
    {
        /// <summary>
        /// Action merchants needs to take in the online payment process. Possible values are: REDIRECT - The consumer needs to be redirected using the details found in redirectData SHOW_INSTRUCTIONS - The consumer needs to be shown payment instruction using the details found in showData. Alternatively the instructions can be rendered by us using the instructionsRenderingData SHOW_TRANSACTION_RESULTS - The consumer needs to be shown the transaction results using the details found in showData. Alternatively the instructions can be rendered by us using the instructionsRenderingData
        /// </summary>
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        /// <summary>
        /// Object containing all data needed to redirect the consumer
        /// </summary>
        [JsonProperty("redirectData")]
        public RedirectData RedirectData { get; set; }

        /// <summary>
        /// This field contains the blob with data for the instructions rendering service. This service will be available at the following endpoint: http(s)://{{merchant specific subdomain}}.{{base MyCheckout hosted payment pages domain}}/instructions/{{merchantId}}/{{clientSessionId}} This instructions page rendering service accepts the following parameters: instructionsRenderingData (required, the content of this field) locale (optional, if present overrides default locale, e.g. "en_GB") variant (optional, code of a variant, if present overrides default variant, e.g. "100") You can offer a link to a consumer to see an instructions page for a payment done earlier. Because of the size of the instructionsRenderingData this will need to be set in a web form as a value of a hidden field. Before presenting the link you need to obtain a clientSessionId by creating a session using the S2S API. You will need to use the MyCheckout hosted payment pages domain hosted in the same region as the API domain used for the createClientSession call. The instructionsRenderingData is a String blob that is presented to you via the Server API as part of the merchantAction (if available, and non-redirect) in the JSON return values for the createPayment call or the getHostedCheckoutStatus call (merchantAction inside createdPaymentOutput when available). You are responsible to store the instructionsRenderingData blob in order to be able to present the instructions page at a later time, when this information might no longer be available through Server API calls.
        /// </summary>
        [JsonProperty("renderingData")]
        public string RenderingData { get; set; }

        /// <summary>
        /// Array of key value pairs of data that needs to be shown to the consumer. This is returned for both the SHOW_INSTRUCTION as well as the SHOW_TRANSACTION_RESULTS actionType. Note: The returned value for the key BARCODE is a base64 encoded gif image. By prepending 'data:image/gif;base64,' this value can be used as the source of an HTML inline image.
        /// </summary>
        [JsonProperty("showData")]
        public KeyValuePair[] ShowData { get; set; }
    }
}