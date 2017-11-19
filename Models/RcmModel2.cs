using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mobileclaim.Models
{
    public class RcmModel2
    {
        public int RcmId { get; set; }
       
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Email { get; set; }
        public string CountryList { get; set; }
        public string RegionList { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}