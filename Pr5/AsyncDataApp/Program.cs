using System;
using System.Threading.Tasks;
using AsyncDataLibrary.Models;
using AsyncDataLibrary.Infrastructure;
using AsyncDataLibrary.Repositories;
using AsyncDataLibrary.Services;

namespace AsyncDataApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Починаємо перевірку...");

            var serializer = new JsonDataSerializer();
            var fileProvider = new FileStorageProvider();

            var bookRepository = new JsonRepository<Book>("books.json", serializer, fileProvider);
            var userRepository = new JsonRepository<User>("users.json", serializer, fileProvider);
            var orderRepository = new JsonRepository<Order>("orders.json", serializer, fileProvider);

            var bookService = new BookService(bookRepository);
            var userService = new UserService(userRepository);
            var orderService = new OrderService(orderRepository);

            try
            {
                /*var myBook1 = new Book{Id = 1, Name = "CLR via C#", Author = "Джеффрі Ріхтер"};
                var myBook2 = new Book {Id = 2, Name = "Harry Potter", Author = "Джоан Роулінг"};

                var myUser1 = new User { Id = 1, Name = "Jhon" };
                var myUser2 = new User { Id = 2, Name = "Eric" };

                var myOrder1 = new Order { Id = 1, BookIds = new List<int> {1, 2}, UserId = 2, Price = 1000 };
                var myOrder2 = new Order { Id = 2, BookIds = new List<int> {2}, UserId = 1, Price = 400 };

                Console.WriteLine("Зберігаємо дані у файл...");

                await bookService.AddBookAsync(myBook1);
                await bookService.AddBookAsync(myBook2);

                await userService.AddUserAsync(myUser1);
                await userService.AddUserAsync(myUser2);

                await orderService.AddOrderAsync(myOrder1);
                await orderService.AddOrderAsync(myOrder2);

                Console.WriteLine("Успіх!");*/

                var allBooks = await bookService.GetBooksAsync();
                Console.WriteLine($"\nКількість книг у файлі: {allBooks.Count}");
                foreach (var b in allBooks)
                {
                    Console.WriteLine($"- {b.Id} ({b.Name}, {b.Author})");
                }

                var allUsers = await userService.GetUsersAsync();
                Console.WriteLine($"\nКількість користувачів у файлі: {allUsers.Count}");
                foreach (var u in allUsers)
                {
                    Console.WriteLine($"- {u.Id} ({u.Name})");
                }

                var allOrders = await orderService.GetOrdersAsync();
                Console.WriteLine($"\nКількість замовлень у файлі: {allOrders.Count}");
                foreach (var o in allOrders)
                {
                    Console.WriteLine($"- {o.Id} (({o.BookIds.Count}), {o.UserId}, {o.Price})");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Сталася помилка: {ex.Message}");
                Console.ResetColor();
            }

        }
    }
}
