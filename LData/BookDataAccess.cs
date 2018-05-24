using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LData
{
    public class BookDataAccess : IBookDataAccess
    {
        private LibraryDBContext context;

        public BookDataAccess(LibraryDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            
                return this.context.Books.ToList();
            

        }
        public IEnumerable<Book> getSearch(string key)
        {
            return this.context.Books.Where(x => x.Name.Contains(key) || x.Authors.Contains(key)).ToList();
        
        }

        public Book Get(int id)
        {
            
                return this.context.Books.SingleOrDefault(x => x.ID == id);
            
        }
        public int TotalCopies()
        {

            return this.context.Books.Sum(x => x.Copy);

        }

        public int Insert(Book book)
        {
            this.context.Books.Add(book);
            return this.context.SaveChanges();
        }

        public int Update(Book book)
        {
            Book bk = this.context.Books.SingleOrDefault(x => x.ID == book.ID);
            bk.Name = book.Name;
            bk.Authors = book.Authors;
            bk.Category = book.Category;
            bk.Desk = book.Desk;
            bk.Copy = book.Copy;
            bk.Issuable = book.Issuable;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Book bk = this.context.Books.SingleOrDefault(x => x.ID == id);
            this.context.Books.Remove(bk);

            return this.context.SaveChanges();
        }
    }
}
