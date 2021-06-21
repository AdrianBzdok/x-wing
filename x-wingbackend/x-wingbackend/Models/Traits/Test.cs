using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x_wingbackend.Interfaces;

namespace x_wingbackend.Models.Traits
{
    public class Test : ITrait
    {
        public void Rules(Table table, int input)
        {
            if (true) { };
        }
        public Test(){
        }
    }
}
