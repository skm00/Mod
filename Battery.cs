using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Battery information
    /// </summary>
    [Description("Battery information")]
    public class Battery
    {
        /// <summary>
        /// Battery type
        /// </summary>
        [Description("Battery type")]
        public string? BatteryType { get; set; }
        /// <summary>
        /// Battery Package type
        /// </summary>
        [Description("Battery Package type")]
        public string? BatteryPackageType { get; set; }
    }
}