using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderInvoiceData
    {
        /// <summary>
        /// Additional data for printed invoices
        /// </summary>
        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }

        /// <summary>
        /// Date and time on invoice Format: YYYYMMDDHH24MISS
        /// </summary>
        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Your invoice number (on printed invoice) that is also returned in our report files
        /// </summary>
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Array of 3 text qualifiers, each with a max length of 10 characters
        /// </summary>
        [JsonProperty("textQualifiers")]
        public string[] TextQualifiers { get; set; }
    }
}