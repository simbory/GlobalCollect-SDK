using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankAccount
    {
        /// <summary>
        /// Name in which the account is held. Required for Direct Debit UK (705) payments, except when a token has been included in the request that includes this value. Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("accountHolderName")]
        public string AccountHolderName { get; set; }
    }
}