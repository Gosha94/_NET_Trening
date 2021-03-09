using MaterialDesignWpf.Models;
using System.Data.Entity;

namespace MaterialDesignWpf.DbContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("SqLiteConnection") { }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{            
        //    Database.SetInitializer<ApplicationContext>(null);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
