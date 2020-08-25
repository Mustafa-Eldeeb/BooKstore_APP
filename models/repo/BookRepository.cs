using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.models.repo
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
               new Book
               {
                   Id =1, Title ="asp book", Description ="No description"
               },
               new Book
               {
                   Id =2, Title="javascript", Description="No description"
               },
               new Book
               {
                   Id =3, Title ="c++ book", Description ="No description"
               },
               new Book
               {
                   Id =4, Title ="python book", Description ="No description"
               },
            };
        }
        public void add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id); //books.SingleOrDefault(b => b.Id == id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;        }

        public void Update(int id, Book newbook)
        {
            var book = Find(id); //books.SingleOrDefault(b => b.Id == id);
            book.Title = newbook.Title;
            book.Description = newbook.Description;
            book.Author = newbook.Author;
        }
    }
}
