using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCreateHostedCheckoutResponse : GcResponseBase<GcErrorBase, CreateHostedCheckoutResponse>
    {
        public GcCreateHostedCheckoutResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.Created; }
        }

        public static implicit operator GcCreateHostedCheckoutResponse(GcResponse response)
        {
            return new GcCreateHostedCheckoutResponse(response.StatusCode, response.Content);
        }
    }
}
