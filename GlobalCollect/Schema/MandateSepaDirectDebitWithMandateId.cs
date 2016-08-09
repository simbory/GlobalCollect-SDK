using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class MandateSepaDirectDebitWithMandateId
    {
        /// <summary>
        /// Object containing Account holder and IBAN information Required for the creation of a token for the iban field within this object.
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// Identifies the contract between consumer and merchant
        /// </summary>
        [JsonProperty("customerContractIdentifier")]
        public string CustomerContractIdentifier { get; set; }

        /// <summary>
        /// Object containing information on the debtor Required for the creation of a token for the surname field within this object.
        /// </summary>
        [JsonProperty("debtor")]
        public Debtor Debtor { get; set; }

        /// <summary>
        /// true false
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Object containing the details of the mandate approval
        /// </summary>
        [JsonProperty("mandateApproval")]
        public MandateApproval MandateApproval { get; set; }

        /// <summary>
        /// Unique mandate identifier
        /// </summary>
        [JsonProperty("mandateId")]
        public string MandateId { get; set; }

        /// <summary>
        /// Indicates whether a pre-notification should be sent to the consumer. do-not-send - Do not send a pre-notification send-on-first-collection - Send a pre-notification
        /// </summary>
        [JsonProperty("preNotification")]
        public string PreNotification { get; set; }
    }
}