using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProduct
    {
        /// <summary>
        /// List of tokens for that payment product
        /// </summary>
        [JsonProperty("accountsOnFile")]
        public AccountOnFile[] AccountsOnFile { get; set; }

        /// <summary>
        /// Indicates if the product supports recurring payments true - This payment product supports recurring payments false - This payment product does not support recurring transactions and can only be used for one-off payments
        /// </summary>
        [JsonProperty("allowsRecurring")]
        public bool AllowsRecurring { get; set; }

        /// <summary>
        /// Indicates if the payment details can be tokenized for future re-use true - Payment details from payments done with this payment product can be tokenized for future re-use false - Payment details from payments done with this payment product can not be tokenized
        /// </summary>
        [JsonProperty("allowsTokenization")]
        public bool AllowsTokenization { get; set; }

        /// <summary>
        /// Indicates if the payment details can be automatically tokenized for future re-use true - Payment details from payments done with this payment product can be automatically tokenized for future re-use false - Payment details from payments done with this payment product can not be automatically tokenized
        /// </summary>
        [JsonProperty("autoTokenized")]
        public bool AutoTokenized { get; set; }

        /// <summary>
        /// Object containing display hints like the order in which the product should be shown, the name of the product and the logo
        /// </summary>
        [JsonProperty("displayHints")]
        public PaymentProductDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// Object containing all the fields and their details that are associated with this payment product. If you are not interested in the data on the fields you should have us filter them our (using filter=fields in the query-string)
        /// </summary>
        [JsonProperty("fields")]
        public PaymentProductField[] Fields { get; set; }

        /// <summary>
        /// The ID of the payment product in our system Required
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Maximum amount in EUR cents (using 2 decimals, so 1 EUR becomes 100 cents) for transactions done with this payment product
        /// </summary>
        [JsonProperty("maxAmount")]
        public int MaxAmount { get; set; }

        /// <summary>
        /// Minimum amount in EUR cents (using 2 decimals, so 1 EUR becomes 100 cents) for transactions done with this payment product
        /// </summary>
        [JsonProperty("minAmount")]
        public int MinAmount { get; set; }

        /// <summary>
        /// This provides insight into the level of support for payments using a device with a smaller screen size. You can for instance use this to rank payment products differently on devices with a smaller screen. Possible values are: BASIC_SUPPORT - The payment product has not optimized its user experience for devices with smaller screens OPTIMIZED_SUPPORT - The payment product offers a user experience that has been optimized for devices with smaller screens
        /// </summary>
        [JsonProperty("mobileIntegrationLevel")]
        public string MobileIntegrationLevel { get; set; }

        /// <summary>
        /// Indicates whether the payment product requires redirection to a third party to complete the payment. You can use this to filter out products that require a redirect if you don't want to support that. true - Redirection is required false - No redirection is required
        /// </summary>
        [JsonProperty("usesRedirectionTo3rdParty")]
        public bool UsesRedirectionTo3rdParty { get; set; }
    }
}