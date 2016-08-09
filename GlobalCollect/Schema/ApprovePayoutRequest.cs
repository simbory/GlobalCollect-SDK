using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ApprovePayoutRequest
    {
        /// <summary>
        /// The desired date for the payout Format: YYYYMMDD
        /// </summary>
        [JsonProperty("datePayout")]
        public string DatePayout { get; set; }
    }
}