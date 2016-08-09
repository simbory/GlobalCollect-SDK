using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Order
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        [JsonProperty("additionalInput")]
        public AdditionalOrderInput AdditionalInput { get; set; }

        /// <summary>
        /// Object containing amount and ISO currency code attributes Required
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object containing the details of the consumer 
        /// Please note that this object is required, except when a token has been included in the request that includes at least the countryCode in the billingAddress.
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// Shopping cart data
        /// </summary>
        [JsonProperty("items")]
        public LineItem[] Items { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this transaction
        /// </summary>
        [JsonProperty("references")]
        public OrderReferences References { get; set; }
    }
}