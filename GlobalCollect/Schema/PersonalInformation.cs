using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PersonalInformation
    {
        /// <summary>
        /// The date of birth of the consumer
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// The gender of the consumer, possible values are: male female unknown or empty
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Object containing the name details of the consumer Required for Direct Debit Switzerland (707), except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("name")]
        public PersonalName Name { get; set; }
    }
}