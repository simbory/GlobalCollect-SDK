using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class SessionResponse
    {
        /// <summary>
        /// The identifier of the session that has been created.
        /// </summary>
        [JsonProperty("clientSessionId")]
        public string ClientSessionId { get; set; }

        /// <summary>
        /// The session is build up around the consumer in the form of the customerId. All of the Client APIs use this customerId in the URI to identify the consumer.
        /// </summary>
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Tokens that are submitted in the request are validated. In case any of the tokens can't be used anymore they are returned in this array. You should most likely remove those tokens from your system.
        /// </summary>
        [JsonProperty("invalidTokens")]
        public string[] InvalidTokens { get; set; }

        /// <summary>
        /// Possible values: EU - datacenter located in Amsterdam US - datacenter located in Miami When a session is created it is created in a specific datacenter. Any subsequent calls using the Client API need to be datacenter specific. The region is identified either by EU (datacenter located in Amsterdam) or US (datacenter located in Miami). This value needs to be passed to the a Client SDK to make sure that the client software connects to the right datacenter.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}