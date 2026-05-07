using AsyncDataLibrary.Interfaces;
using AsyncDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataLibrary.Services
{
    public class BookService
    {
        private IRepository<Book> _repository;
        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public async Task<List<Book>> GetBooksAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task AddBookAsync(Book book)
        {
            if(string.IsNullOrWhiteSpace(book.Name) || string.IsNullOrWhiteSpace(book.Author))
                throw new ArgumentException("Книга повинна мати назву та автора.");

            await _repository.AddAsync(book);
        }
    }
}
