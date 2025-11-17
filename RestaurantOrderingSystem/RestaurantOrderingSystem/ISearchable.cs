using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public interface ISearchable
    {
        List<Menu> FindByName(string name);
        List<Dish> FindByType(TypeOfDish type);
        List<Order> FindById(int id);

    }
}
