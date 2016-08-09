using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentCreationReferences
    {
        /// <summary>
        /// The additional reference identifier for this transaction. Data in this field will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        [JsonProperty("additionalReference")]
        public string AdditionalReference { get; set; }

        /// <summary>
        /// The external reference identifier for this transaction. Data in this field will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        [JsonProperty("externalReference")]
        public string ExternalReference { get; set; }
    }
}