using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CustomerRiskAssessment
    {
        /// <summary>
        /// Object containing billing address details
        /// </summary>
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The locale that the consumer should be addressed in (for 3rd parties). Note that some 3rd party providers only support the languageCode part of the locale, in those cases we will only use part of the locale provided.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Object containing personal information like name, date of birth and gender
        /// </summary>
        [JsonProperty("personalInformation")]
        public PersonalInformationRiskAssessment PersonalInformation { get; set; }

        /// <summary>
        /// Object containing shipping address details
        /// </summary>
        [JsonProperty("shippingAddress")]
        public AddressPersonal ShippingAddress { get; set; }
    }
}