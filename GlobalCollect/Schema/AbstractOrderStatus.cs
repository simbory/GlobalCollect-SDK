using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AbstractOrderStatus
    {
        /// <summary>
        /// Every payment entity resource has an identifier or pointer associated with it. This id can be used to uniquely reach the resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}