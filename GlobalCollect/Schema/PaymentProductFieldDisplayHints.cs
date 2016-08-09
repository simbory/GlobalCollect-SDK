using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductFieldDisplayHints
    {
        /// <summary>
        /// true - Indicates that this field is advised to be captured to increase the success rates even-though it isn't marked as required. Please note that making the field required could hurt the success rates negatively. This boolean only indicates our advise to always show this field to the consumer. false - Indicates that this field is not to be shown unless it is a required field.
        /// </summary>
        [JsonProperty("alwaysShow")]
        public bool AlwaysShow { get; set; }

        /// <summary>
        /// The order in which the fields should be shown (ascending)
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Object detailing the type of form element that should be used to present the field
        /// </summary>
        [JsonProperty("formElement")]
        public PaymentProductFieldFormElement FormElement { get; set; }

        /// <summary>
        /// Label/Name of the field to used in the user interface
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// A mask that can be used in the input field. You can use it to inject additional characters to provide a better user experience and to restrict the accepted character set (illegal characters to be ignored during typing). * is used for wildcards (and also chars) 9 is used for numbers Everything outside {{ and }} is used as-is.
        /// </summary>
        [JsonProperty("mask")]
        public string Mask { get; set; }

        /// <summary>
        /// true - The data in this field should be obfuscated as it is entered, just like a password field false - The data in this field does not need to be obfuscated
        /// </summary>
        [JsonProperty("obfuscate")]
        public bool Obfuscate { get; set; }

        /// <summary>
        /// A placeholder value for the form element
        /// </summary>
        [JsonProperty("placeholderLabel")]
        public string PlaceholderLabel { get; set; }

        /// <summary>
        /// The type of keyboard that can best be used to fill out the value of this field. Possible values are: PhoneNumberKeyboard - Keyboard that is normally used to enter phone numbers StringKeyboard - Keyboard that is used to enter strings IntegerKeyboard - Keyboard that is used to enter only numerical values EmailAddressKeyboard - Keyboard that allows easier entry of email addresses
        /// </summary>
        [JsonProperty("preferredInputType")]
        public string PreferredInputType { get; set; }

        /// <summary>
        /// Object that contains an optional tooltip to assist the consumer
        /// </summary>
        [JsonProperty("tooltip")]
        public PaymentProductFieldTooltip Tooltip { get; set; }
    }
}