namespace MVCPD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model5 : DbContext
    {
        public Model5()
            : base("name=Model5")
        {
        }

        public virtual DbSet<PD3ASV> PD3ASV { get; set; }
        public virtual DbSet<PD3DEVICE2> PD3DEVICE2 { get; set; }
        public virtual DbSet<PD3RCM> PD3RCM { get; set; }

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

            modelBuilder.Entity<PD3DEVICE2>()
                .Property(e => e.DEVICE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE2>()
                .Property(e => e.DEVICE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE2>()
                .Property(e => e.INWARRENTY)
                .IsUnicode(false);

            modelBuilder.Entity<PD3DEVICE2>()
                .Property(e => e.PRICE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PD3RCM>()
                .Property(e => e.RCM_NAME)
                .IsFixedLength()
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
        }
    }
}
