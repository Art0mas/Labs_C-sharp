using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Services
{
    public class UserService
    {
        private IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task AddUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("Ім'я користувача не може бути порожнім.");

            await _repository.AddAsync(user);
        }
    }
}
