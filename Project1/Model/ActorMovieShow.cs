namespace Project1.Model
{
    public class ActorMovieShow
    {
        public ActorMovieShow(int id, int actorId, int movieId, int showId)
        {
            Id = id;
            ActorId = actorId;
            MovieId = movieId;
            ShowId = showId;
        }

        public int Id { get; set; }

        public int ActorId { get; set; }

        public int MovieId { get; set; }

        public int ShowId { get; set; }

        public Actor Actor { get; set; }

        public Show Show { get; set; }

        public Movie Movie { get; set; }

    }
}
