using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PayoutErrorResponse
    {
        /// <summary>
        /// Unique reference, for debugging purposes, of this error response Required
        /// </summary>
        [JsonProperty("errorId")]
        public string ErrorId { get; set; }

        /// <summary>
        /// List of one or more errors Required
        /// </summary>
        [JsonProperty("errors")]
        public ApiError[] Errors { get; set; }

        /// <summary>
        /// Object that contains details on the created payout in case one has been created
        /// </summary>
        [JsonProperty("payoutResult")]
        public PayoutResult PayoutResult { get; set; }
    }
}