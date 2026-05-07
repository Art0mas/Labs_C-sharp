using System;
using System.Windows.Forms;
using AsyncDataLibrary.Models;
using AsyncDataLibrary.Infrastructure;
using AsyncDataLibrary.Repositories;
using AsyncDataLibrary.Services;

namespace AsyncDataWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly BookService _bookService;
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        public Form1()
        {
            InitializeComponent();

            var serializer = new JsonDataSerializer();
            var fileProvider = new FileStorageProvider();
            var bookRepository = new JsonRepository<Book>("books.json", serializer, fileProvider);
            var userRepository = new JsonRepository<User>("users.json", serializer, fileProvider);
            var orderRepository = new JsonRepository<Order>("orders.json", serializer, fileProvider);

            _bookService = new BookService(bookRepository);
            _userService = new UserService(userRepository);
            _orderService = new OrderService(orderRepository);

        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            btnAddBook.Enabled = false;

            try
            {
                var newBook = new Book
                {
                    Name = txtName.Text,
                    Author = txtAuthor.Text
                };

                await _bookService.AddBookAsync(newBook);

                MessageBox.Show("Книгу успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear();
                txtAuthor.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnAddBook.Enabled = true;
            }
        }

        private async void btnLoadBooks_Click(object sender, EventArgs e)
        {
            try
            {
                var books = await _bookService.GetBooksAsync();

                listBooks.Items.Clear();

                foreach (var book in books)
                {
                    listBooks.Items.Add($"ID: {book.Id} | {book.Name} (Автор: {book.Author})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити дані: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            btnAddUser.Enabled = false;

            try
            {
                var newUser = new User
                {
                    Name = txtNameUser.Text
                };

                await _userService.AddUserAsync(newUser);

                MessageBox.Show("Користувача успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNameUser.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnAddUser.Enabled = true;
            }
        }

        private async void btnLoadUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var users = await _userService.GetUsersAsync();

                listUsers.Items.Clear();

                foreach (var user in users)
                {
                    listUsers.Items.Add($"ID: {user.Id} | {user.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити дані: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddOrder_Click(object sender, EventArgs e)
        {
            btnAddOrder.Enabled = false;
            try
            {
                var bookIds = txtBookIds.Text
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(id => int.Parse(id.Trim()))
                    .ToList();

                var newOrder = new Order
                {
                    UserId = (int)numUserId.Value,
                    BookIds = bookIds,
                    Price = numPrice.Value
                };

                await _orderService.AddOrderAsync(newOrder);

                MessageBox.Show("Замовлення успішно створено!", "Успіх");
                txtBookIds.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, вводьте ID книг через кому (наприклад: 1, 2, 3)", "Помилка формату");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
            finally
            {
                btnAddOrder.Enabled = true;
            }
        }

        private async void btnLoadOrders_Click_1(object sender, EventArgs e)
        {
            try
            {
                var orders = await _orderService.GetOrdersAsync();
                listOrders.Items.Clear();

                foreach (var order in orders)
                {
                    string books = string.Join(", ", order.BookIds);
                    listOrders.Items.Add($"Замовлення #{order.Id} | Користувач: {order.UserId} | Книги: [{books}] | Сума: {order.Price} грн");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoadBooks.PerformClick();
            btnLoadUsers.PerformClick();
            btnLoadOrders.PerformClick();
        }
    }
}
