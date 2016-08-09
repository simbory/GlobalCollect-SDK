using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcUndoCapturePaymentResponse : GcResponseBase<GcErrorBase, CancelPaymentResult>
    {
        internal GcUndoCapturePaymentResponse(HttpStatusCode statusCode, string content)
            : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcUndoCapturePaymentResponse(GcResponse response)
        {
            return new GcUndoCapturePaymentResponse(response.StatusCode, response.Content);
        }
    }
}