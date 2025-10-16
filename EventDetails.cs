using Newtonsoft.Json;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Tracking event details
    /// </summary>
    public class EventDetails
    {
        /// <summary>
        /// Flag to indicate if the event has changed
        /// </summary>
        [JsonProperty("isDateCancelled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDateCancelled { get; set; }

        /// <summary>
        /// Flag to indicate if the event is cancelled
        /// </summary>
        [JsonProperty("isDateChanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDateChanged { get; set; }

        /// <summary>
        /// Flag to indicate if the event is new
        /// </summary>
        [JsonProperty("isNewDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewDate { get; set; }

        /// <summary>
        /// Event Code - ESTIMATED_PICKUP, ESTIMATED_DELIVERY, ETA, ETD, ARV, DEP, PCF, DCF, CLR, ECC, IRP, Z70
        /// </summary>
        [JsonProperty("eventCode", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventCode { get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("eventDescription", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventDescription { get; set; }

        /// <summary>
        /// New event date
        /// </summary>
        [JsonProperty("newDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewDate { get; set; }

        /// <summary>
        /// Old event date
        /// </summary>
        [JsonProperty("oldDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OldDate { get; set; }

        [JsonExtensionData]
        private IDictionary<string, object>? _additionalProperties = new Dictionary<string, object>();

        /// <summary>
        /// Additional properties not defined in the model
        /// </summary>
        public IReadOnlyDictionary<string, object>? AdditionalProperties => (IReadOnlyDictionary<string, object>)_additionalProperties;
    }
}
