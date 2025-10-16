using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Date and time specification for the shipment
    /// </summary>
    [Description("Date and time specification for the shipment")]
    public class DateTimeSection
    {
        /// <summary>
        /// PickupTime
        /// </summary>
        public DateTimeRange? PickupTime { get; set; }
        /// <summary>
        /// DeliveryTime
        /// </summary>        
        public DateTimeRange? DeliveryTime { get; set; }
    }
}
