using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCreateTokenResponse : GcResponseBase<GcErrorBase, CreateTokenResult>
    {
        internal GcCreateTokenResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK || StatusCode == HttpStatusCode.Created; }
        }

        public static implicit operator GcCreateTokenResponse(GcResponse response)
        {
            return new GcCreateTokenResponse(response.StatusCode, response.Content);
        }
    }
}