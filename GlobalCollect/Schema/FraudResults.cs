using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class FraudResults
    {
        /// <summary>
        /// Results from the fraud prevention check. Possible values are: accepted - Based on the checks performed the transaction can be accepted challenged - Based on the checks performed the transaction should be manually reviewed denied - Based on the checks performed the transaction should be rejected no-advice - No fraud check was requested/performed error - The fraud check resulted in an error and the fraud check was thus not performed
        /// </summary>
        [JsonProperty("fraudServiceResult")]
        public string FraudServiceResult { get; set; }
    }
}