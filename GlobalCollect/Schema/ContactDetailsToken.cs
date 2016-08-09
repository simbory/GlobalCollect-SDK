using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ContactDetailsToken
    {
        /// <summary>
        /// Email address of the consumer
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Preference for the type of email message markup plain-text html
        /// </summary>
        [JsonProperty("emailMessageType")]
        public string EmailMessageType { get; set; }
    }
}