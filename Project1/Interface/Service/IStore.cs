namespace Project1.Interface.Service
{
    public interface IStore<T> : IDestructive<T>
    {
        public async Task EditAsync(T movie, int id, string name, string description, int year, decimal rate, int genreId) { }

        public IList<T> GetMoviesGenre()
        {
            return new List<T>();
        }

        public IList<T> GetMoviesAge()
        {
            return new List<T>();
        }

        public IList<T> GetMoviesActor()
        {
            return new List<T>();
        }
    }
}
