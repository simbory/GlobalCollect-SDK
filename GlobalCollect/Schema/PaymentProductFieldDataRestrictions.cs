using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductFieldDataRestrictions
    {
        /// <summary>
        /// true - Indicates that this field is required false - Indicates that this field is optional
        /// </summary>
        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Object containing the details of the validations on the field
        /// </summary>
        [JsonProperty("validators")]
        public PaymentProductFieldValidators Validators { get; set; }
    }
}