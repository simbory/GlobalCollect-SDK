using System;

namespace GlobalCollect
{
    /// <summary>
    /// the Global Collect API interface
    /// </summary>
    public static class GcClient
    {
        /// <summary>
        /// the API request and response log writer
        /// </summary>
        public static Action<string, object> LogWriter { get; set; }

        /// <summary>
        /// HostedCheckouts API: https://developer.globalcollect.com/documentation/api/server/#hostedcheckouts
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC HostedCheckouts API instance</returns>
        public static GcHostedCheckoutsApi HostedCheckouts(GcConfiguration config)
        {
            return new GcHostedCheckoutsApi(config);
        }

        /// <summary>
        /// HostedCheckouts API: https://developer.globalcollect.com/documentation/api/server/#hostedcheckouts
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC HostedCheckouts API instance</returns>
        public static GcHostedCheckoutsApi HostedCheckouts(string merchantID)
        {
            return new GcHostedCheckoutsApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// Services API: https://developer.globalcollect.com/documentation/api/server/#services
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Services API instance</returns>
        public static GcServicesApi Services(GcConfiguration config)
        {
            return new GcServicesApi(config);
        }

        /// <summary>
        /// Services API: https://developer.globalcollect.com/documentation/api/server/#services
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Services API instance</returns>
        public static GcServicesApi Services(string merchantID)
        {
            return new GcServicesApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// Payments API: https://developer.globalcollect.com/documentation/api/server/#payments
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Payments API instance</returns>
        public static GcPaymentApi Payments(GcConfiguration config)
        {
            return new GcPaymentApi(config);
        }

        /// <summary>
        /// Payments API: https://developer.globalcollect.com/documentation/api/server/#payments
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Payments API instance</returns>
        public static GcPaymentApi Payments(string merchantID)
        {
            return new GcPaymentApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// Refunds API: https://developer.globalcollect.com/documentation/api/server/#refunds
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Refunds API instance</returns>
        public static GcRefundsApi Refunds(GcConfiguration config)
        {
            return new GcRefundsApi(config);
        }

        /// <summary>
        /// Refunds API: https://developer.globalcollect.com/documentation/api/server/#refunds
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Refunds API instance</returns>
        public static GcRefundsApi Refunds(string merchantID)
        {
            return new GcRefundsApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// Tokens API: https://developer.globalcollect.com/documentation/api/server/#tokens
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcTokensApi Tokens(GcConfiguration config)
        {
            return new GcTokensApi(config);
        }

        /// <summary>
        /// Tokens API: https://developer.globalcollect.com/documentation/api/server/#tokens
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcTokensApi Tokens(string merchantID)
        {
            return new GcTokensApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// RiskAssessments API: https://developer.globalcollect.com/documentation/api/server/#riskassessments
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcRiskAssessmentsApi RiskAssessments(GcConfiguration config)
        {
            return new GcRiskAssessmentsApi(config);
        }

        /// <summary>
        /// RiskAssessments API: https://developer.globalcollect.com/documentation/api/server/#riskassessments
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcRiskAssessmentsApi RiskAssessments(string merchantID)
        {
            return new GcRiskAssessmentsApi(new GcConfiguration(merchantID));
        }

        /// <summary>
        /// Sessions API: https://developer.globalcollect.com/documentation/api/server/#sessions
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Sesstions API instance</returns>
        public static GcSesstionsApi Sesstions(GcConfiguration config)
        {
            return new GcSesstionsApi(config);
        }

        /// <summary>
        /// Sessions API: https://developer.globalcollect.com/documentation/api/server/#sessions
        /// </summary>
        /// <param name="merchantID">GC merchant ID</param>
        /// <returns>GC Sesstions API instance</returns>
        public static GcSesstionsApi Sesstions(string merchantID)
        {
            return new GcSesstionsApi(new GcConfiguration(merchantID));
        }
    }
}