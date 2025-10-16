using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Shipment details
    /// </summary>
    [Description("Shipment details")]
    public class ShipmentDetailsAPI
    {
        /// <summary>
        /// DSV Booking id - Identifier of the Booking
        /// </summary>
        [Description("DSV Booking id - Identifier of the Booking")]
        public string? BookingId { get; set; }

        /// <summary>
        /// DSV Shipment id - Identifier of the shipment
        /// </summary>
        [Description("DSV Shipment id - Identifier of the shipment")]
        public string? ShipmentId { get; set; }

        /// <summary>
        /// Identifier of the DSV Shipment master ID
        /// </summary>
        [Description("Identifier of the DSV Shipment master ID")]
        public string? MasterShipmentId { get; set; }

        /// <summary>
        /// Identifier of the DSV Shipment child ID
        /// </summary>
        [Description("Identifier of the DSV Shipment child ID")]
        [Required(AllowEmptyStrings = true)]
        [Example(new string[] { "string" })]
        public List<string>? ChildShipmentIds { get; set; }

        /// <summary>
        /// Overall Booking/Shipment status:
        /// <br/>- DRAFT - Booking not yet submitted
        /// <br/>- BOOKED - Booking submitted, waiting for response from TMS
        /// <br/>- IN_PROGRESS - Shipment created but not yet moving
        /// <br/>- IN_TRANSIT - Shipment picked-up/cargo received, depending on the movement type
        /// <br/>- COMPLETED - Shipment delivered / handed over at destination, depending on the movement type
        /// <br/>- CANCELED - Shipment has been canceled
        /// <br/>- REJECTED - Booking was rejected.
        /// </summary>
        [Description("Overall Booking/Shipment status:\n- DRAFT - Booking not yet submitted\n- BOOKED - Booking submitted, waiting for response from TMS\n- IN_PROGRESS - Shipment created but not yet moving\n- IN_TRANSIT - Shipment picked-up/cargo received, depending on the movement type\n- COMPLETED - Shipment delivered / handed over at destination, depending on the movement type\n- CANCELED - Shipment has been canceled\n- REJECTED - Booking was rejected.")]
        public string? Status { get; set; }
        /// <summary>
        /// Product
        /// </summary>
        [Description("Product")]
        [Required(AllowEmptyStrings = true)]
        public Product? Product { get; set; } = new Product();
        /// <summary>
        /// Parties
        /// </summary>
        [Description("Parties")]
        public Parties? Parties { get; set; }
        /// <summary>
        /// DateTime
        /// </summary>
        [Description("DateTime")]
        [Required(AllowEmptyStrings = true)]
        public DateTimeSection? DateTime { get; set; } = new DateTimeSection();

        /// <summary>
        /// All references that where used in the booking and/ or shipment to identify linked information. It is possible to receive several references of the same reference type.
        /// </summary>
        [Description("All references that where used in the booking and/ or shipment to identify linked information. It is possible to receive several references of the same reference type.")]
        public List<TypeValueDTO>? References { get; set; }

        /// <summary>
        /// Name of the user that submitted the booking
        /// </summary>
        [Description("Name of the user that submitted the booking")]
        public string? BookedBy { get; set; }

        /// <summary>
        /// Track and trace events
        /// </summary>
        [Description("Track and trace events")]
        [Required(AllowEmptyStrings = true)]
        public List<EventApiDto>? Events { get; set; }

        /// <summary>
        /// All package details in the booking/shipment.
        /// </summary>
        [Description("All package details in the booking/shipment.")]
        public List<PackageDTO>? Packages { get; set; }
        /// <summary>
        /// Transport
        /// </summary>
        [Description("Transport")]
        public TransportApiDto? Transport { get; set; }

        /// <summary>
        /// Container details in the booking/shipment.
        /// </summary>
        [Description("Container details in the booking/shipment.")]
        public List<ContainerSummaryDTO>? Containers { get; set; }

        /// <summary>
        /// Free text delivery instructions
        /// </summary>
        [Description("Free text delivery instructions")]
        public string? DeliveryInstructions { get; set; }

        /// <summary>
        /// Free text pickup instructions
        /// </summary>
        [Description("Free text pickup instructions")]
        public string? PickupInstructions { get; set; }

        /// <summary>
        /// Shipment notes
        /// </summary>
        [Description("Shipment notes")]
        public string? ShipmentNotes { get; set; }
        /// <summary>
        /// Incoterms
        /// </summary>
        public IncotermsDTO? Incoterms { get; set; }
        /// <summary>
        /// ServiceLevel
        /// </summary>
        public ServiceLevelDTO? ServiceLevel { get; set; }
        /// <summary>
        /// Goods
        /// </summary>
        public GoodsApiDto? Goods { get; set; }

        /// <summary>
        /// This section contains Issues details (reasons, dates, descriptions) if ocurred booking/shipment.
        /// </summary>
        [Description("This section contains Issues details (reasons, dates, descriptions) if ocurred booking/shipment.")]
        public List<IssueAPI>? Issues { get; set; }

        /// <summary>
        /// Global Unique Identifier of this shipment (GUID)
        /// </summary>
        [Description("Global Unique Identifier of this shipment (GUID)")]
        public string? PublicShipmentId { get; set; }

        /// <summary>
        /// Tracking ID used by the underlying express carrier
        /// </summary>
        [Description("Tracking ID used by the underlying express carrier")]
        public string? CarrierTrackingId { get; set; }

        /// <summary>
        /// Proof of delivery info (POD document)
        /// </summary>
        [Description("Proof of delivery info (POD document)")]
        [Required(AllowEmptyStrings = true)]
        public List<DocumentDto>? ProofsOfDelivery { get; set; }

        /// <summary>
        /// Service name, code and detail of the booking/shipment.
        /// </summary>
        [Description("Service name, code and detail of the booking/shipment.")]
        public List<Service>? SelectedServices { get; set; }
        /// <summary>
        /// Customs
        /// </summary>
        [Description("Customs")]
        public CustomsApiDto? Customs { get; set; }
    }
}
