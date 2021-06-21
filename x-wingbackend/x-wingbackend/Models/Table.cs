using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum Phase { 
    ph0,
    ph1,
    ph2,
    ph3
}

namespace x_wingbackend.Models
{
    public class Table
{
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Phase Turn { get; set; }
        public GShip[] GShips { get; set; }

}
}