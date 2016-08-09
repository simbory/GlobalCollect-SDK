using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ValidationBankAccountOutput
    {
        /// <summary>
        /// Array of checks performed with the results of each check
        /// </summary>
        [JsonProperty("checks")]
        public ValidationBankAccountCheck[] Checks { get; set; }

        /// <summary>
        /// Bank name, matching the bank code of the request
        /// </summary>
        [JsonProperty("newBankName")]
        public string NewBankName { get; set; }

        /// <summary>
        /// Reformatted account number according to local clearing rules
        /// </summary>
        [JsonProperty("reformattedAccountNumber")]
        public string ReformattedAccountNumber { get; set; }

        /// <summary>
        /// Reformatted bank code according to local clearing rules
        /// </summary>
        [JsonProperty("reformattedBankCode")]
        public string ReformattedBankCode { get; set; }

        /// <summary>
        /// Reformatted branch code according to local clearing rules
        /// </summary>
        [JsonProperty("reformattedBranchCode")]
        public string ReformattedBranchCode { get; set; }
    }
}