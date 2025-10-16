using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains details on the requested service level from the "Air", "Sea" or "Rail" booking/shipment
    /// </summary>
    [Description("This section contains details on the requested service level from the \"Air\", \"Sea\" or \"Rail\" booking/shipment")]
    public class ServiceLevelDTO
    {
        /// <summary>
        /// Service level code
        /// </summary>
        [Description("Service level code")]
        public string? Code { get; set; }

        /// <summary>
        /// Service level description
        /// </summary>
        [Description("Service level description")]
        public string? Description { get; set; }
    }
}