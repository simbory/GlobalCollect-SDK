using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductFieldFormElement
    {
        /// <summary>
        /// Type of form element to be used. The following types can be returned: text - A normal text input field list - A list of values that the consumer needs to choose from is detailed in the valueMapping array currency - Currency fields should be split into two fields, with the second one being specifically for the cents
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// An array of values and displayNames that should be used to populate the list object in the GUI
        /// </summary>
        [JsonProperty("valueMapping")]
        public ValueMappingElement[] ValueMapping { get; set; }
    }
}