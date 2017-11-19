namespace UDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoginContext : DbContext
    {
        public LoginContext()
            : base("name=LoginContext")
        {
        }

        public virtual DbSet<LOGINTEAM3> LOGINTEAM3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOGINTEAM3>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOGINTEAM3>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
