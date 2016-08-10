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
        /// Global collect Configuration class constructor
        /// </summary>
        /// <param name="merchantID">the merchant ID provided by global collect</param>
        /// <param name="apiKey">the API key</param>
        /// <param name="apiSecret">the API Secret</param>
        /// <param name="baseUri">the base url</param>
        /// <param name="version">the api version</param>
        public GcConfiguration(string merchantID = null, string apiKey = null, string apiSecret = null, string baseUri = null, string version = null)
        {
            ApiKey = string.IsNullOrEmpty(apiKey)
                ? ConfigurationManager.AppSettings["GlobalCollect.ApiKey"]
                : apiKey;
            ApiSecret = string.IsNullOrEmpty(apiSecret)
                ? ConfigurationManager.AppSettings["GlobalCollect.ApiSecret"]
                : apiSecret;
            BaseUrl = new Uri(string.IsNullOrEmpty(baseUri)
                ? ConfigurationManager.AppSettings["GlobalCollect.BaseUrl"]
                : baseUri);
            Version = string.IsNullOrEmpty(version)
                ? ConfigurationManager.AppSettings["GlobalCollect.Version"]
                : version;
            MerchantID = string.IsNullOrEmpty(merchantID)
                ? ConfigurationManager.AppSettings["GlobalCollect.MerchantID"]
                : merchantID;
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

        private static GcConfiguration _defaultConfig;
        /// <summary>
        /// the default configuration
        /// </summary>
        public static GcConfiguration Default => _defaultConfig ?? (_defaultConfig = new GcConfiguration());
    }
}