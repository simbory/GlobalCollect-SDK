using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AirlineData
    {
        /// <summary>
        /// Numeric code identifying the agent
        /// </summary>
        [JsonProperty("agentNumericCode")]
        public string AgentNumericCode { get; set; }

        /// <summary>
        /// Airline numeric code Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Date of the Flight Format: YYYYMMDD
        /// </summary>
        [JsonProperty("flightDate")]
        public string FlightDate { get; set; }

        /// <summary>
        /// Object that holds the data on the individual legs of the ticket
        /// </summary>
        [JsonProperty("flightLegs")]
        public AirlineFlightLeg[] FlightLegs { get; set; }

        /// <summary>
        /// Airline tracing number
        /// </summary>
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// true = The ticket is an E-Ticket false = the ticket is not an E-Ticket
        /// </summary>
        [JsonProperty("isETicket")]
        public bool IsETicket { get; set; }

        /// <summary>
        /// true = a registered known consumer false = unknown consumer
        /// </summary>
        [JsonProperty("isRegisteredCustomer")]
        public bool IsRegisteredCustomer { get; set; }

        /// <summary>
        /// true - Restricted, the ticket is non-refundable false - No restrictions, the ticket is (partially) refundable
        /// </summary>
        [JsonProperty("isRestrictedTicket")]
        public bool IsRestrictedTicket { get; set; }

        /// <summary>
        /// true - The payer is the ticket holder false - The payer is not the ticket holder
        /// </summary>
        [JsonProperty("isThirdParty")]
        public bool IsThirdParty { get; set; }

        /// <summary>
        /// This is the date of issue recorded in the airline system In a case of multiple issuances of the same ticket to a cardholder, you should use the last ticket date Format: YYYYMMDD
        /// </summary>
        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        /// <summary>
        /// Your ID of the consumer in the context of the airline data
        /// </summary>
        [JsonProperty("merchantCustomerId")]
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// Name of the airline Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of passenger
        /// </summary>
        [JsonProperty("passengerName")]
        public string PassengerName { get; set; }

        /// <summary>
        /// Place of issue For sales in the US the last two characters (pos 14-15) must be the US state code.
        /// </summary>
        [JsonProperty("placeOfIssue")]
        public string PlaceOfIssue { get; set; }

        /// <summary>
        /// Passenger name record
        /// </summary>
        [JsonProperty("pnr")]
        public string Pnr { get; set; }

        /// <summary>
        /// IATA point of sale name
        /// </summary>
        [JsonProperty("pointOfSale")]
        public string PointOfSale { get; set; }

        /// <summary>
        /// city code of the point of sale
        /// </summary>
        [JsonProperty("posCityCode")]
        public string PosCityCode { get; set; }

        /// <summary>
        /// Possible values: e-ticket city-ticket-office airport-ticket-office ticket-by-mail ticket-on-departure
        /// </summary>
        [JsonProperty("ticketDeliveryMethod")]
        public string TicketDeliveryMethod { get; set; }

        /// <summary>
        /// The ticket or document number contains: Airline code: 3-digit airline code number Form code: A maximum of 3 digits indicating the type of document, the source of issue and the number of coupons it contains Serial number: A maximum of 8 digits allocated on a sequential basis, provided that the total number of digits allocated to the form code and serial number shall not exceed ten TICKETNUMBER can be replaced with PNR if the ticket number is unavailable
        /// </summary>
        [JsonProperty("ticketNumber")]
        public string TicketNumber { get; set; }
    }
}