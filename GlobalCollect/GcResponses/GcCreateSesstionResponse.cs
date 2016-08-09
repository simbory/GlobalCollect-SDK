using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCreateSesstionResponse : GcResponseBase<GcErrorBase, SessionResponse>
    {
        public GcCreateSesstionResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcCreateSesstionResponse(GcResponse response)
        {
            return new GcCreateSesstionResponse(response.StatusCode, response.Content);
        }
    }
}