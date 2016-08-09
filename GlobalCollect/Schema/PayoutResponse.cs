using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PayoutResponse
    {
        /// <summary>
        /// Our unique payout transaction identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Object containing payout details
        /// </summary>
        [JsonProperty("payoutOutput")]
        public OrderOutput PayoutOutput { get; set; }

        /// <summary>
        /// Current high-level status of the payouts in a human-readable form. Possible values are : CREATED - The transaction has been created. This is the initial state once a new payout is created. PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the paying out of the funds REJECTED - The transaction has been rejected PAYOUT_REQUESTED - The transaction is in the queue to be payed out to the consumer ACCOUNT_CREDITED - We have successfully credited the consumer REJECTED_CREDIT - The credit to the account of the consumer was rejected by the bank CANCELLED - You have cancelled the transaction REVERSED - The payout has been reversed and the money is returned to your balance
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// This object has the numeric representation of the current payout status, timestamp of last status change and performable action on the current payout resource. In case of a rejected payout, detailed error information is listed.
        /// </summary>
        [JsonProperty("statusOutput")]
        public OrderStatusOutput StatusOutput { get; set; }
    }
}