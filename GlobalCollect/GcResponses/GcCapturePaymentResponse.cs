using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCapturePaymentResponse: GcResponseBase<GcErrorBase, CapturePaymentResult>
    {
        internal GcCapturePaymentResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcCapturePaymentResponse(GcResponse response)
        {
            return new GcCapturePaymentResponse(response.StatusCode, response.Content);
        }
    }
}