using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Guid> Fields { get; set; }
        public List<Guid> Connectors { get; set; }
        public List<Guid> Buildings { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Map(int height, int width, string name = "", string description = "")
        {
            Height = height;
            Width = width;
            Fields = new List<Guid>();
            Connectors = new List<Guid>();
            Buildings = new List<Guid>();
            Name = name;
            Description = description;
        }
    }
}