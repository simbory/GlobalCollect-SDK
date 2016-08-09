using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CompanyInformation
    {
        /// <summary>
        /// Name of company, as a consumer
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}