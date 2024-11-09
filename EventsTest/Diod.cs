using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    internal class Diod : ILighter
    {
        public void On()
        {
            Console.WriteLine("Diod is on");
        }

        public void Off()
        {
            Console.WriteLine("Diod is off");
        }
    }
}
