using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class OrderManager
    {
        private List<Order> orders = new List<Order>();
        private List<Menu> menu = new List<Menu>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void AddOrderMenu(Menu menuItems)
        {
            menu.Add(menuItems);
        }
        public List<Order> GetOrders() 
        {
            return orders; 
        }
        public void PrintAllOrders()
        {
            Console.WriteLine("============ СПИСОК ЗАМОВЛЕНЬ ============");
            foreach (var order in orders) 
            {
                 Console.WriteLine($"ID: {order.Id} | Стіл: {order.TableNumber} | " +
                             $"Сума: {order.Sum} грн | Статус: {order.Status}");
            }
        }
    }
}
