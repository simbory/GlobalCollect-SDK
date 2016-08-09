using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentStatusOutput
    {
        /// <summary>
        /// Custom object contains the set of errors
        /// </summary>
        [JsonProperty("errors")]
        public ApiError[] Errors { get; set; }

        /// <summary>
        /// Indicates if the transaction has been authorized true false
        /// </summary>
        [JsonProperty("isAuthorized")]
        public bool IsAuthorized { get; set; }

        /// <summary>
        /// Flag indicating if the payment can be cancelled true false
        /// </summary>
        [JsonProperty("isCancellable")]
        public bool IsCancellable { get; set; }

        /// <summary>
        /// Numeric status code that can also be found in the Payment Console and in our report files
        /// </summary>
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Date and time of payment Format: YYYYMMDDHH24MISS
        /// </summary>
        [JsonProperty("statusCodeChangeDateTime")]
        public string StatusCodeChangeDateTime { get; set; }
    }
}