using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Contains all parties involved in the booking. See the party definition section for more details.
    /// </summary>
    [Description("Contains all parties involved in the booking. See the party definition section for more details.")]
    public class Parties
    {
        /// <summary>
        /// Sender
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public Sender? Sender { get; set; } = new Sender();
        /// <summary>
        /// Receiver
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public Receiver? Receiver { get; set; } = new Receiver();
        /// <summary>
        /// Delivery
        /// </summary>
        public Delivery? Delivery { get; set; }
        /// <summary>
        /// Pickup
        /// </summary>
        public Pickup? Pickup { get; set; }
        /// <summary>
        /// Notify
        /// </summary>
        public Notify? Notify { get; set; }
        /// <summary>
        /// FreightPayer
        /// </summary>
        public FreightPayer? FreightPayer { get; set; }
        /// <summary>
        /// BookingParty
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public BookingParty? BookingParty { get; set; } = new BookingParty();
        /// <summary>
        /// Carrier
        /// </summary>
        public Carrier? Carrier { get; set; }
        /// <summary>
        /// reserved for future use
        /// </summary>
        [Description("reserved for future use")]
        public List<Party>? Party { get; set; }
    }
}
