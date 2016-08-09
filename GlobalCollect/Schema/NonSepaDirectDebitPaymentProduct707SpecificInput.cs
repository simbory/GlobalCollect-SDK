using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class NonSepaDirectDebitPaymentProduct707SpecificInput
    {
        /// <summary>
        /// Object containing account holder name and IBAN bank account information Required
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// City where the bank resides
        /// </summary>
        [JsonProperty("customerBankCity")]
        public string CustomerBankCity { get; set; }

        /// <summary>
        /// House number of the bank
        /// </summary>
        [JsonProperty("customerBankNumber")]
        public string CustomerBankNumber { get; set; }

        /// <summary>
        /// Street where the bank is located
        /// </summary>
        [JsonProperty("customerBankStreet")]
        public string CustomerBankStreet { get; set; }

        /// <summary>
        /// ZIP code of the bank
        /// </summary>
        [JsonProperty("customerBankZip")]
        public string CustomerBankZip { get; set; }
    }
}