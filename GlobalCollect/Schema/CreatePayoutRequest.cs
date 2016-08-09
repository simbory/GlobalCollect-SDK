using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreatePayoutRequest
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes Required
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing account holder name and bank account information. This field can only be used for payouts in the UK. Either a BBAN account or an IBAN account should be provided, but not both
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBban BankAccountBban { get; set; }

        /// <summary>
        /// Object containing account holder and IBAN information. Either a BBAN account or an IBAN account should be provided, but not both
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// Object containing the details of the consumer Required
        /// </summary>
        [JsonProperty("customer")]
        public PayoutCustomer Customer { get; set; }

        /// <summary>
        /// Date of the payout sent to the bank by us Format: YYYYMMDD
        /// </summary>
        [JsonProperty("payoutDate")]
        public string PayoutDate { get; set; }

        /// <summary>
        /// Text to be printed on the bank account statement of the beneficiary. The maximum allowed length might differ per country. The data will be automatically truncated to the maximum allowed length. Required
        /// </summary>
        [JsonProperty("payoutText")]
        public string PayoutText { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this transaction Required
        /// </summary>
        [JsonProperty("references")]
        public PayoutReferences References { get; set; }

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        [JsonProperty("swiftCode")]
        public string SwiftCode { get; set; }
    }
}