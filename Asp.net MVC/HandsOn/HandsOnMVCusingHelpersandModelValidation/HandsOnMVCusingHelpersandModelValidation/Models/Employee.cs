using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCusingHelpersandModelValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Enter Id")]
        [DataType(DataType.Text)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Eid { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Ename { get; set; }
        public string Gender { get; set; }
        [Range(minimum:23,maximum:29,ErrorMessage ="Invalid Age")]
      
        public int Age { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime JoinDate { get; set; }
        public string Desig { get; set; }
        [EmailAddress(ErrorMessage ="Invalid EMailId")]

       
        public string Email { get; set; }
        [RegularExpression("[6789][0-9]{9}",ErrorMessage ="Invalid Mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [RegularExpression("[a-zA-Z0-9]{6}",ErrorMessage ="Password should have 6 chars")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}
