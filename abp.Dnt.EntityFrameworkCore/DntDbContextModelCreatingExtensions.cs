using abp.Dnt.EntityFrameworkCore.Configurations;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace abp.Dnt.EntityFrameworkCore
{
    public static class DntDbContextModelCreatingExtensions
    {
        public static void ConfigureDnt(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.ApplyConfiguration(new BookConfiguration());

            
        }
    }
}
