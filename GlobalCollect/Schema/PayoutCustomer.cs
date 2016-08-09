using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PayoutCustomer
    {
        /// <summary>
        /// Object containing address details Required
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Object containing company information
        /// </summary>
        [JsonProperty("companyInformation")]
        public CompanyInformation CompanyInformation { get; set; }

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        [JsonProperty("contactDetails")]
        public ContactDetailsBase ContactDetails { get; set; }

        /// <summary>
        /// Your identifier for the consumer that can be used as a search criteria in our Payment Console and is also included in our report files
        /// </summary>
        [JsonProperty("merchantCustomerId")]
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// Object containing PersonalName object Required
        /// </summary>
        [JsonProperty("name")]
        public PersonalName Name { get; set; }
    }
}