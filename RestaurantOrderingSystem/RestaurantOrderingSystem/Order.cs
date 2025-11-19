using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public enum Status
    {
        New,
        InProgress,
        Ready,
        Paid
    }
    public class Order
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public Status Status { get; private set;}
        public decimal Sum { get; private set; }

        private int _tableNumber;
        public int TableNumber
        {
            get { return _tableNumber; }
            private set 
            {
                if(value <= 0)
                {
                    Console.WriteLine("\nУВАГА! Ви намагаєтесь вказати номер столика менше нуля. " +
                        "Замовлення буде перенаправлено до столика 0");
                    return;
                }
                _tableNumber = value;
            }
        }
        private List<Menu> _orderItem = new List<Menu>();
        public Order(int tableNumber)
        {
            TableNumber = tableNumber;
            Id = _nextId++;
            Status = Status.New;
            Console.WriteLine($"\nСтворено нове замовлення #{Id} для столика №{TableNumber}");
        }
        public void AddMenuItem(Menu menuItem)
        {
            _orderItem.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} додано до замовлення");
        }
        public void RemoveMenuItem(Menu menuItem)
        {
            _orderItem.Remove(menuItem);
            Console.WriteLine($"{menuItem.Name} вилучено із замовлення");
        }
        public void CalculateOrder()
        {
            decimal sum = 0;
            foreach(var menuItem in _orderItem)
            {
                sum += menuItem.Price;
            }
            Console.WriteLine($"Сума до сплати: {sum} грн");
            Sum = sum;
        }
        public void StatusOfOrder()
        {
            if (Status == Status.New) 
            {
                Console.Write($"\nЗамовлення прийнято( |"); 
                foreach(var menuItem in _orderItem) Console.Write($"{menuItem.Name}|");
                Console.Write($" )\nСтатус оновлено: {Status}\n");
                Status = Status.InProgress;
            }
            if (Status == Status.InProgress) 
            {
                Console.WriteLine($"Статус оновлено: {Status}");
                Status = Status.Ready;
            }
            if (Status == Status.Ready) 
            {
                Console.WriteLine($"Статус оновлено: {Status}");
                Status = Status.Paid;
            } 
            if(Status == Status.Paid) Console.WriteLine($"Статус оновлено: {Status}\n");
        }

        public void PrintOrder()
        {

            Console.Write($"ID: {this.Id} | Стіл: {this.TableNumber} | Меню: ");
            foreach(var menuItem in _orderItem)
            {
                Console.Write($"{menuItem.Name}, ");
            }
            Console.Write($"Сума: {this.Sum} грн | Статус: {this.Status}");
        }
        
    }
}
