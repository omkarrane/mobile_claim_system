namespace MVCPD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class countries
    {
        [Key]
        public int countryid { get; set; }

        [StringLength(20)]
        public string countryname { get; set; }

        [StringLength(10)]
        public string regionaname { get; set; }

        public virtual region region { get; set; }
    }
}
