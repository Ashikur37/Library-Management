using LEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LData
{
    public interface IBookDataAccess
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> getSearch(string key);
        Book Get(int id);
        int TotalCopies();
        int Insert(Book book);
        int Update(Book book);
        int Delete(int id);
    }
}
