using System.Net;
using Newtonsoft.Json.Linq;

namespace GlobalCollect.GcResponses
{
    public class GcDeleteTokenResponse : GcResponseBase<GcErrorBase, JObject>
    {
        public GcDeleteTokenResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
            if (string.IsNullOrEmpty(content))
            {
                Content = "{}";
            }
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.NoContent; }
        }

        public static implicit operator GcDeleteTokenResponse(GcResponse response)
        {
            return new GcDeleteTokenResponse(response.StatusCode, response.Content);
        }
    }
}