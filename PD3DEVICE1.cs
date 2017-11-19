namespace MDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3DEVICE1
    {
        [Key]
        public int DEVICEID { get; set; }

        [StringLength(50)]
        public string DEVICE_NAME { get; set; }

        [StringLength(50)]
        public string DEVICE_TYPE { get; set; }

        public long? IMEI_NUMBER { get; set; }

        public DateTime? DATEOFMANUFACTURING { get; set; }

        public DateTime? DATEOFSHIPPING { get; set; }

        public DateTime? DATEOFWARRENTYEXPIRY { get; set; }

        public bool? INWARRENTY { get; set; }

        public decimal? PRICE { get; set; }
    }
}
