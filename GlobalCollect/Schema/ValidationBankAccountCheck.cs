using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ValidationBankAccountCheck
    {
        /// <summary>
        /// Code of the bank account validation check
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of check performed
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Result of the bank account validation check performed, with the following possible results: PASSED - The check passed ERROR - The check did not pass WARNING - Depending on your needs this either needs to be treated as a passed or error response. It depends on your business logic and for what purpose you want to use the validated bank account details. NOTCHECKED - This check was not performed, usually because one of the earlier checks already caused an error response to be triggered
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}