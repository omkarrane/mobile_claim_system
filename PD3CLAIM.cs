namespace MDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3CLAIM
    {
        [Key]
        public int ClaimId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClaimDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClaimUpdateDate { get; set; }
    }
}
