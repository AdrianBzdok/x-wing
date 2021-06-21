using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x_wingbackend.Interfaces;

namespace x_wingbackend.Models.Traits
{
    public class Attack : ITrait
    {
        public int a { get; set; }
        public void Rules(Table table, int input)
        {
            if (true) { };
        }
        public Attack(int a = 0){
        this.a = a;
        }
    }
}
