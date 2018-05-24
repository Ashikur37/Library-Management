using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
using LData;
namespace LService
{
    public class    DeskService : IDeskService
    {
        private IDeskDataAccess data;

        public DeskService(IDeskDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Desk> GetAll()
        {
            return this.data.GetAll();
        }

        public Desk Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Desk desk)
        {
            return this.data.Insert(desk);
        }

        public int Update(Desk desk)
        {
            return this.data.Update(desk);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
