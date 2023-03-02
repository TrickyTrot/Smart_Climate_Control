using LibraryOfDash;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDataBase
{
    public class MyDataBasEntityContext : DbContext
    {
        public MyDataBasEntityContext() : base("name=EtoBaza")
        {
            Database.SetInitializer<MyDataBasEntityContext>(null);
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Devise>().ToTable("Devises");
            modelBuilder.Entity<Devises_work_journal>().ToTable("Devises_work_journal");
            modelBuilder.Entity<Indication>().ToTable("Indications");
            modelBuilder.Entity<Session_journal>().ToTable("Sessions_journal");
            modelBuilder.Entity<User>().ToTable("Users");
            base.OnModelCreating(modelBuilder);
        }
    }
}
