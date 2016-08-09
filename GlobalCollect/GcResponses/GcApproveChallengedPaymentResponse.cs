using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcApproveChallengedPaymentResponse : GcResponseBase<GcErrorBase, Payment>
    {
        internal GcApproveChallengedPaymentResponse(HttpStatusCode statusCode, string content)
            : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcApproveChallengedPaymentResponse(GcResponse response)
        {
            return new GcApproveChallengedPaymentResponse(response.StatusCode, response.Content);
        }
    }
}