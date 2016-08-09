using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCancelPaymentResponse : GcResponseBase<GcErrorBase, CancelPaymentResult>
    {
        internal GcCancelPaymentResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcCancelPaymentResponse(GcResponse response)
        {
            return new GcCancelPaymentResponse(response.StatusCode, response.Content);
        }
    }
}