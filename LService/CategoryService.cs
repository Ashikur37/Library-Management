using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;
using LData;
namespace LService
{
    class CategoryService: ICategoryService
    {
        private ICategoryDataAccess data;

        public CategoryService(ICategoryDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Category> GetAll()
        {
            return this.data.GetAll();
        }

        public Category Get(int id)
        {
            return this.data.Get(id);
        }
    }
}
