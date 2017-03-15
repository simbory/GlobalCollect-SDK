using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GlobalCollect
{
    internal class GcAuthenticator
    {
        public Encoding Charset { get; private set; }

        public string ApiKeyId { get; private set; }

        public string ApiSecret { get; private set; }

        public GcAuthenticator(string apiKey, string apiSecret, Encoding charset = null)
        {
            if (charset == null)
            {
                charset = Encoding.UTF8;
            }
            Charset = charset;
            ApiKeyId = apiKey;
            ApiSecret = apiSecret;
        }

        public GcAuthenticator(GcConfiguration config) : this(config.ApiKey, config.ApiSecret)
        {
        }

        private string CreateAuthenticationSignature(string dataToSign)
        {
            var sha256Data = Charset.GetBytes(dataToSign);
            var key = Charset.GetBytes(ApiSecret);
            var sha256 = new HMACSHA256(key);
            sha256.Initialize();
            var result = sha256.ComputeHash(sha256Data);
            return Convert.ToBase64String(result);
        }

        private string ToCanonicalizedResource(Uri resourceUri)
        {
            return resourceUri.PathAndQuery;
        }

        private string ToCanonicalizeHeaderValue(string originalValue)
        {
            if (originalValue == null)
            {
                return "";
            }

            var parts = originalValue.Split('\n');

            var sb = new StringBuilder();
            for (var i = 0; i < parts.Length; i++)
            {
                var part = parts[i];
                sb.Append(part.Trim());
                if (i < parts.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }

        private string ToDataSign(string httpMethod, Uri resourceUri, List<GcRequestHeader> httpHeaders)
        {
            var contentType = "";
            var date = "";
            var canonicalizedHeaders = new StringBuilder();
            var canonicalizedResource = ToCanonicalizedResource(resourceUri);
            var xgcsHttpHeaders = new List<GcRequestHeader>();
            if (httpHeaders != null && httpHeaders.Count > 0)
            {
                foreach (var header in httpHeaders)
                {
                    if ("Content-Type".Equals(header.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        contentType = header.Value;
                    }
                    else if ("Date".Equals(header.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        date = header.Value;
                    }
                    else if (header.Name.StartsWith("X-GCS"))
                    {
                        xgcsHttpHeaders.Add(new GcRequestHeader(header.Name.ToLower(), ToCanonicalizeHeaderValue(header.Value)));
                    }
                }
            }
            foreach (var key in xgcsHttpHeaders.OrderBy(x=>x.Name))
            {
                canonicalizedHeaders.Append(key.Name).Append(":").Append(key.Value).Append("\n");
            }
            var sb = new StringBuilder();
            sb.Append(httpMethod.ToUpper()).Append("\n");
            if (!string.IsNullOrEmpty(contentType))
            {
                sb.Append(contentType).Append("\n");
            }
            if (!string.IsNullOrEmpty(date))
            {
                sb.Append(date).Append("\n");
            }
            sb.Append(canonicalizedHeaders);
            sb.Append(canonicalizedResource).Append("\n");
            return sb.ToString();
        }

        public string CreateSimpleAuthenticationSignature(string httpMethod, Uri resourceUri, List<GcRequestHeader> requestHeaders)
        {
            if (string.IsNullOrEmpty(httpMethod) || string.IsNullOrEmpty(httpMethod.Trim()))
            {
                throw new ArgumentNullException(nameof(httpMethod));
            }
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }
            var dataToSign = ToDataSign(httpMethod, resourceUri, requestHeaders);
            return "GCS v1HMAC:" + ApiKeyId + ":" + CreateAuthenticationSignature(dataToSign);
        }
    }
}