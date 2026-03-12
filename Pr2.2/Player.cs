using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2._2
{
    internal class Player
    {
        public event EventHandler<HealthChangeEventArgs>? HealthChanged;
        public event EventHandler<HealthChangeEventArgs>? PlayerDied;

        private int _health = 100;

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0) _health = 0;
            
            Console.WriteLine($"Гравець отримав {damage} од. урону");
            HealthChanged?.Invoke( this, new HealthChangeEventArgs { CurrentHealth = _health, Damage = damage });

            if (_health <= 0)
            {
                _health = 0;
                PlayerDied?.Invoke(this, new HealthChangeEventArgs { CurrentHealth = 0, Damage = damage });
            }

        }

    }
}
