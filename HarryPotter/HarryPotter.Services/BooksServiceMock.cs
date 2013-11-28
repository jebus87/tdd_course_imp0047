using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarryPotter.Domain;

namespace HarryPotter.Services
{
    public class BooksServiceMock: IBooksService
    {
        public IList<Book> GetAll()
        {
            IList<Book> allBook = new List<Book>();
            Author author = new Author() { Id = 1, Name = "Author name" };
            allBook.Add(new Book() { Id = 1, Name = "Book 01", Author = author, Price = 10 });
            allBook.Add(new Book() { Id = 2, Name = "Book 02", Author = author, Price = 10 });
            allBook.Add(new Book() { Id = 3, Name = "Book 03", Author = author, Price = 10 });
            allBook.Add(new Book() { Id = 4, Name = "Book 04", Author = author, Price = 10 });
            allBook.Add(new Book() { Id = 5, Name = "Book 05", Author = author, Price = 10 });
            return allBook;
        }
    }
}
