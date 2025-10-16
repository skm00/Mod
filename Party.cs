using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Reserved for future use.
    /// </summary>
    [Description("Reserved for future use.")]
    public class Party
    {
        /// <summary>
        /// Address
        /// </summary>
        public Address? Address { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        public ContactPerson? Contact { get; set; }
        /// <summary>
        /// Business role of the party
        /// </summary>
        [Description("Business role of the party")]
        [Required(AllowEmptyStrings = true)]
        public string? Role { get; set; }
    }
}
