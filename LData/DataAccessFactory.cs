using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LData
{
    public abstract class DataAccessFactory
    {
        

        public static IBookDataAccess GetBookDataAccess()
        {
            return new BookDataAccess(new LibraryDBContext());
        }
        public static IUserDataAccess GetUserDataAccess()
        {
            return new UserDataAccess(new LibraryDBContext());
        }
        public static ICategoryDataAccess GetCategoryDataAccess()
        {
            return new CategoryDataAccess(new LibraryDBContext());
        }
        public static IDeskDataAccess GetDeskDataAccess()
        {
            return new DeskDataAccess(new LibraryDBContext());
        }
        public static IBorrowDataAccess GetBorrowDataAccess()
        {
            return new BorrowDataAccess(new LibraryDBContext());
        }

       
    }
}
