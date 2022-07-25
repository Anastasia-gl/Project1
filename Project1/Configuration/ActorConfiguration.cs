using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> entity)
        {
            entity.
                ToTable("Actor").
                HasKey(a => a.Id);

            entity.
                Property(p => p.FisrtName).
                HasMaxLength(20);

            entity.Property(p => p.LastName).
                HasMaxLength(20);
        }
    }
}
