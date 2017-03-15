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
        public static GcHostedCheckoutsApi HostedCheckouts(GcConfiguration config = null)
        {
            return new GcHostedCheckoutsApi(config);
        }

        /// <summary>
        /// Services API: https://developer.globalcollect.com/documentation/api/server/#services
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Services API instance</returns>
        public static GcServicesApi Services(GcConfiguration config = null)
        {
            return new GcServicesApi(config);
        }

        /// <summary>
        /// Payments API: https://developer.globalcollect.com/documentation/api/server/#payments
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Payments API instance</returns>
        public static GcPaymentApi Payments(GcConfiguration config = null)
        {
            return new GcPaymentApi(config);
        }

        /// <summary>
        /// Refunds API: https://developer.globalcollect.com/documentation/api/server/#refunds
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Refunds API instance</returns>
        public static GcRefundsApi Refunds(GcConfiguration config = null)
        {
            return new GcRefundsApi(config);
        }

        /// <summary>
        /// Tokens API: https://developer.globalcollect.com/documentation/api/server/#tokens
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcTokensApi Tokens(GcConfiguration config = null)
        {
            return new GcTokensApi(config);
        }

        /// <summary>
        /// RiskAssessments API: https://developer.globalcollect.com/documentation/api/server/#riskassessments
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Tokens API instance</returns>
        public static GcRiskAssessmentsApi RiskAssessments(GcConfiguration config = null)
        {
            return new GcRiskAssessmentsApi(config);
        }

        /// <summary>
        /// Sessions API: https://developer.globalcollect.com/documentation/api/server/#sessions
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <returns>GC Sesstions API instance</returns>
        public static GcSesstionsApi Sesstions(GcConfiguration config = null)
        {
            return new GcSesstionsApi(config);
        }
    }
}