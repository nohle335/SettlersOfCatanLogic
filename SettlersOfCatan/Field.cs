using SettlersOfCatan.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    public class Field
    {
        public FieldType ResourceType { get; set; }
        public int Number { get; set; }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid[] Buildings { get; set; }
        public Guid[] Connectors { get; set; }
        public (int Row, int Column) Position { get; set; }

        public Field(FieldType resourceType, int number, Guid id, string name = "", string description = "")
        {
            ResourceType = resourceType;
            Number = number;
            ID = id;
            Name = name;
            Description = description;
            Buildings = new Guid[3];
            Connectors = new Guid[6];
        }
    }
}