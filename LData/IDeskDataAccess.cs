using LEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LData
{
    public interface IDeskDataAccess
    {
        IEnumerable<Desk> GetAll();
        Desk Get(int id);
        int Insert(Desk dsek);
        int Update(Desk desk);
        int Delete(int id);
    }
}
