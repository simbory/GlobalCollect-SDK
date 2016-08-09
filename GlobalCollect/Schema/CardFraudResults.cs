using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardFraudResults
    {
        /// <summary>
        /// Result of the Address Verification Service checks. Possible values are: A - Address (Street) matches, Zip does not B - Street address match for international transactions—Postal code not verified due to incompatible formats C - Street address and postal code not verified for international transaction due to incompatible formats D - Street address and postal code match for international transaction, cardholder name is incorrect E - AVS error F - Address does match and five digit ZIP code does match (UK only) G - Address information is unavailable; international transaction; non-AVS participant H - Billing address and postal code match, cardholder name is incorrect (Amex) I - Address information not verified for international transaction K - Cardholder name matches (Amex) L - Cardholder name and postal code match (Amex) M - Cardholder name, street address, and postal code match for international transaction N - No Match on Address (Street) or Zip O - Cardholder name and address match (Amex) P - Postal codes match for international transaction—Street address not verified due to incompatible formats Q - Billing address matches, cardholder is incorrect (Amex) R - Retry, System unavailable or Timed out S - Service not supported by issuer U - Address information is unavailable W - 9 digit Zip matches, Address (Street) does not X - Exact AVS Match Y - Address (Street) and 5 digit Zip match Z - 5 digit Zip matches, Address (Street) does not 0 - No service available
        /// </summary>
        [JsonProperty("avsResult")]
        public string AvsResult { get; set; }

        /// <summary>
        /// Result of the Card Verification Value checks. Possible values are: M - CVV check performed and valid value N - CVV checked and no match P - CVV check not performed, not requested S - Cardholder claims no CVV code on card, issuer states CVV-code should be on card U Issuer not certified for CVV2 Y - Server provider did not respond 0 - No service available
        /// </summary>
        [JsonProperty("cvvResult")]
        public string CvvResult { get; set; }

        /// <summary>
        /// Results from the fraud prevention check. Possible values are: accepted - Based on the checks performed the transaction can be accepted challenged - Based on the checks performed the transaction should be manually reviewed denied - Based on the checks performed the transaction should be rejected no-advice - No fraud check was requested/performed error - The fraud check resulted in an error and the fraud check was thus not performed
        /// </summary>
        [JsonProperty("fraudServiceResult")]
        public string FraudServiceResult { get; set; }

        /// <summary>
        /// Additional response data returned by RetailDecisions
        /// </summary>
        [JsonProperty("retailDecisions")]
        public FraudResultsRetailDecisions RetailDecisions { get; set; }
    }
}