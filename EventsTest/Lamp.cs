using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    internal class Lamp : ILighter
    {
        public void On()
        {
            Console.WriteLine("Lamp is on");
        }

        public void Off()
        {
            Console.WriteLine("Lamp is off");
        }
    }
}
