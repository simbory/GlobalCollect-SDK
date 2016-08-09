using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankDetailsResponse
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBban BankAccountBban { get; set; }

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// Object that holds the reformatted bank account data
        /// </summary>
        [JsonProperty("bankData")]
        public BankData BankData { get; set; }

        /// <summary>
        /// Object that holds all the SWIFT routing information
        /// </summary>
        [JsonProperty("swift")]
        public Swift Swift { get; set; }
    }
}