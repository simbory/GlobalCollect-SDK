using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRetrievePaymentResponse : GcResponseBase<GcErrorBase, Payment>
    {
        internal GcRetrievePaymentResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcRetrievePaymentResponse(GcResponse response)
        {
            return new GcRetrievePaymentResponse(response.StatusCode, response.Content);
        }
    }
}