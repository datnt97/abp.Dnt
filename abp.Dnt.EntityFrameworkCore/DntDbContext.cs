using abp.Dnt.Domain.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace abp.Dnt.EntityFrameworkCore
{
    public class DntDbContext : AbpDbContext<DntDbContext>
    {
        public DntDbContext(DbContextOptions<DntDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDnt();
        }

        public DbSet<Book> Books { get; set; }
    }
}
