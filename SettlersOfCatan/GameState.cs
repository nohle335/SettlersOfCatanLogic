using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan
{
    // everything about the game state is stored here
    public class GameState
    {
        public Map Map { get; set; }
        public Player[] Players { get; set; }
        public Dice[] Dices { get; set; }
        public Guid CurrentPlayer {  get; set; }
        public int NumberOfRounds { get; set; }
        public Robber Robber { get; set; }
    }
}
