using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCPD.Models
{
    public class DeviceModel2
    {

        [Key]
        public List<SelectListItem> DEVICEID { get; set; }
        public string DEVICE_NAME { get; set; }
        public string DEVICE_TYPE { get; set; }
        public List<SelectListItem> IMEI_NUMBER { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public List<SelectListItem> DATEOFMANUFACTURING { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public List<SelectListItem> DATEOFSHIPPING { get; set; }
        public DateTime DATEOFWARRENTYEXPIRY { get; set; }
        public string INWARRENTY { get; set; }
        public decimal PRICE { get; set; }
    }
}