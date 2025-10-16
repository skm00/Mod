using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// All package details in the booking/shipment.
    /// </summary>
    [Description("All package details in the booking/shipment.")]
    public class PackageDTO
    {
        /// <summary>
        /// STACKABLE = the goods could be stacked
        /// <br/>STACKED = the goods were stacked prior to pickup.
        /// <br/>NO = the goods were not stackable
        /// </summary>
        [Description("STACKABLE = the goods could be stacked\nSTACKED = the goods were stacked prior to pickup. \nNO = the goods were not stackable.")]
        public object? Stackable { get; set; }

        /// <summary>
        /// Dimension of single package in UOM: length
        /// </summary>
        [Description("Dimension of single package in UOM: length")]
        public double? Length { get; set; }

        /// <summary>
        /// This element specifies the units of measure (UOM) applied to length measurement
        /// </summary>
        [Description("This element specifies the units of measure (UOM) applied to length measurement")]
        public string? LengthUOM { get; set; }

        /// <summary>
        /// Loading meter is one meter of length of goods on a trailer. This is only available for product "Road"
        /// </summary>
        [Description("Loading meter is one meter of length of goods on a trailer. This is only available for product \"Road\"")]
        public double? LoadingMeters { get; set; }

        /// <summary>
        /// Number of pallets on the ground floor (e.g. if 6 pallets are stacked 2 by 2, palletSpace will be equal to 3). This is only available for product \"Road\"
        /// </summary>
        [Description("Number of pallets on the ground floor (e.g. if 6 pallets are stacked 2 by 2, palletSpace will be equal to 3). This is only available for product \"Road\"")]
        public int? PalletSpace { get; set; }

        /// <summary>
        /// Total gross weight for this package line.
        /// </summary>
        [Description("Total gross weight for this package line.")]
        public double? GrossWeight { get; set; }

        /// <summary>
        /// Net weight for this package line.
        /// </summary>
        [Description("Net weight for this package line.")]
        public double? NetWeight { get; set; }

        /// <summary>
        /// Number of packages in this package line
        /// </summary>
        [Description("Number of packages in this package line")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Total volume of this package line.
        /// </summary>
        [Description("Total volume of this package line.")]
        public double? TotalVolume { get; set; }

        /// <summary>
        /// This section is used to specify the units of measure (UOM) applied to Volume measurement
        /// </summary>
        [Description("This section is used to specify the units of measure (UOM) applied to Volume measurement")]
        public string? VolumeUOM { get; set; }

        /// <summary>
        /// Total weight for this package line.
        /// </summary>
        [Description("Total weight for this package line.")]
        public double? TotalWeight { get; set; }

        /// <summary>
        /// Dimension of single package in UOM: width
        /// </summary>
        [Description("Dimension of single package in UOM: width")]
        public double? Width { get; set; }

        /// <summary>
        /// This section is used to specify the units of measure (UOM) applied to Width measurement
        /// </summary>
        [Description("This section is used to specify the units of measure (UOM) applied to Width measurement")]
        public string? WidthUOM { get; set; }

        /// <summary>
        /// Dimension of single package in UOM: height
        /// </summary>
        [Description("Dimension of single package in UOM: height")]
        public double? Height { get; set; }

        /// <summary>
        /// This section is used to specify the units of measure (UOM) applied to height measurement
        /// </summary>
        [Description("This section is used to specify the units of measure (UOM) applied to height measurement")]
        public string? HeightUOM { get; set; }

        /// <summary>
        /// Package type used for this package line.
        /// </summary>
        [Description("Package type used for this package line.")]
        public string? PackageType { get; set; }

        /// <summary>
        /// Minimum level temperature requirement for temperature controlled cargo.
        /// </summary>
        [Description("Minimum level temperature requirement for temperature controlled cargo.")]
        public long? TemperatureMin { get; set; }

        /// <summary>
        /// Maximum level temperature requirement for temperature controlled cargo.
        /// </summary>
        [Description("Maximum level temperature requirement for temperature controlled cargo.")]
        public long? TemperatureMax { get; set; }

        /// <summary>
        /// Package level cargo description
        /// </summary>
        [Description("Package level cargo description")]
        public string? Description { get; set; }

        /// <summary>
        /// Package level Marks and Numbers (only "Road" shipments)
        /// </summary>
        [Description("Package level Marks and Numbers (only \"Road\" shipments)")]
        public string? ShippingMarks { get; set; }

        /// <summary>
        /// Package level Marks and Numbers list (only "Air" and "Sea"  shipments)
        /// </summary>
        [Description("Package level Marks and Numbers list (only \"Air\" and \"Sea\"  shipments)")]
        public List<string>? ShippingMarksList { get; set; }

        /// <summary>
        /// Package level Harmonized Codes (HS Codes)
        /// </summary>
        [Description("Package level Harmonized Codes (HS Codes)")]
        public List<string>? HarmonizedCodes { get; set; }

        /// <summary>
        /// If the content of this package line is classified as dangerous goods this field will be set to "true".
        /// </summary>
        [Description("If the content of this package line is classified as dangerous goods this field will be set to \"true\".")]
        public bool? IsDangerous { get; set; }

        /// <summary>
        /// This section contains the details of the dangerous goods.
        /// </summary>
        [Description("This section contains the details of the dangerous goods.")]
        public List<DangerousGoodsDTO>? Dangerous { get; set; }

        /// <summary>
        /// Reference to an FCL container line (see container section above), this is only to be used for products \"Sea\" and \"Rail\".
        /// </summary>
        [Description("Reference to an FCL container line (see container section above), this is only to be used for products \"Sea\" and \"Rail\".")]
        public string? ContainerNo { get; set; }

        /// <summary>
        /// SSCC tracking number for the package element.
        /// </summary>
        [Description("SSCC tracking number for the package element.")]
        [Example(new string[] { "string" })]
        public List<string>? TrackingNumbers { get; set; }

        /// <summary>
        /// Only used for dangerous goods packages, only used for product "Air"
        /// </summary>
        [Description("Only used for dangerous goods packages, only used for product \"Air\"")]
        public bool? CargoAircraftOnly { get; set; }

        /// <summary>
        /// If the goods required a certain temperature (or temperature range) during transport it will be set to \"true\"
        /// </summary>
        [Description("If the goods required a certain temperature (or temperature range) during transport it will be set to \"true\"")]
        public bool? TemperatureControlled { get; set; }

        /// <summary>
        /// Goods type
        /// </summary>
        [Description("Goods type")]
        public string? GoodsType { get; set; }
        /// <summary>
        /// Battery
        /// </summary>
        public Battery? Battery { get; set; }

        /// <summary>
        /// Package reference number
        /// </summary>
        [Description("Package reference number")]
        public string? ReferenceNumber { get; set; }

        /// <summary>
        /// References sent along with the booking that can be later on used to identify linked information.
        /// </summary>
        [Description("References sent along with the booking that can be later on used to identify linked information.")]
        public List<PackageIdentifierDTO>? References { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        public string? Type { get; set; }
    }
}
