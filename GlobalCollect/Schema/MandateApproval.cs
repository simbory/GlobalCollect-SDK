using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class MandateApproval
    {
        /// <summary>
        /// The date when the mandate was signed Format: YYYYMMDD
        /// </summary>
        [JsonProperty("mandateSignatureDate")]
        public string MandateSignatureDate { get; set; }

        /// <summary>
        /// The city where the mandate was signed
        /// </summary>
        [JsonProperty("mandateSignaturePlace")]
        public string MandateSignaturePlace { get; set; }

        /// <summary>
        /// true = Mandate is signed false = Mandate is not signed
        /// </summary>
        [JsonProperty("mandateSigned")]
        public bool MandateSigned { get; set; }
    }
}