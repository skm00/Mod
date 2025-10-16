using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains the details of the dangerous goods in the booking/shipment.
    /// </summary>
    [Description("This section contains the details of the dangerous goods in the booking/shipment.")]
    public class DangerousGoodsDTO
    {
        /// <summary>
        /// The UN className can be derived from the mandatory unCode.
        /// <br/>If this value is supplied, it will match the UN className that is stored for the unCode.
        /// </summary>
        [Description("The UN className can be derived from the mandatory unCode.\nIf this value is supplied, it will match the UN className that is stored for the unCode.")]
        public string? ClassName { get; set; }

        /// <summary>
        /// The UN subRisk can be derived from the mandatory unCode.
        /// <br/>If this value is supplied, it will match the UN subRisk that is stored for the unCode.
        /// </summary>
        [Description("The UN subRisk can be derived from the mandatory unCode.\nIf this value is supplied, it will match the UN subRisk that is stored for the unCode.")]
        public string? SubRisk { get; set; }

        /// <summary>
        /// The flashPoint will be provided in the "Unit of Measure" selected for temperature in the units object.
        /// <br/>This can only be used for dangerous goods type = "IMDG".
        /// <br/>This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("The flashPoint will be provided in the \"Unit of Measure\" selected for temperature in the units object.\nThis can only be used for dangerous goods type = \"IMDG\".\nThis value can be mandatory depending on the UN code.")]
        public double? FlashPoint { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public bool? LimitedQuantity { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public bool? MarinePollutant { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public string? PackingGroup { get; set; }

        /// <summary>
        /// The UN properShippingName can be derived from the mandatory unCode.
        /// <br/>If this value is supplied, it will match the UN properShippingName that is stored for the provided unCode.
        /// </summary>
        [Description("The UN properShippingName can be derived from the mandatory unCode.\nIf this value is supplied, it will match the UN properShippingName that is stored for the provided unCode.")]
        public string? ProperShippingName { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public string? TechnicalName { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public string? TechnicalNameNational { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public double? TemperatureFrom { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public double? TemperatureTo { get; set; }

        /// <summary>
        /// Classification type used for the declaration
        /// <br/>ADR = According to "Agreement concerning the International Carriage of Dangerous Goods by Road".
        /// <br/>IMDG = According to "International Maritime Dangerous Goods Code".
        /// <br/>IATA = According to "International Air Transport Association (IATA) Dangerous Goods Regulations (DGR)"
        /// </summary>
        [Description("Classification type used for the declaration\nADR = According to \"Agreement concerning the International Carriage of Dangerous Goods by Road\".\nIMDG = According to \"International Maritime Dangerous Goods Code\".\nIATA = According to \"International Air Transport Association (IATA) Dangerous Goods Regulations (DGR)\"")]
        public string? Type { get; set; }

        /// <summary>
        /// The UN code identifying the Dangerous Goods.
        /// </summary>
        [Description("The UN code identifying the Dangerous Goods.")]
        public int? UnCode { get; set; }

        /// <summary>
        /// This value can be mandatory depending on the UN code.
        /// </summary>
        [Description("This value can be mandatory depending on the UN code.")]
        public string? TunnelCode { get; set; }

        /// <summary>
        /// Number of Packages containing these dangerous goods
        /// </summary>
        [Description("Number of Packages containing these dangerous goods")]
        public int? PackagesCount { get; set; }

        /// <summary>
        /// Package type containing these dangerous goods. Possible values are:
        /// <br/>- BAG - Bag
        /// <br/>- BOB - Bundle Of Bottles
        /// <br/>- BOX - Box
        /// <br/>- CP - Composite Packages
        /// <br/>- DRM - Drum
        /// <br/>- IBC - Intermediate Bulk Container
        /// <br/>- JCN - Jerry can
        /// <br/>- LGM - Light Gauge Metal packagings
        /// <br/>- PD - Pressure Drum
        /// <br/>- SB - Steel Bottle
        /// </summary>
        [Description("\"Package type containing these dangerous goods. Possible values are:\nBAG - Bag\nBOX - Carton / Box\nIBC - Intermediate Bulk Container\nCP - Composite Packaging\nLGM - Light Gauge Metal Packaging\nBOB - Bundle of Bottles\nPD - Pressure Drum\nSB - Steel Bottle\nDRM - Drum\nJCN - Jerry Can\"\n")]
        public string? PackingKind { get; set; }

        /// <summary>
        /// Net quantity of the dangerous goods
        /// </summary>
        [Description("Net quantity of the dangerous goods")]
        public double? NetQuantity { get; set; }

        /// <summary>
        /// Quantity unit of the dangerous goods
        /// </summary>
        [Description("Quantity unit of the dangerous goods")]
        public string? NetQuantityUnit { get; set; }

        /// <summary>
        /// Gross quantity of the dangerous goods
        /// </summary>
        [Description("Gross quantity of the dangerous goods")]
        public double? GrossQuantity { get; set; }

        /// <summary>
        /// Quantity unit of the dangerous goods
        /// </summary>
        [Description("Quantity unit of the dangerous goods")]
        public string? GrossQuantityUnit { get; set; }

        /// <summary>
        /// True / False
        /// </summary>
        [Description("True / False")]
        public bool? Empty { get; set; }
    }
}
