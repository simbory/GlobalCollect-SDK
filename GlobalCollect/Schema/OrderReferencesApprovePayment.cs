using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderReferencesApprovePayment
    {
        /// <summary>
        /// Your (unique) reference for the transaction that you can use to reconcile our report files
        /// </summary>
        [JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }
    }
}