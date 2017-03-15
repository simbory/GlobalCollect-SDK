using System;
using GlobalCollect.GcResponses;
using GlobalCollect.Schema;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// Sessions allow clients, like mobile phones or web-browsers, to make use of our Client API. 
    /// A session always needs to be initiated through the Server API because the client will be able to send 
    /// in API requests on your behalf. Sessions allow consumers to make payments and allow you to easily show
    /// the correct payment product, ask for the right fields and easily present and re-use previously stored
    /// tokenized) payment details. It also allows for client-side encryption of sensitive data, like card 
    /// number, expiry date and CVV.
    /// </summary>
    public class GcSesstionsApi : GcApiBase
    {
        internal GcSesstionsApi(GcConfiguration config) : base(config, "sessions") {}

        /// <summary>
        /// A new session is created by sending a POST request to the above mentioned end-point.
        /// </summary>
        /// <param name="body">the request body</param>
        /// <returns>please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__sessions_post </returns>
        public GcCreateSesstionResponse CreateSession(SessionRequest body)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath(""));
            req.AddBody(body);
            return Execute(req);
        }
    }
}