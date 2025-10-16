using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Customs data
    /// </summary>
    [Description("Customs data")]
    public class CustomsApiDto
    {
        /// <summary>
        /// Date when the cargo was loaded on the Vessel at the Port of Loading mentioned on the Bill of Lading
        /// </summary>
        [Description("Date when the cargo was loaded on the Vessel at the Port of Loading mentioned on the Bill of Lading")]
        public string? ShippedOnboardDate { get; set; }

        /// <summary>
        /// Customs status:
        /// <br/>- CLR - Import customs cleared
        /// <br/>- Z72 - Customs hold
        /// <br/>- CCC - Import customs commenced
        /// <br/>- ECC - Export customs cleared
        /// <br/> - ECM - Export customs commenced
        /// </summary>
        [Description("Customs status:\n- CLR - Import customs cleared\n- Z72 - Customs hold\n- CCC - Import customs commenced\n- ECC - Export customs cleared\n - ECM - Export customs commenced")]
        public string? CustomsStatus { get; set; }

        /// <summary>
        /// Customs Entry reference given by Customs authority in the local customs process
        /// </summary>
        [Description("Customs Entry reference given by Customs authority in the local customs process")]
        [Required(AllowEmptyStrings = true)]
        [Example(new string[] { "string" })]
        public List<string>? EntryNumber { get; set; }
        /// <summary>
        /// Forwarder
        /// </summary>
        public BaseParty? Forwarder { get; set; }

        /// <summary>
        /// Mode of transport for a transit into another country
        /// </summary>
        [Description("Mode of transport for a transit into another country")]
        public string? RemovalMode { get; set; }
    }
}
