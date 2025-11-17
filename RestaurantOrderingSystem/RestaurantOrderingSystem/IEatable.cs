using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public enum TypeOfDish
    {
        First,
        Second,
        Dessert
    }
    public interface IEatable
    {
        TypeOfDish Type {  get; } 
    }
}
