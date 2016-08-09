using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundErrorResponse
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
        /// Object that contains details on the created refund in case one has been created
        /// </summary>
        [JsonProperty("refundResult")]
        public RefundResult RefundResult { get; set; }
    }
}