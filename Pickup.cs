using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Name and address of the party shipment is picked up.
    /// </summary>
    [Description("Name and address of the party shipment is picked up.")]
    public class Pickup
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
