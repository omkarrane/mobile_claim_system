using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mobileclaim.Models
{[Table("PD3ASV")]
    public class asvmodel
    {
       
        [Key]
        public int AsvId { get; set; }
        [Required]
        
        public string AsvName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required]
        public string CompetencyLevel { get; set; }
    }
}