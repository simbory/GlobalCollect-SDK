using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class InvoiceData
    {
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }
        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }
    }
}
