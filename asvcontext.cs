namespace MDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class asvcontext : DbContext
    {
        public asvcontext()
            : base("name=asvcontext")
        {
        }

        public virtual DbSet<PD3ASV> PD3ASV { get; set; }
        public virtual DbSet<PD3CLAIM> PD3CLAIM { get; set; }
        public virtual DbSet<PD3DEVICE1> PD3DEVICE1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.AsvName)
                .IsUnicode(false);

            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.CompetencyLevel)
                .IsUnicode(false);

            modelBuilder.Entity<PD3ASV>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE1>()
                .Property(e => e.DEVICE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE1>()
                .Property(e => e.DEVICE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE1>()
                .Property(e => e.PRICE)
                .HasPrecision(18, 0);
        }
    }
}
