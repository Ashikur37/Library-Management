using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LData;
using LEntity;
namespace LService
{
    class UserService: IUserService
    {
        private IUserDataAccess data;

        public UserService(IUserDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User> GetAll()
        {
            return this.data.GetAll();
        }

        public User Get(int id)
        {
            return this.data.Get(id);
        }
        public User GetByPass(String un,string pass)
        {
            return this.data.GetByPass(un,pass);
        }

        public int Insert(User user)
        {
            return this.data.Insert(user);
        }

        public int Update(User user)
        {
            return this.data.Update(user);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
