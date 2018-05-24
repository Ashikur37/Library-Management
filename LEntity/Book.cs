using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEntity
{
    public class Book
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Category { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Authors { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Copy { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Desk { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Issuable { get; set; }

       // public IEnumerable<Employee> Employees { get; set; }
    }
}
