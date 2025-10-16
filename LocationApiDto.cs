using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Event location details
    /// </summary>
    [Description("Event location details")]
    public class LocationApiDto
    {
        /// <summary>
        /// 2 letter ISO country code (e.g. US)
        /// </summary>
        [Description("2 letter ISO country code (e.g. US)")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// UN/LOCODE
        /// </summary>
        [Description("UN/LOCODE")]
        public string? Unlocode { get; set; }

        /// <summary>
        /// Associated location name
        /// </summary>
        [Description("Associated location name")]
        public string? Place { get; set; }
    }
}