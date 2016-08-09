using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductDisplayHints
    {
        /// <summary>
        /// The order in which the payment products should be shown (sorted ascending)
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Name of the field based on the locale that was included in the request
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Partial URL that you can reference for the image of this payment product. You can use our server-side resize functionality by appending '?size={{width}}x{{height}}' to the full URL, where width and height are specified in pixels. The resized image will always keep its correct aspect ratio.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}