using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AdditionalOrderInput
    {
        /// <summary>
        /// Object that holds airline specific data
        /// </summary>
        [JsonProperty("airlineData")]
        public AirlineData AirlineData { get; set; }

        /// <summary>
        /// Object that holds Level3 summary data
        /// </summary>
        [JsonProperty("level3SummaryData")]
        public Level3SummaryData Level3SummaryData { get; set; }

        /// <summary>
        /// The number of installments
        /// </summary>
        [JsonProperty("numberOfInstallments")]
        public int NumberOfInstallments { get; set; }

        /// <summary>
        /// Date and time of order Format: YYYYMMDDHH24MISS
        /// </summary>
        [JsonProperty("orderDate")]
        public string OrderDate { get; set; }

        /// <summary>
        /// Object that holds the purchase and usage type indicators
        /// </summary>
        [JsonProperty("typeInformation")]
        public OrderTypeInformation TypeInformation { get; set; }
    }
}