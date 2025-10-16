using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Name and address of the party who will be notified
    /// </summary>
    [Description("Name and address of the party who will be notified")]
    public class Notify
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
