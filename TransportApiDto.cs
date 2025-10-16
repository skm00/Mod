using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section carries the information about the main transport and some directly associated parameters applicable for \"Air\", \"Sea\", \"Rail\" shipments.
    /// </summary>
    [Description("This section carries the information about the main transport and some directly associated parameters applicable for \"Air\", \"Sea\", \"Rail\" shipments.")]
    public class TransportApiDto
    {
        /// <summary>
        /// Identification of the Bill of Lading issued by DSV to the customer
        /// </summary>
        [Description("Identification of the Bill of Lading issued by DSV to the customer")]
        public string? HouseBillNumber { get; set; }

        /// <summary>
        /// Identification of the Bill of Lading issued by the carrier to DSV
        /// </summary>
        [Description("Identification of the Bill of Lading issued by the carrier to DSV")]
        public string? MasterBillNumber { get; set; }

        /// <summary>
        /// Air Waybill Number used by the underlying express carrier
        /// </summary>
        [Description("Air Waybill Number used by the underlying express carrier")]
        public string? Awb { get; set; }

        /// <summary>
        /// Name of the first departure port/airport
        /// </summary>
        [Description("Name of the first departure port/airport")]
        public string? OriginName { get; set; }

        /// <summary>
        /// UN location code of the first departure port/airport
        /// </summary>
        [Description("UN location code of the first departure port/airport")]
        public string? OriginCode { get; set; }

        /// <summary>
        /// Name of the last arrival port/airport
        /// </summary>
        [Description("Name of the last arrival port/airport")]
        public string? DestinationName { get; set; }

        /// <summary>
        /// UN location code of the last arrival port/airport
        /// </summary>
        [Description("UN location code of the last arrival port/airport")]
        public string? DestinationCode { get; set; }

        /// <summary>
        /// The Standard Carrier Alpha Code, or SCAC Code, is a two to four-letter code used to identify vessel operating common carriers (VOCC)
        /// </summary>
        [Description("The Standard Carrier Alpha Code, or SCAC Code, is a two to four-letter code used to identify vessel operating common carriers (VOCC)")]
        public string? Scac { get; set; }

        /// <summary>
        /// Booking references from the carrier
        /// </summary>
        [Description("Booking references from the carrier")]
        public string? CarrierBookingRef { get; set; }
    }
}
