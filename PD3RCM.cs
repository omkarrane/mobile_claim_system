namespace MVCPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3RCM
    {
        [Key]
        public int RCMID { get; set; }

        [StringLength(50)]
        public string RCM_NAME { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string COUNTRY { get; set; }

        [StringLength(50)]
        public string EMAILID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATEOFJOINING { get; set; }

        [StringLength(50)]
        public string REGION { get; set; }
    }
}
