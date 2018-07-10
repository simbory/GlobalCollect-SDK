using System.Net;

namespace GlobalCollect.GcResponses
{
    /// <summary>
    /// 
    /// </summary>
    public class GcApproveRefoundResponse : GcResponseBase<GcErrorBase, NoContentResult>
    {
        internal GcApproveRefoundResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Success => StatusCode == HttpStatusCode.NoContent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static implicit operator GcApproveRefoundResponse(GcResponse response)
        {
            return new GcApproveRefoundResponse(response.StatusCode, response.Content);
        }
    }
}
