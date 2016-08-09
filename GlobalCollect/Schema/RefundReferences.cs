using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundReferences
    {
        /// <summary>
        /// Your unique reference of the transaction that is also returned in our report files. This is almost always used for your reconciliation of our report files.
        /// </summary>
        [JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }
    }
}