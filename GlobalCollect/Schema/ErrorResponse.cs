using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ErrorResponse
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
    }
}