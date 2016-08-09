using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentProduct816SpecificInput
    {
        /// <summary>
        /// Object contain the bank account details of the consumer Required
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }
    }
}