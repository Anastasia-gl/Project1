using Project1.Model;
namespace Project1.Service
{
    public class GenreService
    {
        private readonly AppContext _dbContext;

        public GenreService(AppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Genre genre)
        {
            _dbContext.Add(genre);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Genre genre)
        {
            _dbContext.Remove(genre);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Genre genre, int id, string title)
        {
            if (genre != null)
            {
                genre.GenreId = id;
                genre.Title = title;
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
