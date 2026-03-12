using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_1
{
    internal class SecuritySystem
    {
        public void SecuritySystemMessage(object? sender, TemperatureEventArgs e)
        {
            if(e.Temperature > 40)
            {
                Console.WriteLine("УВАГА! Ризик перегріву");
                return;
            }
            else if(e.Temperature < 5)
            {
                Console.WriteLine("УВАГА! Ризик замерзання системи");
            }
        }
    }
}
