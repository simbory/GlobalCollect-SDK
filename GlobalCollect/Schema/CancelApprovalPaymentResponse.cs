using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CancelApprovalPaymentResponse
    {
        /// <summary>
        /// Object that holds the payment related fields
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}