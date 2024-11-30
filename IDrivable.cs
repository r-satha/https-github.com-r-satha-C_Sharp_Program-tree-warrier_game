using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
   interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void move();
        void stop();

    }
}
