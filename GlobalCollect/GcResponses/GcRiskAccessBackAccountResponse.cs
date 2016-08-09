using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRiskAccessBackAccountResponse : GcResponseBase<GcErrorBase, RiskAssessmentResponse>
    {
        public GcRiskAccessBackAccountResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcRiskAccessBackAccountResponse(GcResponse response)
        {
            return new GcRiskAccessBackAccountResponse(response.StatusCode, response.Content);
        }
    }
}