using Microsoft.EntityFrameworkCore;

namespace Lab8a_MVC.Models.Db
{
    public class TDDbContext : DbContext, IDbContext
    {

        public DbSet<Phone> Phone { get; set; }

        public TDDbContext(DbContextOptions<TDDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
                .ToTable("Phone");
        }

        void IDbContext.SaveChanges()
        {
            SaveChanges();
        }
    }
}
