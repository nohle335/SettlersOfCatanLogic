using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettlersOfCatan.Enums;

namespace SettlersOfCatan
{
    public class Player
    {
        public Guid ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ResourceType> Resources { get; set; }
        public List<Guid> Buildings { get; set; }
        public List<Guid> Connectors { get; set; }

        public Player(Guid iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
            Resources = new List<ResourceType>();
            Buildings = new List<Guid>();
            Connectors = new List<Guid>();
        }
    }
}