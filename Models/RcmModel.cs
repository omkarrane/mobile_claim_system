using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JBO;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace mobileclaim.Models
{
    public class RcmModel
    {
        public List<SelectListItem> RcmId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [RegularExpression(@"[A-Za-z ]*",
        ErrorMessage = "special characters and numbers are  not  allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Date of joining")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Required(ErrorMessage = "Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select Country")]
        public string CountryList { get; set; }

        [Required(ErrorMessage = "Select Region")]
        public List<SelectListItem> RegionList { get; set; }
        
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"[A-Za-z 0-9 /#,-]*",
         ErrorMessage = "special characters (#,-,/) are allowed.")]
        public string Address { get; set; }
    }
}