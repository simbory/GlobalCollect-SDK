using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class LineItemLevel3InterchangeInformation
    {
        /// <summary>
        /// Discount on the line item, with the last two digits are implied decimal places
        /// </summary>
        [JsonProperty("discountAmount")]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// Total amount for the line item
        /// </summary>
        [JsonProperty("lineAmountTotal")]
        public int LineAmountTotal { get; set; }

        /// <summary>
        /// Product or UPC Code, left justified Note: Must not be all spaces or all zeros
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// The price of one unit of the product, the value should be zero or greater
        /// </summary>
        [JsonProperty("productPrice")]
        public int ProductPrice { get; set; }

        /// <summary>
        /// Code used to classify items that are purchased Note: Must not be all spaces or all zeros
        /// </summary>
        [JsonProperty("productType")]
        public string ProductType { get; set; }

        /// <summary>
        /// Quantity of the units being purchased, should be greater than zero Note: Must not be all spaces or all zeros
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Tax on the line item, with the last two digits are implied decimal places
        /// </summary>
        [JsonProperty("taxAmount")]
        public int TaxAmount { get; set; }

        /// <summary>
        /// Indicates the line item unit of measure; for example: each, kit, pair, gallon, month, etc.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}