using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProduct836SpecificOutput
    {
        /// <summary>
        /// Indicates if SofortBank could estabilish if the transaction could successfully be processed. 0 - You should wait for the transaction to be reported as paid before shipping any goods. 1 - You can ship the goods. In case the transaction is not reported as paid you can initiate a claims process with SofortBank.
        /// </summary>
        [JsonProperty("securityIndicator")]
        public string SecurityIndicator { get; set; }
    }
}