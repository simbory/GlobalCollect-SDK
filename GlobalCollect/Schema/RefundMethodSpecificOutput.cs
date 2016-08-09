using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundMethodSpecificOutput
    {
        /// <summary>
        /// Total paid amount (in cents and always with 2 decimals)
        /// </summary>
        [JsonProperty("totalAmountPaid")]
        public int TotalAmountPaid { get; set; }

        /// <summary>
        /// Total refunded amount (in cents and always with 2 decimals)
        /// </summary>
        [JsonProperty("totalAmountRefunded")]
        public int TotalAmountRefunded { get; set; }
    }
}