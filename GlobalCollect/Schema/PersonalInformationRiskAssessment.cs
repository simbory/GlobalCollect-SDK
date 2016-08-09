using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PersonalInformationRiskAssessment
    {
        /// <summary>
        /// Object containing the name details of the consumer
        /// </summary>
        [JsonProperty("name")]
        public PersonalNameRiskAssessment Name { get; set; }
    }
}