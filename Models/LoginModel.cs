using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPD.Models
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage = "Please Enter UserID")]
        public string USERID { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string PASSWORD { get; set; }
    }
}

