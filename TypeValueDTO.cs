using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// References that can be used to identify linked information. It is allowed to send several references of the same reference type.
    /// </summary>
    [Description("References that can be used to identify linked information. It is allowed to send several references of the same reference type.")]
    public class TypeValueDTO
    {
        /// <summary>
        /// Type of reference: <ul><li>INVOICING_REFERENCE</li><li>ORDER_NUMBER</li><li>CONSIGNEE_REFERENCE</li><li>SHIPPER_REFERENCE</li><li>CUSTOMS_REFERENCE</li><li>OTHER</li><li>ROUTING</li></ul>
        /// </summary>
        [Description("Type of reference: <ul><li>INVOICING_REFERENCE</li><li>ORDER_NUMBER</li><li>CONSIGNEE_REFERENCE</li><li>SHIPPER_REFERENCE</li><li>CUSTOMS_REFERENCE</li><li>OTHER</li><li>ROUTING</li></ul>")]
        public string? Type { get; set; }

        /// <summary>
        /// Reference value
        /// </summary>
        [Description("Reference value")]
        public string? Value { get; set; }
    }
}
