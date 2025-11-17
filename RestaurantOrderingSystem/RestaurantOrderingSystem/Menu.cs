using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public abstract class Menu: IPriceable
    {
        public string Name {  get; protected set; }
        public decimal Price {  get; protected set; }
        public int Volume {  get; protected set; }


        public Menu(string name, int volume, decimal price)
        {
            Name = name;
            Volume = volume;
            Price = price;
        }
        public abstract void PrintStatus();
    }
}
