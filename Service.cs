using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains additional Service details from the booking/shipment.
    /// </summary>
    [Description("This section contains additional Service details from the booking/shipment.")]
    public class Service
    {
        /// <summary>
        /// Service name
        /// </summary>
        [Description("Service name")]
        [Required(AllowEmptyStrings = true)]
        public string? Name { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [Description("Display name")]
        [Required(AllowEmptyStrings = true)]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Service code
        /// </summary>
        [Description("Service code")]
        [Obsolete]
        public string? Code { get; set; }

        /// <summary>
        /// Booked service details
        /// </summary>
        [Description("Booked service details")]
        public Dictionary<string, object>? Details { get; set; } = new Dictionary<string, object> { };
    }
}
