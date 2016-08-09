using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProduct840CustomerAccount
    {
        /// <summary>
        /// Username with which the PayPal account holder has registered at PayPal
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Identification of the PayPal recurring billing agreement
        /// </summary>
        [JsonProperty("billingAgreementId")]
        public string BillingAgreementId { get; set; }

        /// <summary>
        /// Name of the company in case the PayPal account is owned by a business
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Country where the PayPal account is located
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Status of the PayPal account. Possible values are: verified - PayPal has verified the funding means for this account unverified - PayPal has not verified the funding means for this account
        /// </summary>
        [JsonProperty("customerAccountStatus")]
        public string CustomerAccountStatus { get; set; }

        /// <summary>
        /// Status of the consumer's shipping address as registered by PayPal Possible values are: none - Status is unknown at PayPal confirmed - The address has been confirmed unconfirmed - The address has not been confirmed
        /// </summary>
        [JsonProperty("customerAddressStatus")]
        public string CustomerAddressStatus { get; set; }

        /// <summary>
        /// First name of the PayPal account holder
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The unique identifier of a PayPal account and will never change in the life cycle of a PayPal account
        /// </summary>
        [JsonProperty("payerId")]
        public string PayerId { get; set; }

        /// <summary>
        /// Surname of the PayPal account holder
        /// </summary>
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }
}