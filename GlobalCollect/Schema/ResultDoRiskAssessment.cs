using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ResultDoRiskAssessment
    {
        /// <summary>
        /// The Risk Services category with the following possible values: retaildecisionsCCFraudCheck - checks performed by Retail Decisions globalcollectBlacklistCheckCC - Checked against the blacklist on the GlobalCollect platform authorizationCheck - 0$ auth card account validation check ddFraudCheck - Check performed for German market via InterCard validationbankAccount - Bank account details are algorithmically checked if they could exist globalcollectBlacklistCheckDD - Checked against the blacklist on the GlobalCollect platform
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Risk service result with the following possible results: accepted - Based on the checks performed the transaction can be accepted challenged - Based on the checks performed the transaction should be manually reviewed denied - Based on the checks performed the transaction should be rejected no-advice - No fraud check was requested/performed error - The fraud check resulted in an error and the fraud check was thus not performed
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// Object containing the results of the fraud checks performed by Retail Decisions
        /// </summary>
        [JsonProperty("retaildecisionsCCFraudCheckOutput")]
        public RetailDecisionsCCFraudCheckOutput RetaildecisionsCCFraudCheckOutput { get; set; }

        /// <summary>
        /// Object containing the results of the fraud checks performed on the bank account data
        /// </summary>
        [JsonProperty("validationBankAccountOutput")]
        public ValidationBankAccountOutput ValidationBankAccountOutput { get; set; }
    }
}