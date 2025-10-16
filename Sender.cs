using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Name and address of the party sending the goods (shipper).\nIf address is not already available, it will be created from supplied address data.
    /// </summary>
    [Description("Name and address of the party sending the goods (shipper).\nIf address is not already available, it will be created from supplied address data.")]
    public class Sender
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
