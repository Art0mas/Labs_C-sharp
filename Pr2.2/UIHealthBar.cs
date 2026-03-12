using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2._2
{
    internal class UIHealthBar
    {
        public void ShowHealthBar(object? sender, HealthChangeEventArgs e)
        {
            Console.WriteLine($"Гравець має {e.CurrentHealth} НР");
        }
        public void ShowDeath(object? sender, HealthChangeEventArgs e)
        {
            Console.WriteLine($"Гравець помер");
        }
    }
}
