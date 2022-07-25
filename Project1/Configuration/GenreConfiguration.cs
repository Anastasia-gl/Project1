using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.
                ToTable("Genre").
                HasKey(e => e.GenreId);

            entity.
                Property(e => e.Title).
                HasMaxLength(20);
        }
    }
}
