using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LData
{
    public class DeskDataAccess : IDeskDataAccess
    {
        private LibraryDBContext context;

        public DeskDataAccess(LibraryDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Desk> GetAll()
        {

            return this.context.Desks.ToList();


        }

        public Desk Get(int id)
        {

            return this.context.Desks.SingleOrDefault(x => x.ID == id);

        }

        public int Insert(Desk desk)
        {
            this.context.Desks.Add(desk);
            return this.context.SaveChanges();
        }

        public int Update(Desk desk)
        {
            Desk dk = this.context.Desks.SingleOrDefault(x => x.ID == desk.ID);
            dk.Name = desk.Name;
            dk.Location = desk.Location;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Desk dk = this.context.Desks.SingleOrDefault(x => x.ID == id);
            this.context.Desks.Remove(dk);

            return this.context.SaveChanges();
        }
    }
}
