using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ContactDetails
    {
        /// <summary>
        /// Email address of the consumer
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Preference for the type of email message
        ///  markup
        ///  plain-text
        ///  html
        /// </summary>
        [JsonProperty("emailMessageType")]
        public string EmailMessageType { get; set; }

        /// <summary>
        /// Fax number of the consumer
        /// </summary>
        [JsonProperty("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Phone number of the consumer
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}