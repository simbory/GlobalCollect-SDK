using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRetrieveRefundResponse : GcResponseBase<GcErrorBase, Payment>
    {
        internal GcRetrieveRefundResponse(HttpStatusCode statusCode, string content)
            : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcRetrieveRefundResponse(GcResponse response)
        {
            return new GcRetrieveRefundResponse(response.StatusCode, response.Content);
        }
    }
}