using System.Net;

namespace GlobalCollect.GcResponses
{
    /// <summary>
    /// 
    /// </summary>
    public class GcResponse : GcResponseBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override bool Success => StatusCode == HttpStatusCode.OK ||
                                        StatusCode == HttpStatusCode.Created ||
                                        StatusCode == HttpStatusCode.NoContent;

        internal GcResponse(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }
    }
}