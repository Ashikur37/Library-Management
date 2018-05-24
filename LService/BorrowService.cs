using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
using LData;
namespace LService
{
    public class BorrowService : IBorrowService
    {
        private IBorrowDataAccess data;

        public BorrowService(IBorrowDataAccess data)
        {
            this.data = data;
        }
       

        public IEnumerable<Borrow> GetAll()
        {
            return this.data.GetAll();
        }
       public IEnumerable<Borrow> GetByBorrower(int id)
        {
            return this.data.GetByBorrower(id);
        }

        public Borrow Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Borrow borrow)
        {
            return this.data.Insert(borrow);
        }

        public int Update(Borrow borrow)
        {
            return this.data.Update(borrow);
        }

        
    }
}
