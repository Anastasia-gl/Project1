using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> entity)
        {
            entity.
                ToTable("Movie").
                HasKey(e => e.Id);

            entity.
                Property(p => p.Name).
                HasMaxLength(20);

            entity.
                Property(p => p.Description).
                HasMaxLength(100);
        }
    }
}
