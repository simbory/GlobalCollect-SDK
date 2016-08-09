using System.Net;

namespace GlobalCollect.GcResponses
{
    public class GcUpdateTokenResponse : GcResponseBase
    {
        public GcUpdateTokenResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.NoContent; }
        }

        public static implicit operator GcUpdateTokenResponse(GcResponse response)
        {
            return new GcUpdateTokenResponse(response.StatusCode, response.Content);
        }
    }
}