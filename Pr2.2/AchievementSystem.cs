using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2._2
{
    internal class AchievementSystem
    {
        private bool _firstDeathUnlocked = false;
        private bool _halfHealthUnlocked = false;
        public void AchievementMessage(object? sender, HealthChangeEventArgs e)
        {
            if(e.CurrentHealth <= 0 && _firstDeathUnlocked == false)
            {
                _firstDeathUnlocked = true;
                Console.WriteLine("Досягнення: First Death");
            }
            else if(e.CurrentHealth <= 50 && _halfHealthUnlocked == false)
            {
                _halfHealthUnlocked = true;
                Console.WriteLine("Досягнення: Half Health");
            }
        }
    }
}
