using LData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LService
{
    public abstract class ServiceFactory
    {
        

        public static IBookService GetBookService()
        {
            return new BookService(DataAccessFactory.GetBookDataAccess());
        }
        public static IUserService GetUserService()
        {
            return new UserService(DataAccessFactory.GetUserDataAccess());
        }
        public static ICategoryService GetCategoryService()
        {
            return new CategoryService(DataAccessFactory.GetCategoryDataAccess());
        }
        public static IDeskService GetDeskService()
        {
            return new DeskService(DataAccessFactory.GetDeskDataAccess());
        }
        public static IBorrowService GetBorrowService()
        {
            return new BorrowService(DataAccessFactory.GetBorrowDataAccess());
        }

    }
}
