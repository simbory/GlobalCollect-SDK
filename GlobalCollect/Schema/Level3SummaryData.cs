using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Level3SummaryData
    {
        /// <summary>
        /// Discount on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [JsonProperty("discountAmount")]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// Duty on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [JsonProperty("dutyAmount")]
        public int DutyAmount { get; set; }

        /// <summary>
        /// Shippingcost on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [JsonProperty("shippingAmount")]
        public int ShippingAmount { get; set; }
    }
}