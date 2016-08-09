using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankAccountIban
    {
        /// <summary>
        /// Name in which the account is held. Required for Direct Debit Switzerland (707) payments, except when a token has been included in the request that includes this value. Required for the creation of a Payout Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The IBAN is the International Bank Account Number. It is an internationally agreed format for the BBAN and includes the ISO country code and two check digits. Required for Direct Debit Switzerland (707) payments, except when a token has been included in the request that includes this value. Required for the creation of a Payout Required for Create and Update token.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }
    }
}