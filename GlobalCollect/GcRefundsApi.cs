using System;
using GlobalCollect.GcResponses;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// The refund API allows you to manipulate refunds that have been created on a payment. Funds will be refunded to either the card or wallet that was originally charged or to a bank account if a direct refund is not possible
    /// </summary>
    public class GcRefundsApi : GcApiBase
    {
        internal GcRefundsApi(GcConfiguration config) : base(config, "refunds")
        {
        }

        /// <summary>
        /// The refund API allows you to manipulate refunds that have been created on a payment. Funds will be refunded 
        /// to either the card or wallet that was originally charged or to a bank account if a direct refund is not possible
        /// </summary>
        /// <param name="refundId">the refund ID created at the payment api</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__refunds__refundId__get </returns>
        public GcRetrieveRefundResponse RetrieveRefund(string refundId)
        {
            if (string.IsNullOrEmpty(refundId))
            {
                throw new ArgumentNullException(nameof(refundId));
            }
            var req = new GcRequest(Config, Method.GET, BuildApiPath("{0}", refundId));
            return Execute(req);
        }

        /// <summary>
        /// Approve a created, unprocessed, refund resource. This is the second half of the two-step refund flow, where 
        /// first you create a refund and review it before instructing GlobalCollect to process the refund. Approving
        /// the refund instructs GlobalCollect to process the submitted refund.
        /// 
        /// To use this API, the existing refund resource should be in status PENDING_APPROVAL.
        /// </summary>
        /// <param name="refundId">the refund ID</param>
        /// <param name="amount">Refund amount to be approved</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__refunds__refundId__approve_post </returns>
        public GcRefundResponse ApproveRefund(string refundId, long amount)
        {
            if (string.IsNullOrEmpty(refundId))
            {
                throw new ArgumentNullException(nameof(refundId));
            }
            if (amount < 1)
            {
                throw new ArgumentException("invalid amount value");
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/approve", refundId));
            req.AddHeader(GetServerHeader());
            req.AddBody(new {amount});
            return Execute(req);
        }

        /// <summary>
        /// This API undoes the approval of the refund. Successful execution of this API puts back the status of a 
        /// refund resource to PENDING_APPROVAL.
        /// 
        /// To execute this REST service refund resource must be at status REFUND_REQUESTED
        /// </summary>
        /// <param name="refundId"></param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__refunds__refundId__cancelapproval_post </returns>
        public GcUndoApproveRefundResponse UndoApproveRefund(string refundId)
        {
            if (string.IsNullOrEmpty(refundId))
            {
                throw new ArgumentNullException(nameof(refundId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/cancelapproval", refundId));
            req.AddHeader(GetServerHeader());
            return Execute(req);
        }

        /// <summary>
        /// Cancelling a refund will mark it as CANCELLED.
        /// 
        /// The canceling of a refund can't be undone.
        /// 
        /// Refunds only at status PENDING_APPROVAL and REFUND_REQUESTED can be cancelled.
        /// </summary>
        /// <param name="refundId">the refund ID</param>
        /// <returns>please refer to https://developer.globalcollect.com/documentation/api/server/#__merchantId__refunds__refundId__cancel_post </returns>
        public GcCancelRefundResponse CancelRefund(string refundId)
        {
            if (string.IsNullOrEmpty(refundId))
            {
                throw new ArgumentNullException(nameof(refundId));
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("{0}/cancel", refundId));
            req.AddHeader(GetServerHeader());
            return Execute(req);
        }
    }
}