using GlobalCollect.Schema;
using Newtonsoft.Json;

namespace GlobalCollect.GcResponses
{
    public class GcCreatePaymentError : GcErrorBase
    {
        [JsonProperty("paymentResult")]
        public CreatePaymentResult PaymentResult { get; set; }
    }
}