using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettlersOfCatan.Enums;

namespace SettlersOfCatan
{
    public class Construction
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ConstructionType Type { get; set; }
        public Guid OwnerID { get; set; }
        public Position Position { get; set; }

        public Construction(Guid iD, ConstructionType type, Guid ownerID, Position position, string name = "", string description = "")
        {
            ID = iD;
            Name = name;
            Description = description;
            Type = type;
            OwnerID = ownerID;
            Position = position;
        }
    }
}