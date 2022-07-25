namespace Project1.Model
{
    public class Actor
    {
        public Actor(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public IList<ActorMovieShow> ActorMovie { get; set; }
    }
}
