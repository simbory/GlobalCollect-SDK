using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenNonSepaDirectDebitPaymentProduct707SpecificData
    {
        /// <summary>
        /// Object containing account holder name and IBAN bank account information Required
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }
    }
}