namespace MVCPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3DEVICE2
    {
        [Key]
        public int DEVICEID { get; set; }

        [StringLength(50)]
        public string DEVICE_NAME { get; set; }

        [StringLength(50)]
        public string DEVICE_TYPE { get; set; }

        public long? IMEI_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFMANUFACTURING { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFSHIPPING { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFWARRENTYEXPIRY { get; set; }

        [StringLength(10)]
        public string INWARRENTY { get; set; }

        public decimal? PRICE { get; set; }
    }
}
