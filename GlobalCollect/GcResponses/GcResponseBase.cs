using System.Net;
using Newtonsoft.Json;

namespace GlobalCollect.GcResponses
{
    public abstract class GcResponseBase
    {
        public HttpStatusCode StatusCode { get; protected set; }

        public string Content { get; protected set; }

        protected GcResponseBase(HttpStatusCode statusCode, string content)
        {
            StatusCode = statusCode;
            Content = content;
        }

        public abstract bool Success { get; }
    }

    public abstract class GcResponseBase<TError, TSuccess> : GcResponseBase
        where TError: class
        where TSuccess: class 
    {
        internal GcResponseBase(HttpStatusCode statusCode, string content) : base(statusCode, content)
        {
        }

        private TError _errorResult;
        public TError ErrorResult
        {
            get
            {
                if (Success)
                {
                    return null;
                }
                return _errorResult ?? (_errorResult = JsonConvert.DeserializeObject<TError>(Content));
            }
        }

        private TSuccess _successResult;
        public TSuccess SuccessResult
        {
            get
            {
                if (!Success)
                {
                    return null;
                }
                return _successResult ?? (_successResult = JsonConvert.DeserializeObject<TSuccess>(Content));
            }
        }
    }
}