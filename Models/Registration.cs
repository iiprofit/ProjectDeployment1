using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ProjectDeployment1.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }
       
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Full Name")]
        public string UserFullName { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Blank field is not allow")]
        [DisplayName("Email Address")]
        public string UserEmailId { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Blank field is not allow")]
        public string UserType { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Blank field is not allow")]
        public string UserPassword { get; set; }


        //[NotMapped]
        //[Column(TypeName = "nvarchar(100)")]
        //[DisplayName("Confirm Password")]
        //[DataType(DataType.Password)]
        //[Compare("UserPassword",ErrorMessage ="Password does not match")]
        //public string UserConfPassword { get; set; }
    }


}
