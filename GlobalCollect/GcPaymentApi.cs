using System;
using GlobalCollect.GcResponses;
using GlobalCollect.Schema;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// The payments REST services allow you to initiate a payment, retrieve the payment details or perform specific actions like refunding or requesting capture of a payment. Every payment can be uniquely identified by its paymentId. Some payment products allow a two step approach allowing you to control when the authorization takes place separate from when the funds are actually captured.
    /// </summary>
    public class GcPaymentApi : GcApiBase
    {
        internal GcPaymentApi(GcConfiguration config) : base(config, "payments")
        {
        }

        /// <summary>
        /// You initiate a payment by posting all the required payment details. After you have done 
        /// so one or more of the following things can take place:
        /// </summary>
        /// <param name="body">the request body object</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments_post </returns>
        public GcCreatePaymentResponse CreatePayment(CreatePaymentRequest body)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.POST, ApiGroupKey);
            req.AddHeader(GetServerHeader());
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// Retrieves the details of a payment that has previously been created by suppling the unique paymentId that was returned to you with the create payment request.
        /// </summary>
        /// <param name="paymentId">the payment ID from CreatePayment method</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__get </returns>
        public GcRetrievePaymentResponse RetrievePayment(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            var req = new GcRequest(Config, Method.GET, BuildApiPath(paymentId));
            return Execute(req);
        }

        /// <summary>
        /// In case the fraud screening resulted in a challenged payment denoted by the PENDING_FRAUD_APROVAL 
        /// state, you have reviewed the payment and want to continue processing, you can do so by calling 
        /// this API. The payment will then move to the status that the payment would have moved to in case 
        /// it wasn't marked as PENDING_FRAUD_APROVAL. You would use this API mostly for card transactions, 
        /// but Direct Debit and PayPal transactions can also end up in a PENDING_FRAUD_APROVAL state.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__processchallenged_post </returns>
        public GcApproveChallengedPaymentResponse ApproveChallengedPayment(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/processchallenged", paymentId));
            return Execute(req);
        }

        /// <summary>
        /// When you are ready to capture the funds on a payment with a PENDING_APPROVAL state you can call this API.
        /// This API will make the transaction eligible to be captured. Depending on the payment product and the 3rd 
        /// party used to process the payment this might be done in real-time or in more off-line batch like fashion.
        /// 
        /// Based on how your account has been configured transactions will require this second approval step before 
        /// the funds are actually captured.
        /// 
        /// PENDING_APPROVAL is a common status only with card and direct debit transactions. Only with special 
        /// configuration is it possible to also have this for PayPal transactions.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <param name="body">the request body</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__approve_post </returns>
        public GcCapturePaymentResponse CapturePayment(string paymentId, ApprovePaymentRequest body)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/approve", paymentId));
            req.AddHeader(GetServerHeader());
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// Use this call if you want to convert the payment details into a re-usable token. This call is especially 
        /// useful if you don't have access to sensitive data like card data, but you have processed transaction 
        /// successfully based on card data that has been collected either on GlobalCollect's hosted payment pages 
        /// or through one of the Client SDKs that encrypted this data.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__tokenize_post </returns>
        public GcCreateTokenResponse CreateTokenFromPayment(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/tokenize", paymentId));
            req.AddHeader(GetServerHeader());
            return Execute(req);
        }

        /// <summary>
        /// If you decided that you don't want to process the payment it is always smart to cancel the payment.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__cancel_post </returns>
        public GcCancelPaymentResponse CancelPayment(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/cancel", paymentId));
            return Execute(req);
        }

        /// <summary>
        /// You can refund any transaction by just calling this API. The system will automatically select the most 
        /// appropriate means to refund the transaction based on the payment product that was used for the payment
        /// and the currency and the country of the refund request.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <param name="body">the request body</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__refund_post </returns>
        public GcRefundResponse CreateRefund(string paymentId, object body)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/refund", paymentId));
            req.AddHeader(GetServerHeader());
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// For every payment that has been placed into the capture queue that can still be removed from that queue
        /// you use this call. When this call is processed successfully the transaction will be be returned in a
        /// PENDING_APPROVAL state.
        /// 
        /// The request does not have any additional input parameters.
        /// </summary>
        /// <param name="paymentId">the payment ID</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__payments__paymentId__cancelapproval_post </returns>
        public GcUndoCapturePaymentResponse UndoCapturePaymentRequest(string paymentId)
        {
            if (string.IsNullOrEmpty(paymentId))
            {
                throw new ArgumentNullException(nameof(paymentId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/cancelapproval", paymentId));
            return Execute(req);
        }
    }
}