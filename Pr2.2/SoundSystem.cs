using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2._2
{
    internal class SoundSystem
    {
        public void PlayDamageSound(object? sender, HealthChangeEventArgs e)
        {
            if(e.CurrentHealth <= 20)
            {
                Console.WriteLine("[Звук критичного стану]");
                return;
            }
            else{
                Console.WriteLine("[Звук отримання урону]");
                return;
            }
        }
        public void PlayDeathSound(object? sender, HealthChangeEventArgs e)
        {
            Console.WriteLine("[Звук смерті]");
        }
    }
}
