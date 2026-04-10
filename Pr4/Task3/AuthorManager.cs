using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class AuthorManager
    {
        AuthorStorage authorStorage = new AuthorStorage();
        
        public void Run()
        {
            AddAuthor();
            ShowAuthor();
        }
        private void AddAuthor()
        {
            Author author = new Author { Name = "Леся Українка" };

            Book book1 = new Book { Title = "Василина", Author = author };
            Book book2 = new Book { Title = "Гімн", Author = author };

            author.Books.Add(book1);
            author.Books.Add(book2);

            authorStorage.Save(author);
        }
        private void ShowAuthor()
        {
            Author author = authorStorage.Load();
            Console.WriteLine(author.Name);
            foreach(var book in author.Books)
            {
                Console.WriteLine($"Назва: {book.Title}, Автор: {book.Author}");

            }
        }
    }
}
