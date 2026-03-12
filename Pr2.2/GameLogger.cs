using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2._2
{
    internal class GameLogger
    {
        public void Log(object? sender, HealthChangeEventArgs e)
        {
            Console.WriteLine($"[Log: Отримано {e.Damage} од. урону, Залишилось {e.CurrentHealth} НР]");
        }
    }
}
