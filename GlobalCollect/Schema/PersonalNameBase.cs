using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PersonalNameBase
    {
        /// <summary>
        /// Given name(s) or first name(s) of the consumer
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Surname(s) or last name(s) of the consumer Required for Direct Debit Switzerland (707), except when a token has been included in the request that includes this value. Required for the creation of a Payout.
        /// </summary>
        [JsonProperty("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Middle name - In between first name and surname - of the consumer
        /// </summary>
        [JsonProperty("surnamePrefix")]
        public string SurnamePrefix { get; set; }
    }
}