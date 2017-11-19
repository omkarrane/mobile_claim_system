namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<PD3DEVICE2> PD3DEVICE2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
        }
    }
}
