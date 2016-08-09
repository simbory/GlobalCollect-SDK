using System;
using System.Configuration;

namespace GlobalCollect
{
    /// <summary>
    /// GC config setting
    /// </summary>
    public class GcConfiguration
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="merchantID"></param>
        public GcConfiguration(string merchantID = null)
        {
            ApiKey = ConfigurationManager.AppSettings["GlobalCollect.ApiKey"];
            ApiSecret = ConfigurationManager.AppSettings["GlobalCollect.ApiSecret"];
            BaseUrl = new Uri(ConfigurationManager.AppSettings["GlobalCollect.BaseUrl"]);
            Version = ConfigurationManager.AppSettings["GlobalCollect.Version"];
            MerchantID = string.IsNullOrEmpty(merchantID) ? ConfigurationManager.AppSettings["GlobalCollect.MerchantID"] : merchantID;
        }

        /// <summary>
        /// the base url of the API
        /// </summary>
        public Uri BaseUrl { get; private set; }

        /// <summary>
        /// the API version
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// the default merchant ID
        /// </summary>
        public string MerchantID { get; private set; }

        /// <summary>
        /// the API key
        /// </summary>
        public string ApiKey { get; private set; }

        /// <summary>
        /// the API secret
        /// </summary>
        public string ApiSecret { get; private set; }
    }
}