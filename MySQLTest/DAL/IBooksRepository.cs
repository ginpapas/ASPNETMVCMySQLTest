using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQLTest.Models;

namespace MySQLTest.DAL
{
    public interface IBooksRepository : IDisposable

    {

        IQueryable<Book> FindBooks();

        Task<Book> GetBookAsync(int id);

        Book AddBook(Book book);

        void UpdateBook(Book book);

        void DeleteBook(int id);


        Task SaveAsync();

    }
}
