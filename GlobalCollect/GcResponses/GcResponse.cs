using System.Net;

namespace GlobalCollect.GcResponses
{
    public class GcResponse : GcResponseBase
    {
        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK || StatusCode == HttpStatusCode.Created; }
        }

        internal GcResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }
    }
}