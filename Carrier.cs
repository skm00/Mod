using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Name and address of the carrier
    /// </summary>
    [Description("Name and address of the carrier")]
    public class Carrier
    {
        /// <summary>
        /// Address
        /// </summary>
        public Address? Address { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        public ContactPerson? Contact { get; set; }
    }
}
