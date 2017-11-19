using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mobileclaim.Models
{
    public class CountryViewModel
    {
        public List<SelectListItem> CountryList { get; set; }
        public List<SelectListItem> RegionList { get; set; }
        public int id { get; set; }
    }
}