using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ApiError
    {
        /// <summary>
        /// Error code Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// HTTP status code for this error that can be used to determine the type of error
        /// </summary>
        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// Human-readable error message that is not meant to be relayed to consumer as it might tip off people who are trying to commit fraud
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// In case the error was in relation to a property that was missing or not correct the name of the property in question is returned
        /// </summary>
        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        /// <summary>
        /// ID of the request that can be used for debugging purposes
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}