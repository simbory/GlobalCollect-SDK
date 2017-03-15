using System;
using GlobalCollect.GcResponses;
using GlobalCollect.Schema;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// https://developer.globalcollect.com/documentation/api/server/#hostedcheckouts
    /// </summary>
    public class GcHostedCheckoutsApi : GcApiBase
    {
        internal GcHostedCheckoutsApi(GcConfiguration config) : base(config, "hostedcheckouts")
        {
        }

        /// <summary>
        /// You can start a hostedCheckout flow by posting the relevant details to the endpoint. 
        /// We will then return you all the details you need to redirect the consumer to us,
        /// retrieve the status and recognize the consumer when he/she returns to your website.
        /// </summary>
        /// <param name="body">request body</param>
        /// <returns></returns>
        public GcCreateHostedCheckoutResponse CreateHostedCheckout(CreateHostedCheckoutRequest body)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath(""));
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// You can retrieve the current status of the hosted checkout by doing a get on the hostedCheckoutId. 
        /// When a payment has been created during the hosted checkout session the details are returned in this object.
        /// 
        /// Sessions have a maximum life span of 2 hours. This means that you can only retrieve this information while the session has not timed-out.
        /// 
        /// The status of the hostedCheckout and the payment will change when the consumer is still busy completing the hosted checkout session.
        /// </summary>
        /// <param name="hostedCheckoutId">the hosted checkout id</param>
        /// <returns></returns>
        public GcGetHostedCheckoutResponse GetHostedCheckoutStatus(string hostedCheckoutId)
        {
            if (string.IsNullOrEmpty(hostedCheckoutId))
            {
                throw new ArgumentNullException(nameof(hostedCheckoutId));
            }
            var req = new GcRequest(Config, Method.GET, BuildApiPath("{0}", hostedCheckoutId));
            return Execute(req);
        }
    }
}