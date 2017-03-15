using System;
using GlobalCollect.GcResponses;
using GlobalCollect.Schema;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// Using our tokenization service you can tokenize re-usable payment data like card data, bank account data including Direct Debit Mandates and PayPal BillingAgreementIDs. The main purpose for tokens is re-use of payment details. The additional benefit is that you do not need to store any sensitive payment details on your server, while still having the benefit to be able to re-use them. This allows you to process recurring card transactions without actually having access to the real card data.
    /// Tokens can be used for two types of transactions:
    /// Recurring: Automatically charging your consumer in a regular, e.g.monthly, time frame;
    /// One-off: Charge the consumer without the consumer having to re-enter all of their payment details.
    /// The second scenario can be used to facilitate a one-click checkout solution, that would still allow the consumer to enter only their CVV value for a card transaction.CVV values can't be tokenized as they are not allowed to be stored at all.
    /// Besides the re-use of payment data, tokens have one other major use-case: Direct Debit Mandates.Especially SEPA Direct Debit transactions require that the mandate for the transactions is managed through a token with an associated mandate. Mandates are created in one go with the token, but can have a state that requires that they are approved before they can be used. As the mandate process is in most cases an offline process the approval will allow you to set the location and date where and when the mandate was signed by the consumer. Without an approved SEPA mandate you will not be able to process any payments regarding this mandate.
    /// </summary>
    public class GcTokensApi : GcApiBase
    {
        internal GcTokensApi(GcConfiguration config) : base(config, "tokens") { }

        /// <summary>
        /// Use this call to tokenize payment details. 
        /// Note that only basic input validation is performed as no actual transaction is processed.
        /// We does not check the validity of the payment details with any of its acquirers or third party payment processors.
        /// If you want to only tokenize payment details that have been successfully processed it is advised to create tokens using the
        /// tokenize action on successful payments.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__tokens_post </returns>
        public GcCreateTokenResponse CreateToken(TokenBody body)
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
        /// Use GET on a specific token to retrieve all the tokenized data for that ID.
        /// You can use some of this data towards the consumer to let them choose which stored data to re-use.
        /// You can also use data like the expiry date to check if you need to ask for updated data from your consumer. 
        /// We will never return full card details.
        /// The request does not have any additional input parameters. 
        /// </summary>
        /// <param name="tokenId">the token ID</param>
        /// <returns>Please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__tokens__tokenId__get </returns>
        public GcRetrieveTokenResponse RetrieveToken(string tokenId)
        {
            if (string.IsNullOrEmpty(tokenId))
            {
                throw new ArgumentNullException(nameof(tokenId));
            }
            var req = new GcRequest(Config, Method.GET, BuildApiPath("{0}", tokenId));
            return Execute(req);
        }

        /// <summary>
        /// Use PUT on a specific token to update the tokenized data. 
        /// Any data that is supplied will overwrite any of the existing data in the token.
        /// As the card number is used as a key this can't be updated. 
        /// Instead of updating you should add a new token with the new card number. 
        /// The same holds true of the payment product; this can not be updated.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="body"></param>
        /// <returns>Please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__tokens__tokenId__put </returns>
        public GcUpdateTokenResponse UpdateToken(string tokenId, TokenBody body)
        {
            if (string.IsNullOrEmpty(tokenId))
            {
                throw new ArgumentNullException(nameof(tokenId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }
            var req = new GcRequest(Config, Method.PUT, BuildApiPath("{0}", tokenId));
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// Use DELETE on a specific token to remove or invalidate it. 
        /// You will not be able to undo this deleting and will not be able to use the token in the future. 
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="mandateCancelDate"></param>
        /// <returns>Please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__tokens__tokenId__delete </returns>
        public GcDeleteTokenResponse DeleteToken(string tokenId, string mandateCancelDate = null)
        {
            if (string.IsNullOrEmpty(tokenId))
            {
                throw new ArgumentNullException(nameof(tokenId));
            }
            var url = string.IsNullOrEmpty(mandateCancelDate)
                ? BuildApiPath("{0}", tokenId)
                : BuildApiPath("{0}?=mandateCancelDate={1}", tokenId, mandateCancelDate);
            var req = new GcRequest(Config, Method.DELETE, url);
            return Execute(req);
        }
    }
}