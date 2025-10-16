using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// My DSV tracking notification dto , THIS WILL BE REPLACED  WITH TRACKING MODEL FROM  GENERIC LIBRARY ONCE THAT  IS FULLY  READY
    /// </summary>
    public class GenericTrackingNotificationDto
    {
        /// <summary>
        /// Notification type
        /// </summary>
        [Required]
        [JsonProperty("event", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string? Event { get; set; }

        /// <summary>
        /// Timestamp of the notification
        /// </summary>
        [JsonProperty("timestamp", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// TMS shipment ID
        /// </summary>
        [JsonProperty("shipmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ShipmentId { get; set; }

        /// <summary>
        /// Booking party ID
        /// </summary>
        [JsonProperty("bookingPartyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BookingPartyId { get; set; }

        /// <summary>
        /// Booking ID
        /// </summary>
        [JsonProperty("bookingId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BookingId { get; set; }

        [JsonProperty("eventDetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EventDetails? EventDetails { get; set; }

        [JsonProperty("shipmentDetails", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ShipmentDetailsAPI? ShipmentDetails { get; set; }

        private IDictionary<string, object>? _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object>? AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}
