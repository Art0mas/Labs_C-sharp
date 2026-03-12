using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_1
{
    internal class Display
    {
        public void DisplayTemperature(object? sender, TemperatureEventArgs e)
        {
            Console.WriteLine($"Температура у примiщеннi: {e.Temperature}");
        }
    }
}
