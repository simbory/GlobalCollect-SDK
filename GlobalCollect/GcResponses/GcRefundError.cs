using GlobalCollect.Schema;
using Newtonsoft.Json;

namespace GlobalCollect.GcResponses
{
    public class GcRefundError : GcErrorBase
    {
        [JsonProperty("refundResult")]
        public RefundResult RefundResult { get; set; }
    }
}