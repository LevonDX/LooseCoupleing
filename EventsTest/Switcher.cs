using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    internal class Switcher
    {
        private readonly ILighter _lighter;

        public Switcher(ILighter lighter)
        {
            _lighter = lighter;
        }

        public void SwitchOn()
        {
            _lighter.On();
        }


        public void SwitchOff()
        {
            _lighter.Off();
        }
    }
}
