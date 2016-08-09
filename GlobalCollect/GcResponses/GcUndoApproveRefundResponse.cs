using System.Net;

namespace GlobalCollect.GcResponses
{
    public class GcUndoApproveRefundResponse : GcResponseBase
    {
        public GcUndoApproveRefundResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.NoContent; }
        }

        public static implicit operator GcUndoApproveRefundResponse(GcResponse response)
        {
            return new GcUndoApproveRefundResponse(response.StatusCode, response.Content);
        }
    }
}