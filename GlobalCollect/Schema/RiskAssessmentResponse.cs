using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RiskAssessmentResponse
    {
        /// <summary>
        /// Object that contains the results of the performed fraudchecks
        /// </summary>
        [JsonProperty("results")]
        public ResultDoRiskAssessment[] Results { get; set; }
    }
}