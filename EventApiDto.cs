using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Track and trace events
    /// </summary>
    [Description("Track and trace events")]
    public class EventApiDto
    {
        /// <summary>
        /// The date/time of the event at the location the event took place. Format: 2020-07-13T22:00:00.000+0000
        /// </summary>
        [Description("The date/time of the event at the location the event took place. Format: 2020-07-13T22:00:00.000+0000")]
        [DataType(DataType.DateTime)]
        public string? EventDate { get; set; }

        /// <summary>
        /// The date/time of when event was last modified. Format: 2020-07-13T22:00:00.000+0000
        /// </summary>
        [Description("The date/time of when event was last modified. Format: 2020-07-13T22:00:00.000+0000")]
        [DataType(DataType.DateTime)]
        public string? EventLastModified { get; set; }

        /// <summary>
        /// Name of event group:
        /// <br/>- Booking - Group for events related to the booking
        /// <br/>- Pickup - Group for events related to the pick up for Road shipments
        /// <br/>- Pickup / Received - Group for events related to the pick up or received for Air and Sea Shipments
        /// <br/>- Main transport - Group for events related to multi-leg shipments
        /// <br/>- Import Customs - Group for events related to import customs
        /// <br/>- Export customs - Group for events related to import customs
        /// <br/>- Delivery - Group for events related to the delivery
        /// </summary>
        [Description("Name of event group:\n- Booking - Group for events related to the booking\n- Pickup - Group for events related to the pick up for Road shipments\n- Pickup / Received - Group for events related to the pick up or received for Air and Sea Shipments\n- Main transport - Group for events related to multi-leg shipments\n- Import Customs - Group for events related to import customs\n- Export customs - Group for events related to import customs\n- Delivery - Group for events related to the delivery")]
        public string? EventGroup { get; set; }

        /// <summary>
        /// Event code as provided by the Transport Management System:
        /// <br/>- ACT - Set shipment to active
        /// <br/>- ATC - Attach to Console
        /// <br/>- ARV - Actual arrival (last port/airport)
        /// <br/>- BOOKING - Booking
        /// <br/>- CANCEL - Cancelled
        /// <br/>- CLR - Customs cleared
        /// <br/>- DCF - Actual delivery
        /// <br/>- DEP - Actual departure (first port/airport)
        /// <br/>- DLV - Container delivered
        /// <br/>- ESTIMATED_DELIVERY - Estimated delivery
        /// <br/>- ESTIMATED_PICKUP - Estimated pickup
        /// <br/>- ETA - Estimated arrival (last port/airport)
        /// <br/>- ETD - Estimated departure (first port/airport)
        /// <br/>- FLO - Freight loaded
        /// <br/>- FUL - Freight unloaded
        /// <br/>- GIC - Arrived at warehouse
        /// <br/>- GIN - Gate In
        /// <br/>- GOC - Departure at warehouse
        /// <br/>- GOU - Gate Out
        /// <br/>- HPD - Held in depot
        /// <br/>- IGC - Trailer arrived at collection address
        /// <br/>- IGD - Trailer arrived at delivery address
        /// <br/>- INA - Set shipment to inactive
        /// <br/>- IRP - Cargo received
        /// <br/>- NCE - No pickup at customer
        /// <br/>- NDE - Not delivered at customer
        /// <br/>- OFD - Out for delivery
        /// <br/>- PCF - Actual pickup
        /// <br/>- PUP - Container picked up
        /// <br/>- REQUESTED_DELIVERY - Requested delivery
        /// <br/>- REQUESTED_PICKUP - Requested pickup
        /// <br/>- Z70 - Handover responsibility of cargo
        /// <br/>- Z71 - Customs reported
        /// <br/>- Z73 - Handover of cargo
        /// <br/>- Z74 - Handover of documents
        /// <br/>- RTC - Receipt Commenced
        /// <br/>- CAV - Cargo Available
        /// <br/>- Z72 - Customs Hold
        /// <br/>- DOR - Delivery Order Received
        /// <br/>- CCC - Customs Commenced
        /// <br/>- DDI (POD) - Document Imported - POD
        /// <br/>- DDI (CUI) - Clearance Instructions Received
        /// <br/>- ECM - Export Customs Commenced
        /// <br/>- ECC - Export Customs Cleared
        /// </summary>
        [Description("Event code as provided by the Transport Management System:\n- ACT - Set shipment to active\n- ATC - Attach to Console\n- ARV - Actual arrival (last port/airport)\n- BOOKING - Booking\n- CANCEL - Cancelled\n- CLR - Customs cleared\n- DCF - Actual delivery\n- DEP - Actual departure (first port/airport)\n- DLV - Container delivered\n- ESTIMATED_DELIVERY - Estimated delivery\n- ESTIMATED_PICKUP - Estimated pickup\n- ETA - Estimated arrival (last port/airport)\n- ETD - Estimated departure (first port/airport)\n- FLO - Freight loaded\n- FUL - Freight unloaded\n- GIC - Arrived at warehouse\n- GIN - Gate In\n- GOC - Departure at warehouse\n- GOU - Gate Out\n- HPD - Held in depot\n- IGC - Trailer arrived at collection address\n- IGD - Trailer arrived at delivery address\n- INA - Set shipment to inactive\n- IRP - Cargo received\n- NCE - No pickup at customer\n- NDE - Not delivered at customer\n- OFD - Out for delivery\n- PCF - Actual pickup\n- PUP - Container picked up\n- REQUESTED_DELIVERY - Requested delivery\n- REQUESTED_PICKUP - Requested pickup\n- Z70 - Handover responsibility of cargo\n- Z71 - Customs reported\n- Z73 - Handover of cargo\n- Z74 - Handover of documents\n- RTC - Receipt Commenced\n- CAV - Cargo Available\n- Z72 - Customs Hold\n- DOR - Delivery Order Received\n- CCC - Customs Commenced\n- DDI (POD) - Document Imported - POD\n- DDI (CUI) - Clearance Instructions Received\n- ECM - Export Customs Commenced\n- ECC - Export Customs Cleared")]
        public string? EventCode { get; set; }

        /// <summary>
        /// Description of the event code
        /// </summary>
        [Description("Description of the event code")]
        public string? EventDescription { get; set; }

        /// <summary>
        /// The associated element of this event:\nSHIPMENT -  DSV Shipment level event, \nCONTAINER - Container level event (only \"Sea\" and \"Rail\" shipments), \nCOLLI - Package level event (only \"Road\" shipments)
        /// </summary>
        [Description("The associated element of this event:\nSHIPMENT -  DSV Shipment level event, \nCONTAINER - Container level event (only \"Sea\" and \"Rail\" shipments), \nCOLLI - Package level event (only \"Road\" shipments)")]
        public string? EventType { get; set; }

        /// <summary>
        /// ID of the shipment, container or package
        /// </summary>
        [Description("ID of the shipment, container or package")]
        public string? EventTypeValue { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        public LocationApiDto? Location { get; set; }

        /// <summary>
        /// Mode of transport in case of multi-leg transport
        /// </summary>
        [Description("Mode of transport in case of multi-leg transport")]
        public string? TransportMode { get; set; }

        /// <summary>
        /// Vessel name in case of multi-leg transport
        /// </summary>
        [Description("Vessel name in case of multi-leg transport")]
        public string? VesselName { get; set; }

        /// <summary>
        /// Flight or vessel ID in case of multi-leg transport
        /// </summary>
        [Description("Flight or vessel ID in case of multi-leg transport")]
        public string? VoyageFlightNo { get; set; }

        /// <summary>
        /// Cut off date and time of when the shipment must be ready in the port
        /// </summary>
        [Description("Cut off date and time of when the shipment must be ready in the port")]
        [DataType(DataType.DateTime)]
        public string? CargoCutOff { get; set; }

        /// <summary>
        /// Cargo availability date
        /// </summary>
        [Description("Cargo availability date")]
        [DataType(DataType.DateTime)]
        public string? CargoAvailability { get; set; }

        /// <summary>
        /// Indicates if the event has been cancelled
        /// </summary>
        [Description("Indicates if the event has been cancelled")]
        [Required(AllowEmptyStrings = true)]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// Documents due deadline
        /// </summary>
        [Description("Documents due deadline")]
        [DataType(DataType.DateTime)]
        public string? DocsDue { get; set; }

        /// <summary>
        /// The date and time when the verified gross mass check must be completed
        /// </summary>
        [Description("The date and time when the verified gross mass check must be completed")]
        [DataType(DataType.DateTime)]
        public string? VgmCutOff { get; set; }
    }
}
