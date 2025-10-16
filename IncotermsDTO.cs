using System.ComponentModel;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// Incoterms® describe the rights and obligations applicable between the buyer and seller of the goods being transported. They set out when transfer of liability and control take place, who pays for what and who is liable in the event of any damage or loss of goods in transit. For more information check the Incoterms® Information on https://www.dsv.com/en/insights/expert-opinions/what-are-incoterms
    /// </summary>
    [Description("Incoterms® describe the rights and obligations applicable between the buyer and seller of the goods being transported. They set out when transfer of liability and control take place, who pays for what and who is liable in the event of any damage or loss of goods in transit. For more information check the Incoterms® Information on https://www.dsv.com/en/insights/expert-opinions/what-are-incoterms")]
    public class IncotermsDTO
    {
        /// <summary>
        /// Incoterms® Code according to Incoterms® 2020 standard
        /// </summary>
        [Description("Incoterms® Code according to Incoterms® 2020 standard")]
        public string? Code { get; set; }

        /// <summary>
        /// The location element specified as the collection/delivery
        /// </summary>
        [Description("The location element specified as the collection/delivery")]
        public string? Location { get; set; }
    }
}