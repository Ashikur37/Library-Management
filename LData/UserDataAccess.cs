using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LData
{
    public class UserDataAccess : IUserDataAccess
    {
        private LibraryDBContext context;

        public UserDataAccess(LibraryDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
        {

            return this.context.Users.ToList();


        }

        public User Get(int id)
        {

            return this.context.Users.SingleOrDefault(x => x.ID == id);

        }
        public User GetByPass(string un,string pass)
        {
            if (this.context.Users.Where(x => x.User_Name == un && x.Password == pass).Count() == 1)
                return this.context.Users.SingleOrDefault(x => x.User_Name == un && x.Password == pass);
            else
            {
                User u = new User();
                u.Type = 10;
                return u;
            }

        }

        public int Insert(User user)
        {
            this.context.Users.Add(user);
            return this.context.SaveChanges();
        }

        public int Update(User user)
        {
            User u = this.context.Users.SingleOrDefault(x => x.ID == user.ID);
            u.Email = user.Email;
            u.Mobile = user.Mobile;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            User u = this.context.Users.SingleOrDefault(x => x.ID == id);
            this.context.Users.Remove(u);

            return this.context.SaveChanges();
        }
    }
}
