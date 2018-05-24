using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
namespace LService
{
  public  interface IUserService
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        User GetByPass(string un, string pass);
        int Insert(User user);
        int Update(User user);
        int Delete(int id);
    }
}
