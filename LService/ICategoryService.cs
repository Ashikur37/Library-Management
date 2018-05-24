using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
namespace LService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category Get(int id);
    }
}
