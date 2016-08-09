using System;
using GlobalCollect.GcResponses;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace GlobalCollect
{
    /// <summary>
    /// Under services you find several calls that can be used to support your payment flow:
    ///    Test your connection to us
    ///    Convert an amount from one currency to another
    ///    Convert between different bank account notations
    ///    Retrieve the card type and country where the card was issued based on the IIN of the card
    /// </summary>
    public class GcServicesApi : GcApiBase
    {
        internal GcServicesApi(GcConfiguration config) : base(config, "services") { }

        /// <summary>
        /// You can use this call to verify your connection to our platform. If you receive an OK result you know that your
        /// connection with GlobalCollect is working correctly, your authentication credentials are correct and your account
        /// is setup correctly at GlobalCollect. The request does not have any additional input parameters.
        /// </summary>
        /// <returns>please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__services_testconnection_get</returns>
        public GcResponse TestConnection()
        {
            var req = new GcRequest(Config, Method.GET, BuildApiPath("testconnection"));
            return Execute(req);
        }

        /// <summary>
        /// This call lets you verify if GlobalCollect can process a card from a certain Issuer (by looking up the first 6 digits)
        /// and what the best card type would be, based on your configuration. Some cards are dual branded can could be processed
        /// as either a local card (with a local brand) or an international card (with a international brand). In case you are not
        /// setup to process these local cards, this API call will not return that card type in its response.
        /// </summary>
        /// <param name="bin">
        /// The first digits of the credit card number from left to right with a minimum of 6 digits, or the full credit card
        /// number Required
        /// </param>
        /// <returns>please visit https://developer.globalcollect.com/documentation/api/server/#__merchantId__services_getIINdetails_post</returns>
        public GcResponse RetrieveIINDetails(string bin)
        {
            var req = new GcRequest(Config, Method.POST, BuildApiPath("getIINdetails"));
            req.AddBody(new {bin});
            return Execute(req);
        }

        /// <summary>
        /// This API call can be used to convert bank account details between Basic Bank Account Number (BBAN) and International Bank
        /// Account Number (IBAN). This can be helpful if you still have data sources that have or provide you with BBAN data, but
        /// you need IBAN data to process transactions.
        /// </summary>
        /// <returns></returns>
        public GcResponse ConvertBankAccount(object body)
        {
            if (body == null)
            {
                throw new ArgumentNullException("body");
            }
            var req = new GcRequest(Config, Method.POST, BuildApiPath("convert/bankaccount"));
            req.AddBody(body);
            return Execute(req);
        }

        /// <summary>
        /// Using the convert amount API you can ask Globalcollect to convert an amount from one currency into another currency.
        /// GlobalCollect will use the rate set configured for your account to perform the conversion.
        /// </summary>
        /// <param name="source">Three-letter ISO currency code representing the source currency Required</param>
        /// <param name="target">Amount to be converted in cents and always having 2 decimals Required</param>
        /// <param name="amount">Three-letter ISO currency code representing the target currency Required</param>
        /// <returns>please refer https://developer.globalcollect.com/documentation/api/server/#__merchantId__services_convert_amount_get</returns>
        public ulong ConvertAmount(string source, string target, ulong amount)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException("source");
            }
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException(target);
            }
            if (amount <= 0)
            {
                throw new ArgumentException("invalid amount value");
            }
            var req = new GcRequest(Config, Method.GET, BuildApiPath("convert/amount"));
            req.AddQueryString("source", source);
            req.AddQueryString("target", target);
            req.AddQueryString("amount", amount.ToString());
            var res = Execute(req);
            var json = JObject.Parse(res.Content);
            var cents = ulong.Parse(json["convertedAmount"].ToString());
            return cents;
        }
    }
}