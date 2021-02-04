using abp.Dnt.Domain.Books;
using abp.Dnt.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace abp.Dnt.EntityFrameworkCore.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .ToTable(BookConsts.DbTablePrefix + "Books",
                    BookConsts.DbSchema
                );

            builder
                .ConfigureByConvention();

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(128);
        }
    }
}
