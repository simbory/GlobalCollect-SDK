using System.Net;

namespace GlobalCollect.GcResponses
{
    public class GcCancelRefundResponse : GcUndoApproveRefundResponse
    {
        public GcCancelRefundResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public static implicit operator GcCancelRefundResponse(GcResponse response)
        {
            return new GcCancelRefundResponse(response.StatusCode, response.Content);
        }
    }
}