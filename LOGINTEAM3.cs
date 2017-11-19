namespace UDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOGINTEAM3
    {
        [Key]
        [StringLength(30)]
        public string USERID { get; set; }

        [StringLength(30)]
        public string PASSWORD { get; set; }
    }
}
