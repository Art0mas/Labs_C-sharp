using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Task4
{
    internal class OrderManager
    {
        OrderStorage orderStorage = new OrderStorage();
        public void Run()
        {
            AddOrder();
            ShowOrder();
        }

        public void AddOrder()
        {
            Order order = new Order { Id = 1, Status = OrderStatus.Processing};
            orderStorage.Save(order);
        }
        public void ShowOrder()
        {
            Order order = orderStorage.Load();
            Console.WriteLine($"Id: {order.Id}, Status: {order.Status}");
            
        }
    }
}
