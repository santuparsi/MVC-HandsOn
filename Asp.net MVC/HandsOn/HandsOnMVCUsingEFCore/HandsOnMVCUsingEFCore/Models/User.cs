using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCUsingEFCore.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Username is Required")]
        [StringLength(20)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(20)]
        public string Email { get; set; }
        [Required(ErrorMessage = "MobileNo is Required")]
        [StringLength(20)]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [StringLength(20)]
        public string Country { get; set; }
        public string Password { get; set; }
    }
}
