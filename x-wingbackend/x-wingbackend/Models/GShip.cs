using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace x_wingbackend.Models
{
    public class GShip
    {
        public int Id { get; set; }
        public Ship Ship { get; set; }
        public Player Player { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Rotate { get; set; }
    }
}
