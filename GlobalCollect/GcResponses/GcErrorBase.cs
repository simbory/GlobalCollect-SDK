using GlobalCollect.Schema;
using Newtonsoft.Json;

namespace GlobalCollect.GcResponses
{
    public class GcErrorBase
    {
        [JsonProperty("errorId")]
        public string ErrorId { get; set; }

        [JsonProperty("errors")]
        public ApiError[] Errors { get; set; }
    }
}