using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UserManagementSystem.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<usersystem> usersystems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usersystem>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<usersystem>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usersystem>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usersystem>()
                .Property(e => e.address)
                .IsUnicode(false);
        }
    }
}
