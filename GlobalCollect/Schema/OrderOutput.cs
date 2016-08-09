using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderOutput
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this transaction
        /// </summary>
        [JsonProperty("references")]
        public PaymentReferences References { get; set; }
    }
}