namespace MVCPD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model4")
        {
        }

        public virtual DbSet<countries> countries { get; set; }
        public virtual DbSet<region> region { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<countries>()
                .Property(e => e.countryname)
                .IsUnicode(false);

            modelBuilder.Entity<countries>()
                .Property(e => e.regionaname)
                .IsUnicode(false);

            modelBuilder.Entity<region>()
                .Property(e => e.regionname)
                .IsUnicode(false);

            modelBuilder.Entity<region>()
                .HasMany(e => e.countries)
                .WithOptional(e => e.region)
                .HasForeignKey(e => e.regionaname);
        }
    }
}
