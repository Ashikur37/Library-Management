using LEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> getSearch(string key);
        Book Get(int id);
        int Insert(Book book);
        int TotalCopies();
        int Update(Book book);
        int Delete(int id);
    }
}
