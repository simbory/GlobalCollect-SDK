using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenBody
    {
        [JsonProperty("card")]
        public TokenCard Card { get; set; }

        [JsonProperty("eWallet")]
        public TokenEWallet EWallet { get; set; }

        [JsonProperty("nonSepaDirectDebit")]
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; }

        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        [JsonProperty("sepaDirectDebit")]
        public TokenSepaDirectDebit SepaDirectDebit { get; set; }
    }
}