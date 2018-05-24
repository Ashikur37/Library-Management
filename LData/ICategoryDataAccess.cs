using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
namespace LData
{
  public  interface ICategoryDataAccess
    {
        IEnumerable<Category> GetAll();
        Category Get(int id);

    }
}
