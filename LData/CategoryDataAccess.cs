using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEntity;

namespace LData
{
    class CategoryDataAccess: ICategoryDataAccess 
    {
         private LibraryDBContext context;

        public CategoryDataAccess(LibraryDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetAll()
        {

            return this.context.Categories.ToList();
            

        }

        public Category Get(int id)
        {

            return this.context.Categories.SingleOrDefault(x => x.ID == id);
            
        }
    }
}

