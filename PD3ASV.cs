namespace MDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PD3ASV
    {
        [Key]
        public int AsvId { get; set; }

        [StringLength(30)]
        public string AsvName { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [StringLength(50)]
        public string EmailId { get; set; }

        //[StringLength(10)]
        public long? PhoneNumber { get; set; }

        [StringLength(10)]
        public string CompetencyLevel { get; set; }

        [StringLength(30)]
        public string Region { get; set; }
    }
}
