using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ApproveRefundRequest
    {
        /// <summary>
        /// Refund amount to be approved
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}