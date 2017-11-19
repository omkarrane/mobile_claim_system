namespace JDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3REGION
    {
        [Key]
        [StringLength(20)]
        public string REGION { get; set; }
    }
}
