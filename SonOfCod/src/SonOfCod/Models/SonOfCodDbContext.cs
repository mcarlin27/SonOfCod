using Microsoft.EntityFrameworkCore;

namespace SonOfCod.Models
{
    public class SonOfCodDbContext : DbContext
    {
        public SonOfCodDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SonOfCod; integrated security=True");
        }

        public SonOfCodDbContext(DbContextOptions<SonOfCodDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
