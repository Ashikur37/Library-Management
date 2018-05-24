using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEntity
{
    public class Borrow
    {
        public int ID { get; set; }
        public int Book { get; set; }
        public int Borrower { get; set; }
       
        public DateTime Bdate { get; set; }
       
        public DateTime Rdate { get; set; }
        public int Status { get; set; }
      
        public DateTime Edate { get; set; }

        // public IEnumerable<Employee> Employees { get; set; }
    }
}
