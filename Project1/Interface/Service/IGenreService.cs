using Project1.Model;

namespace Project1.Interface.Service
{
    internal interface IGenreService : IDestructive<Genre>
    {
        public async Task EditAsync(Genre genre, int id, string title) { }
    }
}
