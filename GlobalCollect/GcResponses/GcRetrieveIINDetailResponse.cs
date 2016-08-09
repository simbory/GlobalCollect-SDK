using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class RetrieveIINDetailResult : GcResponseBase<GcCreatePaymentError, RetrieveIINDetailResponse>
    {
        internal RetrieveIINDetailResult(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator RetrieveIINDetailResult(GcResponse response)
        {
            return new RetrieveIINDetailResult(response.StatusCode, response.Content);
        }
    }
}