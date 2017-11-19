namespace JDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3COUNTRIES
    {
        [StringLength(20)]
        public string REGION { get; set; }

        [Key]
        [StringLength(50)]
        public string COUNTRY { get; set; }
    }
}
