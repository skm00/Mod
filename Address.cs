using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// All fields related to the address of the business partner.
    /// </summary>
    [Description("All fields related to the address of the business partner.")]
    public class Address
    {
        /// <summary>
        /// Company Name 
        /// <br/> Company Name is mandatory if the address is not provided via \"mdm\", \"addressId\" or based on a myDSV template. (length 36)
        /// </summary>
        [Example("Test Company Name Inc.")]
        [Description("Company Name is mandatory if the address is not provided via \"mdm\", \"addressId\" or based on a myDSV template. (length 36)")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Customer addressId refers to an entry in the address book within DSV’s myDSV customer portal. If a unique match is found, that address will be used and all other address fields will be ignored. This validation has lower priority than the "mdm" field. If the addressId is not unique, full address details must be provided. When the provided address matches an existing one, it will be used; otherwise, a new entry will be created in the myDSV address book. (Length: 40)
        /// </summary>
        [Example("AddressID123")]
        [Description("Customer addressId refers to an entry in the address book within DSV’s myDSV customer portal. If a unique match is found, that address will be used and all other address fields will be ignored. This validation has lower priority than the \"mdm\" field. If the addressId is not unique, full address details must be provided. When the provided address matches an existing one, it will be used; otherwise, a new entry will be created in the myDSV address book. (Length: 40)")]
        public string? AddressId { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [Example("Test Address Line 1")]
        [Description("Address line 1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// Additional address line
        /// </summary>
        [Example("Test Address Line 2")]
        [MaxLength(36)]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// Additional address line
        /// </summary>
        [ReadOnly(true)]
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// City name  is mandatory if the address is not provided via "mdm", "addressId" or based on a myDSV template.
        /// </summary>
        [Example("Test Address City")]
        [Description("City name  is mandatory if the address is not provided via \"mdm\", \"addressId\" or based on a myDSV template.")]
        public string? City { get; set; }

        /// <summary>
        /// 2 letter ISO country code (e.g. US)  is mandatory if the address is not provided via "mdm", "addressId" or based on a myDSV template.
        /// </summary>
        [Example("DK")]
        [Description("2 letter ISO country code (e.g. US)  is mandatory if the address is not provided via \"mdm\", \"addressId\" or based on a myDSV template.")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// State name or state code.
        /// </summary>
        [Description("State name or state code.")]
        public string? State { get; set; }

        /// <summary>
        /// Postal code  is mandatory if the address is not provided via "mdm", "addressId" or based on a myDSV template.
        /// </summary>
        [Example("1234")]
        [Description("Postal code  is mandatory if the address is not provided via \"mdm\", \"addressId\" or based on a myDSV template.")]
        public string? ZipCode { get; set; }

        /// <summary>
        /// Instructions related to this party on the booking (e.g. pickup instructions for the pickup address)
        /// </summary>
        [Example("Specific Address Party Instrution")]
        [Description("Instructions related to this party on the booking (e.g. pickup instructions for the pickup address)")]
        [Obsolete]
        public string? Instructions { get; set; }

        /// <summary>
        /// DSV debitor number ( MDM number)
        /// </summary>
        [Example("6412345678")]
        [Description("DSV debitor number ( MDM number)")]
        public string? Mdm { get; set; }

        /// <summary>
        /// Economic Operators Registration and Identification number (EORI number).
        /// </summary>
        [Example("DE123456789012AZ")]
        [Description("Economic Operators Registration and Identification number (EORI number).")]
        public string? Eori { get; set; }

        /// <summary>
        /// OptionInformation about the sender/pickup being an approved shipper. Only available for transport modes "Air".
        /// </summary>
        [Description("Information about the sender/pickup being an approved shipper. Only available for transport modes \"Air\".")]
        public string? ApprovedShipper { get; set; }
    }
}
