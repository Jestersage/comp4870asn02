using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class AbuserRelationship
    {
        public int AbuserRelationshipId { get; set; }
        //Acquaintance; Bad Date; DNA; Ex-Partner; Friend;
        //Multiple Perps; N/A; Other; Other Familial; Parent; Partner; Sibling; Stranger
        public string Type { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}