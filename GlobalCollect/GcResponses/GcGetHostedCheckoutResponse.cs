using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcGetHostedCheckoutResponse : GcResponseBase<GcErrorBase, GetHostedCheckoutResponse>
    {
        public GcGetHostedCheckoutResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcGetHostedCheckoutResponse(GcResponse response)
        {
            return new GcGetHostedCheckoutResponse(response.StatusCode, response.Content);
        }
    }
}