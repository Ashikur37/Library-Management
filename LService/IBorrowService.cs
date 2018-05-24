using LEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LService
{
    public interface IBorrowService
    {
        IEnumerable<Borrow> GetAll();
        IEnumerable<Borrow> GetByBorrower(int id);
        Borrow Get(int id);

        int Insert(Borrow borrow);
        int Update(Borrow borrow);
        
    }
}
