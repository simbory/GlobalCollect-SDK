using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class LineItemInvoiceData
    {
        /// <summary>
        /// Shopping cart item description When you want your shopping cart to be displayed on our hostedCheckout pages this field is required for the cart to display correctly.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Line number for printed invoice or order of items in the cart
        /// </summary>
        [JsonProperty("merchantLinenumber")]
        public string MerchantLinenumber { get; set; }

        /// <summary>
        /// Page number for printed invoice
        /// </summary>
        [JsonProperty("merchantPagenumber")]
        public string MerchantPagenumber { get; set; }

        /// <summary>
        /// Quantity of the item When you want your shopping cart to be displayed on our hostedCheckout pages this field is required for the cart to display correctly.
        /// </summary>
        [JsonProperty("nrOfItems")]
        public string NrOfItems { get; set; }

        /// <summary>
        /// Price per item When you want your shopping cart to be displayed on our hostedCheckout pages this field is required for the cart to display correctly.
        /// </summary>
        [JsonProperty("pricePerItem")]
        public int PricePerItem { get; set; }
    }
}