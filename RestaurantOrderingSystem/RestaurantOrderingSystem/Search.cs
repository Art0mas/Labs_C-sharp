using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestaurantOrderingSystem
{
    public class Search : ISearchable
    {
        private List<Menu> menu;
        private List<Order> orders;
        public Search(List<Menu> menu, List<Order> orders)
        {
            this.menu = menu;
            this.orders = orders;
        }

        public List<Menu> FindByName(string name)
        {
            List<Menu> needMenuItem = new List<Menu>();
            foreach (var item in menu)
            {
                if (item.Name == name) needMenuItem.Add(item);
            }
            if (needMenuItem.Count == 0)
            {
                Console.WriteLine($"Позицію '{name}' не знайдено");
            }
            else
            {
                foreach (var item in needMenuItem)
                {
                    Console.Write("\nПозицію знайдено: ");
                    item.PrintStatus(); Console.WriteLine();
                }
            }
            return needMenuItem;
        }

        public List<Dish> FindByType(TypeOfDish type)
        {
            List<Menu> menuItem = new List<Menu>();
            List<Dish> needDishes = new List<Dish>();

            foreach(var item in menu)
            {
                if(item is IEatable eatableItem)
                {
                    needDishes.Add((Dish)eatableItem);
                }
            }
            
            foreach (var item in needDishes)
            {
                if (item.Type == type) menuItem.Add(item);
            }
            if (menuItem.Count == 0)
            {
                Console.WriteLine($"{type} не знайдено\n");
            }
            else
            {
                Console.WriteLine($"\nЗнайдено {menuItem.Count} позиції типу страви {type}: ");
                foreach (var item in menuItem)
                {
                    item.PrintStatus(); 
                }
            }
            return needDishes;
        }
        public List<Order> FindById(int id)
        {
            List<Order> needOrder = new List<Order>();
            foreach (var order in orders)
            {
                if (order.Id == id) needOrder.Add(order);
            }
            if (needOrder.Count == 0)
            {
                Console.WriteLine($"\nЗамовлення #{id} не знайдено");
            }
            else
            {
                Console.WriteLine();
                foreach (var item in needOrder)
                {
                    item.PrintOrder(); Console.WriteLine();
                }
            }
            return needOrder;
        }
    }
}
