using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PersonalInformationToken
    {
        /// <summary>
        /// Object containing the name details of the consumer
        /// </summary>
        [JsonProperty("name")]
        public PersonalNameToken Name { get; set; }
    }
}