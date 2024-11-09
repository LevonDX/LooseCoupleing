using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest
{
    interface ILighter
    {
        public abstract void On();
        public abstract void Off();
    }
}