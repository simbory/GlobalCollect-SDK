using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CustomerToken
    {
        /// <summary>
        /// Object containing the billing address details Required
        /// </summary>
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Object containing company information
        /// </summary>
        [JsonProperty("companyInformation")]
        public CompanyInformation CompanyInformation { get; set; }

        /// <summary>
        /// Your identifier for the consumer that can be used as a search criteria in our Payment Console and is also included in our report files
        /// </summary>
        [JsonProperty("merchantCustomerId")]
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// Object containing personal information of the consumer
        /// </summary>
        [JsonProperty("personalInformation")]
        public PersonalInformationToken PersonalInformation { get; set; }

        /// <summary>
        /// Local VAT number of the consumer
        /// </summary>
        [JsonProperty("vatNumber")]
        public string VatNumber { get; set; }
    }
}