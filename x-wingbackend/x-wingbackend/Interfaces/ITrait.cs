using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x_wingbackend.Models;

namespace x_wingbackend.Interfaces
{
    public interface ITrait
    {
        void Rules(Table table = null, int input = 0);
    }
}
