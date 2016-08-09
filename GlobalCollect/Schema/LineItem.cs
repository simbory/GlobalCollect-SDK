using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class LineItem
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes Note: make sure you submit the amount and currency code for each line item
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the line items of the invoice or shopping cart
        /// </summary>
        [JsonProperty("invoiceData")]
        public LineItemInvoiceData InvoiceData { get; set; }

        /// <summary>
        /// Object containing additional information that when supplied can have a beneficial effect on the discountrates
        /// </summary>
        [JsonProperty("level3InterchangeInformation")]
        public LineItemLevel3InterchangeInformation Level3InterchangeInformation { get; set; }
    }
}