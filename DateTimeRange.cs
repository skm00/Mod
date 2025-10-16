using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Date with time range. Used e.g., for Pickup Date and Time.
    /// </summary>
    [Description("Date with time range. Used e.g., for Pickup Date and Time.")]
    public class DateTimeRange
    {
        /// <summary>
        /// The requested pickup/delivery date using the format YYYY-MM-DD
        /// </summary>
        [Description("The requested pickup/delivery date using the format YYYY-MM-DD")]
        [Required(AllowEmptyStrings = true)]
        [Example("2020-08-30")]
        [DataType(DataType.Date)]
        public string? Date { get; set; }
        /// <summary>
        /// Start
        /// </summary>
        [Example("10:00:00")]
        public TimeOnly? Start { get; set; }
        /// <summary>
        /// End
        /// </summary>
        [Example("11:00:00")]
        public TimeOnly? End { get; set; }
    }
}
