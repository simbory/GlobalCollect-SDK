using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductFieldValidators
    {
        /// <summary>
        /// Indicates that the content should be validated against the rules for an email address
        /// </summary>
        [JsonProperty("emailAddress")]
        public EmptyValidator EmailAddress { get; set; }

        /// <summary>
        /// Indicates that the content should be validated against the rules for an expiration date (it should be in the future)
        /// </summary>
        [JsonProperty("expirationDate")]
        public EmptyValidator ExpirationDate { get; set; }

        /// <summary>
        /// Indicates that content should be one of the, in this object, listed items
        /// </summary>
        [JsonProperty("fixedList")]
        public FixedListValidator FixedList { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated against length criteria defined in this object
        /// </summary>
        [JsonProperty("length")]
        public LengthValidator Length { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated using a LUHN check
        /// </summary>
        [JsonProperty("luhn")]
        public EmptyValidator Luhn { get; set; }

        /// <summary>
        /// Indicates that the content needs to be validated against a, in this object, defined range
        /// </summary>
        [JsonProperty("range")]
        public RangeValidator Range { get; set; }

        /// <summary>
        /// A string representing the regular expression to check
        /// </summary>
        [JsonProperty("regularExpression")]
        public RegularExpressionValidator RegularExpression { get; set; }
    }
}