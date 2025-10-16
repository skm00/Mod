using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains Issues details from the booking/shipment.
    /// </summary>
    [Description("This section contains Issues details from the booking/shipment.")]
    public class IssueAPI
    {
        /// <summary>
        /// Date when the issue has occurred (or spotted)
        /// </summary>
        [Description("Date when the issue has occurred (or spotted)")]
        [DataType(DataType.DateTime)]
        public string? IssueDate { get; set; }

        /// <summary>
        /// Place code where the issue occurred:
        /// <br/>- PRODPLAN - Production Planning
        /// <br/>- PROD - Production
        /// <br/>- POST - Post-Delivery
        /// <br/>- PIC - Origin/Pick up
        /// <br/>- TRAN - Main transport
        /// <br/>- DEL - Destination/Delivery
        /// <br/>- BOOK - Booking
        /// </summary>
        [Description("Place code where the issue occurred:\n- PRODPLAN - Production Planning\n- PROD - Production\n- POST - Post-Delivery\n- PIC - Origin/Pick up\n- TRAN - Main transport\n- DEL - Destination/Delivery\n- BOOK - Booking")]
        public string? IssuePointCode { get; set; }

        /// <summary>
        /// Place where the issue occurred
        /// </summary>
        [Description("Place where the issue occurred")]
        public string? IssuePointDescription { get; set; }

        /// <summary>
        /// Party code who caused the issue:- TERMIN - Terminal
        /// <br/>- SHPR - Shipper
        /// <br/>- SUP - Pickup From/Supplier
        /// <br/>- HAUL - Haulier/Trucker
        /// <br/>- FM - Force Majeure
        /// <br/>- DSV - DSV
        /// <br/>- DELV - Deliver To
        /// <br/>- CUS - Consignee/Buyer
        /// <br/>- CAR - Carrier
        /// <br/>- BRO - Broker
        /// <br/>- AUT - Authorities
        /// <br/>- 3PARTY - 3rd Party
        /// </summary>
        [Description("Party code who caused the issue:- TERMIN - Terminal\n- SHPR - Shipper\n- SUP - Pickup From/Supplier\n- HAUL - Haulier/Trucker\n- FM - Force Majeure\n- DSV - DSV\n- DELV - Deliver To\n- CUS - Consignee/Buyer\n- CAR - Carrier\n- BRO - Broker\n- AUT - Authorities\n- 3PARTY - 3rd Party")]
        public string? IssuePartyCode { get; set; }

        /// <summary>
        /// Party who caused the issue
        /// </summary>
        [Description("Party who caused the issue")]
        public string? IssuePartyDescription { get; set; }

        /// <summary>
        /// Coded categorization of the issue:- UND - Underload
        /// <br/>- SAFETY - Safety
        /// <br/>- PRDQU - Product Quality
        /// <br/>- PRDAV - Product Availability
        /// <br/>- OVR - Overload
        /// <br/>- MISSING - Missing
        /// <br/>- LATE - Late
        /// <br/>- INV - Invoicing
        /// <br/>- EARLY - Early
        /// <br/>- DOC - Documentation / Administration
        /// <br/>- DMG - Damage (use notes for detailed information)
        /// <br/>- OTH - Other
        /// <br/>- TMP - Temperature
        /// <br/>- QRTO - Quarantine Open
        /// <br/>- QRTC - Quarantine Closed
        /// </summary>
        [Description("Coded categorization of the issue:- UND - Underload\n- SAFETY - Safety\n- PRDQU - Product Quality\n- PRDAV - Product Availability\n- OVR - Overload\n- MISSING - Missing\n- LATE - Late\n- INV - Invoicing\n- EARLY - Early\n- DOC - Documentation / Administration\n- DMG - Damage (use notes for detailed information)\n- OTH - Other\n- TMP - Temperature\n- QRTO - Quarantine Open\n- QRTC - Quarantine Closed")]
        public string? IssueTypeCode { get; set; }

        /// <summary>
        /// Categorization of the issue
        /// </summary>
        [Description("Categorization of the issue")]
        public string? IssueTypeDescription { get; set; }

        /// <summary>
        /// Coded reason why the issue occurred:- ACC - Accident, Theft and Vandalism
        /// <br/>- BANK - Bank Holiday
        /// <br/>- COM - Communication/Incorrect Instructions
        /// <br/>- COST - Cost Approval
        /// <br/>- DEST - DSV Destination Process/Query
        /// <br/>- DOCS - Document(s)
        /// <br/>- ECOND - Equipment Condition/Type
        /// <br/>- EQU - Equipment Breakdown
        /// <br/>- HUM - Human Error/Incorrect Handling
        /// <br/>- IMPROP - Improper Packaging/Labeling
        /// <br/>- INS - Inspection / Excessive Customs Process
        /// <br/>- IT - IT
        /// <br/>- LACKEQ - Lack of Equipment
        /// <br/>- LATEINS - Late Instruction/Communication
        /// <br/>- MISROUTE - Change in Schedule/Misrouting
        /// <br/>- NON - Non Availability
        /// <br/>- ORIG - DSV Origin Process/Query
        /// <br/>- PROD - Faulty product
        /// <br/>- PST - Postponed
        /// <br/>- RAW - Lack of raw material
        /// <br/>- REJECT - Rejection
        /// <br/>- RSC - Resources
        /// <br/>- SLP - Sales process
        /// <br/>- SOP - Operating Procedure
        /// <br/>- SPOT - None Contractual Shipment/Spot Shipment
        /// <br/>- STR - Strike
        /// <br/>- TRF - Traffic
        /// <br/>- TTNOT - Agreed Transittime Not Achievable
        /// <br/>- UNS - Unsafe Conditions
        /// <br/>- UPR - Upon Request
        /// <br/>- WAR - War
        /// <br/>- WTH - Weather/Nature
        /// </summary>
        [Description("Coded reason why the issue occurred:- ACC - Accident, Theft and Vandalism\n- BANK - Bank Holiday\n- COM - Communication/Incorrect Instructions\n- COST - Cost Approval\n- DEST - DSV Destination Process/Query\n- DOCS - Document(s)\n- ECOND - Equipment Condition/Type\n- EQU - Equipment Breakdown\n- HUM - Human Error/Incorrect Handling\n- IMPROP - Improper Packaging/Labeling\n- INS - Inspection / Excessive Customs Process\n- IT - IT\n- LACKEQ - Lack of Equipment\n- LATEINS - Late Instruction/Communication\n- MISROUTE - Change in Schedule/Misrouting\n- NON - Non Availability\n- ORIG - DSV Origin Process/Query\n- PROD - Faulty product\n- PST - Postponed\n- RAW - Lack of raw material\n- REJECT - Rejection\n- RSC - Resources\n- SLP - Sales process\n- SOP - Operating Procedure\n- SPOT - None Contractual Shipment/Spot Shipment\n- STR - Strike\n- TRF - Traffic\n- TTNOT - Agreed Transittime Not Achievable\n- UNS - Unsafe Conditions\n- UPR - Upon Request\n- WAR - War\n- WTH - Weather/Nature")]
        public string? IssueReasonCode { get; set; }

        /// <summary>
        /// Reason why the issue occurred
        /// </summary>
        [Description("Reason why the issue occurred")]
        public string? IssueReasonDescription { get; set; }

        /// <summary>
        /// Additional information about the issue (max 100 characters)
        /// </summary>
        [Description("Additional information about the issue (max 100 characters)")]
        public string? IssueNotes { get; set; }

        /// <summary>
        /// Date when the issue was resolved
        /// </summary>
        [Description("Date when the issue was resolved")]
        [DataType(DataType.DateTime)]
        public string? IssueResolved { get; set; }
    }
}
