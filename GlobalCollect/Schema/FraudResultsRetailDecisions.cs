using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class FraudResultsRetailDecisions
    {
        /// <summary>
        /// Result of the fraud service. Provides additional information about the fraud result
        /// </summary>
        [JsonProperty("fraudCode")]
        public string FraudCode { get; set; }

        /// <summary>
        /// Returns the raw score of the neural
        /// </summary>
        [JsonProperty("fraudNeural")]
        public string FraudNeural { get; set; }

        /// <summary>
        /// Result of the fraud service Represent sets of fraud rules returned during the evaluation of the transaction
        /// </summary>
        [JsonProperty("fraudRCF")]
        public string FraudRCF { get; set; }
    }
}