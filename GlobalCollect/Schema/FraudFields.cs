using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class FraudFields
    {
        /// <summary>
        /// The IP Address of the consumer that is making the payment
        /// </summary>
        [JsonProperty("customerIpAddress")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// Degree of default form fill, with the following possible values: automatically - All fields filled automatically automatically-but-modified - All fields filled automatically, but some fields were modified manually manually - All fields were entered manually
        /// </summary>
        [JsonProperty("defaultFormFill")]
        public string DefaultFormFill { get; set; }

        /// <summary>
        /// One of the following gift card types: celebrate-fall - Celebrate Fall grandparents-day - Grandparent's Day independence-day - Independence Day anniversary - Anniversary birthday - Birthday congratulations - Congratulations april-fools-day - April Fool's Day easter - Easter fathers-day - Father's Day graduation - Graduation holiday - Holiday seasons-greetings - Season's Greetings passover - Passover kwanzaa - Kwanzaa halloween - Halloween mothers-day - Mother's Day new-years-day - New Year's Day bosses-day - Bosses' Day st-patricks-day - St. Patrick's Day sweetest-day - Sweetest Day christmas - Christmas baby-shower - Baby Shower thanksgiving - Thanksgiving other - Other valentines-day - Valentine's Day wedding - Wedding secretarys-day - Secretary's Day chinese-new-year - Chinese New Year hanukkah - Hanukkah
        /// </summary>
        [JsonProperty("giftCardType")]
        public string GiftCardType { get; set; }

        /// <summary>
        /// Gift message
        /// </summary>
        [JsonProperty("giftMessage")]
        public string GiftMessage { get; set; }

        /// <summary>
        /// Specifies if the consumer (initially) had forgotten their password true - The consumer has forgotten their password false - The consumer has not forgotten their password
        /// </summary>
        [JsonProperty("hasForgottenPwd")]
        public bool HasForgottenPwd { get; set; }

        /// <summary>
        /// Specifies if the consumer entered a password to gain access to an account registered with the you true - The consumer has used a password to gain access false - The consumer has not used a password to gain access
        /// </summary>
        [JsonProperty("hasPassword")]
        public bool HasPassword { get; set; }

        /// <summary>
        /// Specifies if the consumer has a history of online shopping with the merchant true - The consumer is a known returning consumer false - The consumer is new/unknown consumer
        /// </summary>
        [JsonProperty("isPreviousCustomer")]
        public bool IsPreviousCustomer { get; set; }

        /// <summary>
        /// Timezone in which the order was placed
        /// </summary>
        [JsonProperty("orderTimezone")]
        public string OrderTimezone { get; set; }

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        [JsonProperty("shipComments")]
        public string ShipComments { get; set; }

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        [JsonProperty("shipmentTrackingNumber")]
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Array of up to 16 userData fields, each with a max length of 256 characters, that can be used for fraudscreening
        /// </summary>
        [JsonProperty("userData")]
        public string[] UserData { get; set; }

        /// <summary>
        /// The website from which the purchase was made
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; }
    }
}