using System.Net;
using GlobalCollect.Schema;

namespace GlobalCollect.GcResponses
{
    /// <summary>
    /// 
    /// </summary>
    public class GcRefundResponse : GcResponseBase<GcRefundError, RefundResult>
    {
        internal GcRefundResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Success => StatusCode == HttpStatusCode.Created;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static implicit operator GcRefundResponse(GcResponse response)
        {
            return new GcRefundResponse(response.StatusCode, response.Content);
        }
    }
}