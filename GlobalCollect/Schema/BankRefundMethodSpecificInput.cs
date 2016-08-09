using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankRefundMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBbanRefund BankAccountBban { get; set; }

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where money will be refunded to
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}