using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankDetails
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
    }
}