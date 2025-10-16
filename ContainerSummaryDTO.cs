using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Summary of container information
    /// </summary>
    [Description("Summary of container information")]
    public class ContainerSummaryDTO
    {
        /// <summary>
        /// Container Number
        /// </summary>
        [Description("Container Number")]
        public string? ContainerNumber { get; set; }

        /// <summary>
        /// Container type
        /// </summary>
        [Description("Container type")]
        public string? ContainerType { get; set; }

        /// <summary>
        /// Seal Number
        /// </summary>
        [Description("Seal Number")]
        public string? SealNumber { get; set; }

        /// <summary>
        /// Slot Date. Format: 2020-07-13T22:00:00.000+0000
        /// </summary>
        [Description("Slot Date. Format: 2020-07-13T22:00:00.000+0000")]
        [DataType(DataType.DateTime)]
        public string? SlotDate { get; set; }
    }
}
