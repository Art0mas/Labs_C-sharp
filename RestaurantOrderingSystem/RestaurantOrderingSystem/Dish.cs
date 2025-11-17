using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Dish : Menu, IEatable
    {
        public TypeOfDish Type { get; private set; }

        public Dish(string name, int volume, decimal price, TypeOfDish type): base(name, volume, price)
        {
            Type = type;
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"- {Name}({Volume} г) - {Price} грн");
        }
       
    }
}
