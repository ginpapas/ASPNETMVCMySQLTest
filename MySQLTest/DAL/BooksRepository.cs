using System;
using System.Linq;
using System.Threading.Tasks;
using MySQLTest.Models;

namespace MySQLTest.DAL
{
    public class BooksRepository : IBooksRepository
    {
        private BooksContext _context;
        public BooksRepository()
        {
            _context = new BooksContext();
        }


        #region IBooksRepository メンバー

        public IQueryable<Book> FindBooks()
        {
            IQueryable<Book> query = _context.Books.AsNoTracking().OrderBy(k => k.Id);
            return query;
        }


        public Task<Book> GetBookAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Book AddBook(Book book)
        {
            return _context.Books.Add(book);
        }


        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }


        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        #endregion


        #region IDisposable メンバー


        private bool _disposed = false;
        /// <summary>

        /// リソースの開放を行います。

        /// </summary>

        public void Dispose()

        {

            Dispose(true);

            GC.SuppressFinalize(this);

        }


        /// <summary>

        /// リソースの開放を行います。

        /// </summary>

        /// <param name="disposing"></param>

        protected virtual void Dispose(bool disposing)

        {

            if (_disposed) return;


            _disposed = true;


            if (disposing)

            {

                // マネージ リソースの解放処理

            }

            // アンマネージ リソースの解放処理

            _context.Dispose();

        }


        #endregion


        /// <summary>

        /// デストラクタ

        /// </summary>

        ~BooksRepository()

        {

            Dispose(false);

        }

    }
}
