using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class MenuManager
    {
        private List<Menu> menu = new List<Menu>();
        public void AddMenuItem(Menu menuitem)
        {
            menu.Add(menuitem);
        }
        public List<Menu> GetAllMenu()
        {
            return menu;
        }
        public void PrintMenu()
        {
            List<Menu> first_menu = new List<Menu>();
            List<Menu> second_menu = new List<Menu>();
            List<Menu> dessert_menu = new List<Menu>();
            List<Menu> alcohol_drink = new List<Menu>();
            List<Menu> non_alcohol_drink = new List<Menu>();
            foreach (var item in menu)
            {
                if (item is IEatable eatableItem)
                {
                    if (eatableItem.Type == TypeOfDish.First) first_menu.Add((Menu)eatableItem);
                    else if (eatableItem.Type == TypeOfDish.Second) second_menu.Add((Menu)eatableItem);
                    else dessert_menu.Add((Menu)eatableItem);
                }
                else if (item is IDrinkable drinkableItem)
                {
                    if (drinkableItem.IsAlcohol) alcohol_drink.Add((Menu)drinkableItem);
                    else non_alcohol_drink.Add((Menu)drinkableItem);
                }
            }
            Console.WriteLine("============ МЕНЮ РЕСТОРАНУ ============");
            Console.WriteLine("\n Перші страви");
            foreach (var item in first_menu)
            {
                Console.Write("\t");
                item.PrintStatus();
            }
            Console.WriteLine("\n Другі страви");
            foreach (var item in second_menu)
            {
                Console.Write("\t");
                item.PrintStatus();
            }
            Console.WriteLine("\n Безалкогольні напої");
            foreach (var item in non_alcohol_drink)
            {
                Console.Write("\t");
                item.PrintStatus();
            }
            Console.WriteLine("\n Алкогольні напої");
            foreach (var item in alcohol_drink)
            {
                Console.Write("\t");
                item.PrintStatus();
            }
            Console.WriteLine("\n Десерти");
            foreach (var item in dessert_menu)
            {
                Console.Write("\t");
                item.PrintStatus();
            }
        }
    }
}
