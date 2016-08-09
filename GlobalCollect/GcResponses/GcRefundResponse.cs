using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRefundResponse : GcResponseBase<GcRefundError, RefundResult>
    {
        internal GcRefundResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.Created; }
        }

        public static implicit operator GcRefundResponse(GcResponse response)
        {
            return new GcRefundResponse(response.StatusCode, response.Content);
        }
    }
}