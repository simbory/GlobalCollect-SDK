using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankAccountBban
    {
        /// <summary>
        /// Name in which the account is held. Required for Direct Debit UK (705) payments, except when a token has been included in the request that includes this value. Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Bank account number Required for Direct Debit UK (705) payments, except when a token has been included in the request that includes this value. Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank code Required for Direct Debit UK (705) payments, except when a token has been included in the request that includes this value. Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        [JsonProperty("bankName")]
        public string BankName { get; set; }

        /// <summary>
        /// Branch code
        /// </summary>
        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Bank check digit
        /// </summary>
        [JsonProperty("checkDigit")]
        public string CheckDigit { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where the bank account is held
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}