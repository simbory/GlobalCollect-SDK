using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RetailDecisionsCCFraudCheckOutput
    {
        /// <summary>
        /// Provides additional information about the fraud result
        /// </summary>
        [JsonProperty("fraudCode")]
        public string FraudCode { get; set; }

        /// <summary>
        /// The raw score returned by the Neural check returned by the evaluation of the transaction
        /// </summary>
        [JsonProperty("fraudNeural")]
        public string FraudNeural { get; set; }

        /// <summary>
        /// List of RuleCategoryFlags as setup in the Retail Decisions system that lead to the result
        /// </summary>
        [JsonProperty("fraudRCF")]
        public string FraudRCF { get; set; }
    }
}