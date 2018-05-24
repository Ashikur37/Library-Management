using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LService
{
    public interface IDeskService
    {
        IEnumerable<Desk> GetAll();
        Desk Get(int id);
        int Insert(Desk desk);
        int Update(Desk desk);
        int Delete(int id);
    }
}
