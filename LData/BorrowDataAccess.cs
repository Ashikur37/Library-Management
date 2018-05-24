using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LData
{
    public class BorrowDataAccess : IBorrowDataAccess
    {
        private LibraryDBContext context;

        public BorrowDataAccess(LibraryDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Borrow> GetAll()
        {

            return this.context.Borrows.ToList();


        }


        public Borrow Get(int id)
        {

            return this.context.Borrows.SingleOrDefault(x => x.ID == id);

        }
       public IEnumerable<Borrow> GetByBorrower(int id)
        {
            return this.context.Borrows.Where(x => x.Borrower == id).ToList();
        
        }

        public int Insert(Borrow borrow)
        {
            this.context.Borrows.Add(borrow);
            return this.context.SaveChanges();
        }

        public int Update(Borrow borrow)
        {
            Borrow br = this.context.Borrows.SingleOrDefault(x => x.ID == borrow.ID);
            br.Status = borrow.Status;
            br.Rdate = borrow.Rdate;

            return this.context.SaveChanges();
        }

       
    }
}
