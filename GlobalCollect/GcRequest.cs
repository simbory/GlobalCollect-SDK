using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// GC API Request
    /// </summary>
    public class GcRequest
    {
        /// <summary>
        /// http method
        /// </summary>
        public Method HttpMethod {get;private set; }

        /// <summary>
        /// the absolute path of the API
        /// </summary>
        public string AbsolutePath { get; private set; }

        /// <summary>
        /// the API request headers
        /// </summary>
        public List<GcRequestHeader> Headers { get; private set; }

        /// <summary>
        /// the API request query parameters
        /// </summary>
        public List<GcRequestParam> QueryParams { get; private set; }

        /// <summary>
        /// the API requestbody
        /// </summary>
        public object Body { get; private set; }

        /// <summary>
        /// the API content type
        /// </summary>
        public string ContentType
        {
            get { return Headers.First(x => x.Name == "Content-Type").Value; }
        }

        /// <summary>
        /// the constuctor
        /// </summary>
        /// <param name="config">GC config setting</param>
        /// <param name="httpMethod">the request http method</param>
        /// <param name="apiPath">the request path</param>
        public GcRequest(GcConfiguration config, Method httpMethod, string apiPath)
        {
            HttpMethod = httpMethod;
            if (string.IsNullOrEmpty(apiPath))
            {
                throw new ArgumentNullException("apiPath");
            }
            if (apiPath.StartsWith("/"))
            {
                apiPath = apiPath.TrimStart('/');
            }
            AbsolutePath = string.Format("/{0}/{1}/{2}", config.Version, config.MerchantID, apiPath);
            Headers = new List<GcRequestHeader>
            {
                new GcRequestHeader("Content-Type", "application/json")
            };
            QueryParams = new List<GcRequestParam>();
        }

        /// <summary>
        /// add a header to the request
        /// </summary>
        /// <param name="name">the header name</param>
        /// <param name="value">the header value</param>
        public void AddHeader(string name, string value)
        {
            Headers.Add(new GcRequestHeader(name, value));
        }

        /// <summary>
        /// add a header to the request
        /// </summary>
        /// <param name="header">the request header setting</param>
        public void AddHeader(GcRequestHeader header)
        {
            Headers.Add(header);
        }

        /// <summary>
        /// add a query parameter to the request
        /// </summary>
        /// <param name="name">the query name</param>
        /// <param name="value">the query value</param>
        public void AddQueryString(string name, string value)
        {
            QueryParams.Add(new GcRequestParam(name, value));
        }

        /// <summary>
        /// add a body object to the request
        /// </summary>
        /// <param name="body">the request body</param>
        public void AddBody(object body)
        {
            Body = body;
        }

        /// <summary>
        /// build the request url
        /// </summary>
        /// <param name="baseUri">the base url of the request</param>
        /// <returns></returns>
        internal Uri BuildRequestUri(Uri baseUri)
        {
            var queryString = QueryParams.Aggregate("", (current, queryParam) => current + "&" + queryParam);
            queryString = queryString.TrimStart('&');
            var path = string.IsNullOrEmpty(queryString) ? AbsolutePath : AbsolutePath + "?" + queryString;
            return new Uri(baseUri, path);
        }
    }
}
