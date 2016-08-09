using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductField
    {
        /// <summary>
        /// Object containing data restrictions that apply to this field, like minimum and/or maximum length
        /// </summary>
        [JsonProperty("dataRestrictions")]
        public PaymentProductFieldDataRestrictions DataRestrictions { get; set; }

        /// <summary>
        /// Object containing display hints for this field, like the order, mask, preferred keyboard
        /// </summary>
        [JsonProperty("displayHints")]
        public PaymentProductFieldDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// The ID of the field
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of field, possible values are: string - Any UTF-8 chracter numericstring - A string that consisting only of numbers. Note that you should strip out anything that is not a digit, but leading zeros are allowed date - Date in the format DDMMYYYY expirationDate - Expiration date in the format MMYY integer - An integer
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}