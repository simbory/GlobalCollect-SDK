using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRetrieveTokenResponse : GcResponseBase<GcErrorBase, TokenBody>
    {
        public GcRetrieveTokenResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcRetrieveTokenResponse(GcResponse response)
        {
            return new GcRetrieveTokenResponse(response.StatusCode, response.Content);
        }
    }
}