using ES.API.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace es_api_generic_subscriber_update.Models.Tracking
{
    /// <summary>
    /// The product section carries the information about the main transport and some directly associated parameters, if any.
    /// </summary>
    [Description("The product section carries the information about the main transport mode and some directly associated parameters, if any.")]
    public class Product
    {
        /// <summary>
        /// Main transport mode selection
        /// </summary>
        [Description("Main transport mode selection")]
        [Required(AllowEmptyStrings = true)]
        [Example("Sea")]
        public string? Name { get; set; }

        /// <summary>
        /// Select the Bill of Lading type.\nOnly available if product is \"Sea\".
        /// </summary>
        [Description("Select the Bill of Lading type.\nOnly available if product is \"Sea\".")]
        [Example("Original")]
        public string? BillOfLading { get; set; }

        /// <summary>
        /// Container mode:
        /// <br/>FCL: full container load
        /// <br/>LCL: less than container load
        /// <br/>(only available for product “Sea” and “Rail”)
        /// </summary>
        [Description("\"Container mode:\nFCL: full container load\nLCL: less than container load\nOnly available for product \"\"Sea\"\" and \"\"Rail\"\".\"\n")]
        [Example("FCL")]
        public string? ContainerMode { get; set; }

        /// <summary>
        /// This section is only available for the products “Sea” and “Rail” while the Container mode is “FCL”. 
        /// <br/>It is used to specify the required containers of a certain type. Additional attributes can be submitted for certain container types.
        /// <br/>More details on container types can be found at [link]
        /// </summary>
        [Description("This section is only available for the products “Sea” and “Rail” when the Container mode is “FCL”. It is used to specify the required containers of a certain type. Additional attributes can be submitted for certain container types. More details on container types can be found at [link].")]
        public List<Container>? Containers { get; set; }

        /// <summary>
        /// \"Pickup mode\nfalse = Pickup by DSV, \nTrue = Cargo handover to DSV at Warehouse or Terminal \n\"Drop Off\" service is available in Shippers country and product mode is either \"Air\", \"Sea\" or \"Rail\"
        /// </summary>
        [Description("\"Pickup mode\nfalse = Pickup by DSV, \nTrue = Cargo handover to DSV at Warehouse or Terminal \n\"Drop Off\" service is available in Shippers country and product mode is either \"Air\", \"Sea\" or \"Rail\"")]
        [Example(false)]
        public bool? DropOff { get; set; }

        /// <summary>
        /// Select the Delivery mode:\n\n- false = Delivery by DSV\n- true = Cargo handover by DSV\n(dropOff becomes mandatory when \"Handover\" service is available in Shippers country and product is either \"AIR\", \"SEA\" or \"RAIL\")
        /// </summary>
        [Description("Select the Delivery mode:\n\n- false = Delivery by DSV\n- true = Cargo handover by DSV\n(dropOff becomes mandatory when \"Handover\" service is available in Shippers country and product is either \"AIR\", \"SEA\" or \"RAIL\")")]
        [Example(false)]
        public bool? Handover { get; set; }
    }
}
