using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains the details of the  goods from the booking/shipment.
    /// </summary>
    [Description("This section contains the details of the  goods from the booking/shipment.")]
    public class GoodsApiDto
    {
        /// <summary>
        /// Unit of measure for total weight
        /// <br/> - KG = Kilo
        /// <br/> - LB = Pound
        /// </summary>
        [Description("Unit of measure for total weight\n - KG = Kilo\n - LB = Pound")]
        public string? GrossWeightUom { get; set; }

        /// <summary>
        /// Total gross weight of this shipment (summary off all package lines).
        /// </summary>
        [Description("Total gross weight of this shipment (summary off all package lines).")]
        public double? GrossWeightValue { get; set; }

        /// <summary>
        /// Unit of measure for total loading meters
        /// <br/> - LM = Load Meter
        /// </summary>
        [Description("Unit of measure for total loading meters\n - LM = Load Meter")]
        public string? LoadingMetersUom { get; set; }

        /// <summary>
        /// Total loading meters of this shipment (summary off all package lines).
        /// </summary>
        [Description("Total loading meters of this shipment (summary off all package lines).")]
        public double? LoadingMetersValue { get; set; }

        /// <summary>
        /// Unit of measure for total quantity
        /// </summary>
        [Description("Unit of measure for total quantity")]
        public string? QuantityUom { get; set; }

        /// <summary>
        /// Total quantity of this shipment (summary off all package lines).
        /// </summary>
        [Description("Total quantity of this shipment (summary off all package lines).")]
        public double? QuantityValue { get; set; }

        /// <summary>
        /// Unit of measure for total volume
        /// <br/>- M3 = Cubic meter
        /// <br/>- DM3 = Cubic decimetre
        /// <br/>- LTR = Liter
        /// <br/>- FT3 = Cubic feet
        /// </summary>
        [Description("Unit of measure for total volume\n- M3 = Cubic meter\n- DM3 = Cubic decimetre\n- LTR = Liter\n- FT3 = Cubic feet")]
        public string? VolumeUom { get; set; }

        /// <summary>
        /// Total volume of this shipment (summary off all package lines).
        /// </summary>
        [Description("Total volume of this shipment (summary off all package lines).")]
        public double? VolumeValue { get; set; }

        /// <summary>
        /// Description of the goods / commodity
        /// </summary>
        [Description("Description of the goods / commodity")]
        public string? Description { get; set; }

        /// <summary>
        /// The volumetric weight (based on dimension and a given factor) can be higher than the actual cargo weight.
        /// </summary>
        [Description("The volumetric weight (based on dimension and a given factor) can be higher than the actual cargo weight.")]
        public double? ChargeableWeight { get; set; }

        /// <summary>
        /// Weight UOM:
        /// <br/>- KG = Kilo
        /// <br/>- LB = Pound
        /// </summary>
        [Description("Weight UOM:\n- KG = Kilo\n- LB = Pound")]
        public string? ChargeableWeightUOM { get; set; }

        /// <summary>
        /// The volume used for charges (based on dimension and a given factor) can be higher than the actual cargo volume.
        /// </summary>
        [Description("The volume used for charges (based on dimension and a given factor) can be higher than the actual cargo volume.")]
        public double? ChargeableVolume { get; set; }

        /// <summary>
        /// Volume UOM:
        /// <br/>- M3 = Cubic meter
        /// <br/>- DM3 = Cubic decimetre
        /// <br/>- LTR = Liter
        /// <br/>- FT3 = Cubic feet
        /// </summary>
        [Description("Volume UOM:\n- M3 = Cubic meter\n- DM3 = Cubic decimetre\n- LTR = Liter\n- FT3 = Cubic feet")]
        public string? ChargeableVolumeUOM { get; set; }
    }
}