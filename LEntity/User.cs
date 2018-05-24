using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LEntity
{
   public class User
    {
        public int ID { get; set; }
       [Required(ErrorMessage="This Field is Required")]
        public string User_Name { get; set; }
       [Required(ErrorMessage = "This Field is Required")]
        public string Email { get; set; }
       [Required(ErrorMessage = "This Field is Required")]
        public string Mobile { get; set; }
       [Required(ErrorMessage = "This Field is Required")]
        public string Password { get; set; }
       [Required(ErrorMessage = "This Field is Required")]
        public int Type { get; set; }
        
    }
}
