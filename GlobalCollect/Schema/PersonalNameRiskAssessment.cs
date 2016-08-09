using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PersonalNameRiskAssessment
    {
        /// <summary>
        /// Given name(s) or first name(s) of the consumer
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Surname(s) or last name(s) of the consumer
        /// </summary>
        [JsonProperty("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// The prefix of the surname - in between first name and surname - of the consumer
        /// </summary>
        [JsonProperty("surnamePrefix")]
        public string SurnamePrefix { get; set; }
    }
}