using System;
using GlobalCollect.GcResponses;
using GlobalCollect.Schema;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// Through this API you can have our fraud prevention systems assess the risk for potential fraud based using the details you provide.
    /// You can either have us assess this risk when you submit the transaction for processing or you can do this separately from the 
    /// payment process, using the risk assessment calls.
    /// We offers two groups of checks:
    /// Centred around card data
    /// Centred around bank account data
    /// Both groups perform multiple check within one call depending on configuration.
    /// </summary>
    public class GcRiskAssessmentsApi : GcApiBase
    {
        internal GcRiskAssessmentsApi(GcConfiguration config) : base(config, "riskassessments") { }

        /// <summary>
        /// When evaluating the risk of fraud on card transactions a generic rule of thumb is: more relevant data = more relevant results.
        /// This is especially true of the checks performed at Retail Decisions as their solutions allow you to take much more data points 
        /// into account for the evaluation of the risk. Any relevant additional data can be used to build rulesets on or is potential 
        /// differentiating data for the neural score.
        /// The other checks only focus on the card data itself and no additional data is taken into consideration.
        /// </summary>
        /// <param name="body">the request body</param>
        /// <returns>Please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__riskassessments_cards_post </returns>
        public GcRiskAssessCardResponse RiskAssessCard(RiskAssessCardRequest body)
        {
            if (body == null)
            {
                throw new ArgumentNullException("body");
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("cards"));
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// The evaluation of the risk on bank account data is less concerned with additional data, but focusses primarily just on the bank account data. 
        /// As an online authorization is not possible against a bank account most checks focus on the, fairly static, checks whether the bank account
        /// data is wellformed, i.e. algorithms checks, correct length and syntax. Some are however based on more or less static blacklists that do try
        /// to take past transaction results into consideration.
        /// </summary>
        /// <param name="body">the request body</param>
        /// <returns>please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__riskassessments_bankaccounts_post </returns>
        public GcRiskAccessBackAccountResponse RiskAssessBankAccount(RiskAssessmentBankAccount body)
        {
            if (body == null)
            {
                throw new ArgumentNullException("body");
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("bankaccounts"));
            req.AddBody(body);
            return Execute(req);
        }
    }
}