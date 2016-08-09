using System;
using System.Configuration;
using System.Linq;
using System.Net;
using GlobalCollect.GcResponses;
using Newtonsoft.Json;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// GC Basic Api class setting
    /// </summary>
    public abstract class GcApiBase
    {
        private readonly RestClient _client;

        /// <summary>
        /// GC Configuration
        /// </summary>
        protected GcConfiguration Config { get; set; }

        /// <summary>
        /// Api group name
        /// </summary>
        protected string ApiGroupKey { get; private set;}

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="config">gc config setting</param>
        /// <param name="groupKey">api group name</param>
        protected GcApiBase(GcConfiguration config, string groupKey)
        {
            ApiGroupKey = groupKey;
            Config = config;
            _client = new RestClient(Config.BaseUrl);
            if (ConfigurationManager.AppSettings["Environment"] == "DEV" && !string.IsNullOrEmpty(ConfigurationManager.AppSettings["Proxy"]))
            {
                _client.Proxy = new WebProxy(new Uri(ConfigurationManager.AppSettings["Proxy"]));
            }
        }

        /// <summary>
        /// build the path of the api based on the api group name
        /// </summary>
        /// <param name="format">format string</param>
        /// <param name="params">format parameters</param>
        /// <returns>the api path</returns>
        protected string BuildApiPath(string format, params object[] @params)
        {
            if (string.IsNullOrEmpty(format))
            {
                return ApiGroupKey;
            }
            if (!format.StartsWith("/"))
            {
                format = "/" + format;
            }
            return ApiGroupKey + string.Format(format, @params);
        }

        /// <summary>
        /// execute the request and get the response
        /// </summary>
        /// <param name="request">the api request info</param>
        /// <returns>the api response info</returns>
        protected GcResponse Execute(GcRequest request)
        {
            var now = DateTime.Now.ToString("R");
            request.AddHeader("Date", now);
            var req = new RestRequest(request.AbsolutePath, request.HttpMethod);
            foreach (var header in request.Headers)
            {
                req.AddHeader(header.Name, header.Value);
            }
            var authenticator = new GcAuthenticator(Config.ApiKey, Config.ApiSecret);
            var uri = request.BuildRequestUri(Config.BaseUrl);
            var auth = authenticator.CreateSimpleAuthenticationSignature(req.Method.ToString(), uri, request.Headers);
            req.AddHeader("Authorization", auth);
            foreach (var queryParam in request.QueryParams)
            {
                req.AddQueryParameter(queryParam.Name, queryParam.Value);
            }
            if (request.Body != null)
            {
                req.JsonSerializer = new GcRequestJsonSerializer();
                req.AddJsonBody(request.Body);
            }
            var res = _client.Execute(req);

            var logObj = new
            {
                request = new
                {
                    url = uri,
                    method = request.HttpMethod,
                    headers = request.Headers.Select(x=>x.Name +":" + x.Value).ToArray(),
                    authorization = auth,
                    query = request.QueryParams
                },
                response = new
                {
                    statusCode = res.StatusCode,
                    content = res.Content
                }
            };
            if (GcClient.LogWriter != null)
            {
                GcClient.LogWriter("global-collect/req", logObj);
            }
            return new GcResponse(res.StatusCode, res.Content);
        }

        /// <summary>
        /// get the server info
        /// </summary>
        /// <returns></returns>
        protected GcRequestHeader GetServerHeader()
        {
            var headerKey = "X-GCS-ServerMetaInfo";
            var os = Environment.OSVersion;
            var frameworkVersion = Environment.Version;
            var json = JsonConvert.SerializeObject(new {platformIdentifier = os + " (.net framework version " + frameworkVersion + ")", sdkIdentifier = "1.0"});
            return new GcRequestHeader(headerKey, json);
        }
    }
}