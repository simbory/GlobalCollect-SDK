using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BankAccountBbanRefund
    {
        /// <summary>
        /// Name in which the account is held. Required for Direct Debit UK (705) payments, except when a token has been included in the request that includes this value. Required for Create and Update token calls.
        /// </summary>
        [JsonProperty("accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Bank account number
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// City of the bank to refund to
        /// </summary>
        [JsonProperty("bankCity")]
        public string BankCity { get; set; }

        /// <summary>
        /// Bank code
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

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        [JsonProperty("swiftCode")]
        public string SwiftCode { get; set; }
    }
}