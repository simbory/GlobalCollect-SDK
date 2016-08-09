using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TestConnection
    {
        /// <summary>
        /// OK result on the connection to GC
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}