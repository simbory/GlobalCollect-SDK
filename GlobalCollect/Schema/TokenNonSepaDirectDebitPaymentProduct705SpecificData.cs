using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenNonSepaDirectDebitPaymentProduct705SpecificData
    {
        /// <summary>
        /// Core reference number for the direct debit instruction in UK Required except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("authorisationId")]
        public string AuthorisationId { get; set; }

        /// <summary>
        /// Object containing account holder name and bank account information Required
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBban BankAccountBban { get; set; }
    }
}