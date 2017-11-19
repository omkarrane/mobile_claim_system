namespace JDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<PD3COUNTRIES> PD3COUNTRIES { get; set; }
        public virtual DbSet<PD3RCM> PD3RCM { get; set; }
        public virtual DbSet<PD3REGION> PD3REGION { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PD3COUNTRIES>()
                .Property(e => e.REGION)
                .IsUnicode(false);

            modelBuilder.Entity<PD3COUNTRIES>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.RCM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.EMAILID)
                .IsUnicode(false);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.REGION)
                .IsUnicode(false);

            modelBuilder.Entity<PD3REGION>()
                .Property(e => e.REGION)
                .IsUnicode(false);
        }
    }
}
