using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Services
{
    public class OrderService
    {
        private IRepository<Order> _repository;
        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task AddOrderAsync(Order order)
        {
            if(order.BookIds == null || order.BookIds.Count == 0)
            {
                throw new ArgumentException("Неможливо створити замовлення без книг.");
            }
            await _repository.AddAsync(order);
        }
    }
}
