using System;
using System.Configuration;
using System.Net;

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
        public GcConfiguration(string merchantID, string apiKey, string apiSecret, string baseUri, string version)
        {
            if (string.IsNullOrEmpty(merchantID))
            {
                throw new ArgumentNullException(nameof(merchantID));
            }
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(nameof(apiKey));
            }
            if (string.IsNullOrEmpty(apiSecret))
            {
                throw new ArgumentNullException(nameof(apiSecret));
            }
            if (string.IsNullOrEmpty(baseUri))
            {
                throw new ArgumentNullException(nameof(baseUri));
            }
            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentNullException(nameof(version));
            }
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            BaseUrl = new Uri(baseUri);
            Version = version;
            MerchantID = merchantID;
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

        /// <summary>
        /// The global collect api proxy setting
        /// </summary>
        public IWebProxy Proxy { get; set; }

        /// <summary>
        /// Timeout in milliseconds to use for requests made by this api call
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// The number of milliseconds before the writing or reading times out.
        /// </summary>
        public int ReadWriteTimeout { get; set; }
    }
}