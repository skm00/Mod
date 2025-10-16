using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// This section contains all document details of Profs of delivery.
    /// </summary>
    [Description("This section contains all document details of Profs of delivery.")]
    public class DocumentDto
    {
        /// <summary>
        /// DocumentId
        /// </summary>
        [Description("Document ID")]
        [Required(AllowEmptyStrings = true)]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Proof of delivery (POD), \nCommercial Invoice, \nOther goods documents, \nCustoms declaration, \nDangerous goods documents, \nPacking list, \nHouse bill of lading
        /// </summary>
        [Description("Proof of delivery (POD), \nCommercial Invoice, \nOther goods documents, \nCustoms declaration, \nDangerous goods documents, \nPacking list, \nHouse bill of lading")]
        [Required(AllowEmptyStrings = true)]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Description of the document type
        /// </summary>
        [Description("Description of the document type")]
        [Required(AllowEmptyStrings = true)]
        public string? TypeDescription { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        [Description("Date of creation")]
        [DataType(DataType.DateTime)]
        public string? CreateDate { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        [Description("File name")]
        [Required(AllowEmptyStrings = true)]
        public string? FileName { get; set; }

        /// <summary>
        /// File type
        /// </summary>
        [Description("File type")]
        [Required(AllowEmptyStrings = true)]
        public string? FileType { get; set; }

        /// <summary>
        /// URL for file download
        /// </summary>
        [Description("URL for file download")]
        [Required(AllowEmptyStrings = true)]
        public string? DownloadUrl { get; set; }
    }
}