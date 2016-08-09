using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AccountOnFile
    {
        /// <summary>
        /// Array containing the details of the stored token
        /// </summary>
        [JsonProperty("attributes")]
        public AccountOnFileAttribute[] Attributes { get; set; }

        /// <summary>
        /// Object containing information for the client on how best to display this field
        /// </summary>
        [JsonProperty("displayHints")]
        public AccountOnFileDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// ID of the account on file record
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}