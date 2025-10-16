using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains Package identifier details from  the booking/shipment.
    /// </summary>
    [Description("This section contains Package identifier details from  the booking/shipment.")]
    public class PackageIdentifierDTO
    {
        /// <summary>
        /// Reference value
        /// </summary>
        [Description("Reference value")]
        public string? Reference { get; set; }

        /// <summary>
        /// Reference qualifier
        /// </summary>
        [Description("Reference qualifier")]
        public string? Qualifier { get; set; }
    }
}