using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    /// <summary>
    /// 
    /// </summary>
    public class GcRetrieveTokenResponse : GcResponseBase<GcErrorBase, TokenBody>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="content"></param>
        public GcRetrieveTokenResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Success => StatusCode == HttpStatusCode.OK;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static implicit operator GcRetrieveTokenResponse(GcResponse response)
        {
            return new GcRetrieveTokenResponse(response.StatusCode, response.Content);
        }
    }
}