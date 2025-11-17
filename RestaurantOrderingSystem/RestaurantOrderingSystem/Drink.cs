using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Drink : Menu, IDrinkable
    {
        public bool IsAlcohol { get; private set; }
        public Drink(string name, int volume, decimal price, bool isAlcohol) : base(name, volume, price)
        {
            IsAlcohol = isAlcohol;
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"- {Name}({Volume} мл) - {Price} грн");
        }
    }
}
