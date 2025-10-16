using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// All fields related to Contact Person e.g. Name, Phone, email
    /// </summary>
    [Description("All fields related to Contact Person e.g. Name, Phone, email")]
    public class ContactPerson
    {
        /// <summary>
        /// Name of the contact person
        /// </summary>
        [Description("Name of the contact person")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(34)]
        [Example("Test Name")]
        public string? Name { get; set; }

        /// <summary>
        /// Email address of the contact person
        /// </summary>
        [Description("Email address of the contact person")]
        [Example("testemail@testcompany.com")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the contact person.
        /// </summary>
        [Description("Phone number of the contact person.")]
        [MaxLength(16)]
        [Example("+4512345678")]
        public string? Telephone { get; set; }
    }
}
