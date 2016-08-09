using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RiskAssessmentBankAccount
    {
        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBban BankAccountBban { get; set; }

        /// <summary>
        /// Object containing account holder name and IBAN information
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        [JsonProperty("fraudFields")]
        public FraudFields FraudFields { get; set; }

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        [JsonProperty("order")]
        public OrderRiskAssessment Order { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}