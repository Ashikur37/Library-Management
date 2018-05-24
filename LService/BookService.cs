using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
using LData;
namespace LService
{
   public class BookService : IBookService
    {
        private IBookDataAccess data;

        public BookService(IBookDataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<Book> getSearch(string key)
        {
            return this.data.getSearch(key);
        }

        public IEnumerable<Book> GetAll()
        {
            return this.data.GetAll();
        }

        public Book Get(int id)
        {
            return this.data.Get(id);
        }
        public int TotalCopies()
        {
        return this.data.TotalCopies();
        
        }
        public int Insert(Book book)
        {
            return this.data.Insert(book);
        }

        public int Update(Book book)
        {
            return this.data.Update(book);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
