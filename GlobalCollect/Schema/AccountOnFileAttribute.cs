using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AccountOnFileAttribute
    {
        /// <summary>
        /// Name of the key or field
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The reason why the status is MUST_WRITE. Currently only "IN_THE_PAST" is possible as value (for expiry date), but this can be extended with new values in the future.
        /// </summary>
        [JsonProperty("mustWriteReason")]
        public string MustWriteReason { get; set; }

        /// <summary>
        /// Possible values: READ_ONLY - attribute cannot be updated and should be presented in that way to the user CAN_WRITE - attribute can be updated and should be presented as an editable field, for example an expiration date that will expire very soon MUST_WRITE - attribute should be updated and must be presented as an editable field, for example an expiration date that has already expired Any updated values that are entered for CAN_WRITE or MUST_WRITE will be used to update the values stored in the token.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Value of the key or field
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}