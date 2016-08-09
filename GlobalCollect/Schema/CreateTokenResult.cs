using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreateTokenResult
    {
        [JsonProperty("isNewToken")]
        public bool IsNewToken { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}