using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    public class GcRiskAssessCardResponse : GcResponseBase<GcErrorBase, RiskAssessmentResponse>
    {
        public GcRiskAssessCardResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        public override bool Success
        {
            get { return StatusCode == HttpStatusCode.OK; }
        }

        public static implicit operator GcRiskAssessCardResponse(GcResponse response)
        {
            return new GcRiskAssessCardResponse(response.StatusCode, response.Content);
        }
    }
}