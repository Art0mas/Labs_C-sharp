using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_1
{
    public class TemperatureEventArgs: EventArgs
    {
        public int Temperature { get; set; }
    }
}
