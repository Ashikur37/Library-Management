using System;
using LEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LData
{
   public class LibraryDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Borrow> Borrows{ get; set; }
        
    }
}
