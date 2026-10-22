using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    public class Dice
    {
        public int Number {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Dice(string name = "", string description = "")
        {
            Number = 6;
            Name = name;
            Description = description;
        }

        public void Roll()
        {
            Number = new Random().Next(1, 7);
        }
    }
}
