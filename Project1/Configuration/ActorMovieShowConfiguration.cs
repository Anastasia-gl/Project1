using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project1.Model;

namespace Project1.Configuration
{
    public class ActorMovieShowConfiguration : IEntityTypeConfiguration<ActorMovieShow>
    {
        public void Configure(EntityTypeBuilder<ActorMovieShow> entity)
        {
            entity.
                ToTable("ActorMovie").
                HasKey(e => e.Id);

            entity.
                HasOne(e => e.Movie).
                WithMany(w=>w.ActorMovieShow).
                HasForeignKey(f => f.MovieId).
                OnDelete(DeleteBehavior.ClientSetNull);

            entity.
              HasOne(e => e.Show).
              WithMany(w => w.ActorMovieShow).
              HasForeignKey(f => f.ShowId).
              OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
