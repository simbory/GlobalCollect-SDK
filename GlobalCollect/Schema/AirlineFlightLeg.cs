using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AirlineFlightLeg
    {
        /// <summary>
        /// Reservation Booking Designator Required
        /// </summary>
        [JsonProperty("airlineClass")]
        public string AirlineClass { get; set; }

        /// <summary>
        /// Arrival airport/city code Required
        /// </summary>
        [JsonProperty("arrivalAirport")]
        public string ArrivalAirport { get; set; }

        /// <summary>
        /// IATA carrier code Required
        /// </summary>
        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Date of the leg Format: YYYYMMDD Required
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// The departure time in the local time at the departure airport Format: HH:MM Required for PayPal
        /// </summary>
        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Fare of this leg
        /// </summary>
        [JsonProperty("fare")]
        public string Fare { get; set; }

        /// <summary>
        /// Fare Basis/Ticket Designator
        /// </summary>
        [JsonProperty("fareBasis")]
        public string FareBasis { get; set; }

        /// <summary>
        /// The flight number assigned by the airline carrier with no leading spaces Required for PayPal
        /// </summary>
        [JsonProperty("flightNumber")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Sequence number of the flight leg Required
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// Origin airport/city code Required
        /// </summary>
        [JsonProperty("originAirport")]
        public string OriginAirport { get; set; }

        /// <summary>
        /// Possible values are: permitted = Stopover permitted non-permitted = Stopover not permitted Note: This field is required by PayPal when Airline data is submitted.
        /// </summary>
        [JsonProperty("stopoverCode")]
        public string StopoverCode { get; set; }
    }
}