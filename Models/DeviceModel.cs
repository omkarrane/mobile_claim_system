using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mobileclaim.Models
{
    public class DeviceModel
    {
        [Key]
        public int DEVICEID { get; set; }
        public string DEVICE_NAME { get; set; }
        public string DEVICE_TYPE { get; set; }
        public long IMEI_NUMBER { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DATEOFMANUFACTURING { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DATEOFSHIPPING { get; set; }
        public DateTime DATEOFWARRENTYEXPIRY { get; set; }
        public string INWARRENTY { get; set; }
        public decimal PRICE { get; set; }
    }
}