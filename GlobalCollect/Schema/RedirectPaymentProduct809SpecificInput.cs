using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentProduct809SpecificInput
    {
        /// <summary>
        /// This sets the maximum amount of minutes a consumer has to complete the payment at the bank. After this period has expired it is impossible for the consumer to make a payment and in case no payment has been made the transaction will be marked as unsuccessful and expired by the bank. Setting the expirationPeriod is convenient if you want to maximise the time a consumer has to complete the payment. Please note that it is normal for a consumer to take up to 5 minutes to complete a payment. Setting this value below 10 minutes is not advised. You can set this value in minutes with a maximum value of 60 minutes. If no input is provided the default value of 60 is used for the transaction.
        /// </summary>
        [JsonProperty("expirationPeriod")]
        public string ExpirationPeriod { get; set; }

        /// <summary>
        /// ID of the issuing bank of the consumer. A list of available issuerIDs can be obtained by using the retrieve payment product directory API. Required when this object is included and no encryptedCustomerInput is supplied in the request containing this information.
        /// </summary>
        [JsonProperty("issuerId")]
        public string IssuerId { get; set; }
    }
}