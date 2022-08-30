using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCusingStatemenagement.Models
{
    public class User
    {
       [Required(ErrorMessage ="Pls Enter Name")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Pls Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
