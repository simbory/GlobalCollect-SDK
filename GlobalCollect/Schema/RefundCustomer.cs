using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundCustomer
    {
        /// <summary>
        /// Object containing address details
        /// </summary>
        [JsonProperty("address")]
        public AddressPersonal Address { get; set; }

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
    }
}