using System.Text;

namespace RestaurantOrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MenuManager menuManager = new MenuManager();
            OrderManager orderManager = new OrderManager();

            Dish dish1 = new Dish("Борщ", 300, 150m, TypeOfDish.First);
            Dish dish2 = new Dish("Пюре з котлетою", 350, 230m, TypeOfDish.Second);
            Dish dish3 = new Dish("Макарони з сиром", 300, 200m, TypeOfDish.Second);
            Dish dish4 = new Dish("Грибний крем-суп", 300, 180m, TypeOfDish.First);
            Dish dish5 = new Dish("Плов по-грузинськи", 350, 250m, TypeOfDish.Second);
            Dish dish6 = new Dish("Бограч", 350, 300m, TypeOfDish.First);
            Dish dish7 = new Dish("Торт Київський", 350, 200m, TypeOfDish.Dessert);
            Dish dish8 = new Dish("Шоколадний кекс", 300, 160m, TypeOfDish.Dessert);
            Drink drink1 = new Drink("Чай чорний", 100, 40m, false);
            Drink drink2 = new Drink("Молочний коктейль", 250, 75m, false);
            Drink drink3 = new Drink("Мохіто", 330, 110m, true);
            Drink drink4 = new Drink("Пиво світле нефільтроване", 500, 80m, true);
            Drink drink5 = new Drink("Кава з молоком", 100, 60m, false);
            Drink drink6 = new Drink("Вино червоне сухе", 250, 150m, true);

            menuManager.AddMenuItem(dish1);
            menuManager.AddMenuItem(dish2);
            menuManager.AddMenuItem(dish3);
            menuManager.AddMenuItem(dish4);
            menuManager.AddMenuItem(dish5);
            menuManager.AddMenuItem(dish6);
            menuManager.AddMenuItem(dish7);
            menuManager.AddMenuItem(dish8);
            menuManager.AddMenuItem(drink1);
            menuManager.AddMenuItem(drink2);
            menuManager.AddMenuItem(drink3);
            menuManager.AddMenuItem(drink4);
            menuManager.AddMenuItem(drink5);
            menuManager.AddMenuItem(drink6);
            menuManager.PrintMenu();

            Order order1 = new Order(3);
            order1.AddMenuItem(drink2);
            order1.AddMenuItem(dish3);
            order1.AddMenuItem(dish4);
            order1.RemoveMenuItem(dish3);
            order1.CalculateOrder();
            order1.StatusOfOrder();
            orderManager.AddOrder(order1);
            orderManager.AddOrderMenu(dish1);

            Order order2 = new Order(5);
            orderManager.AddOrder(order2);
            order2.AddMenuItem(drink5);
            order2.AddMenuItem(dish3);
            order2.CalculateOrder();
            order2.StatusOfOrder();

            orderManager.PrintAllOrders();

            Search search = new Search(menuManager.GetAllMenu(), orderManager.GetOrders());
            search.FindByName("Борщ");
            search.FindByName("Суп гороховий");
            search.FindByType(TypeOfDish.First);
            search.FindByType(TypeOfDish.Dessert);
            search.FindById(1);

        }
    }
}
