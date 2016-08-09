using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CancelPaymentCardPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Result of the authorization reversal request Possible values are: 00 - Successful reversal 0, 8 or 11 - Reversal request submitted 5 or 55 - Reversal request declined or referred empty or 98 - The provider did not provide a response
        /// </summary>
        [JsonProperty("voidResponseId")]
        public string VoidResponseId { get; set; }
    }
}