using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcCreatePaymentResponse : GcResponseBase<GcCreatePaymentError, CreatePaymentResult>
    {
        internal GcCreatePaymentResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.Created; }
        }

        public static implicit operator GcCreatePaymentResponse(GcResponse response)
        {
            return new GcCreatePaymentResponse(response.StatusCode, response.Content);
        }
    }
}