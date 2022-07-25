using Project1.Service;
using Project1.Model;
namespace Project1
{
    public class Project1Facade
    {
        private readonly AppContext _appContext;
        private readonly ActorStore _actorService;
        private readonly GenreStore _genreService;
        private readonly MovieStore _movieStore;
        private readonly ShowStore _showStore;
        private readonly WatchService<Movie> _watchServieMovie;
        private readonly WatchService<Show> _watchServieShow;

        public Project1Facade(AppContext appContext)
        {
            _appContext = appContext;

            _actorService = new ActorStore(_appContext);
            _genreService = new GenreStore(_appContext);
            _movieStore = new MovieStore(_appContext);
            _showStore = new ShowStore(_appContext);
            _watchServieMovie = new WatchService<Movie>(_movieStore);
            _watchServieShow = new WatchService<Show>(_showStore);
        }

        public async Task Run()
        {
            await _genreService.AddAsync(new Genre("Title1"));
            await _movieStore.AddAsync(new Movie("Movie1", "MovieDescription1", 1999, 10.0M, 3));
            await _showStore.AddAsync(new Show("Show1", "ShowDescription1", 1996, 9.0M, 1, 2));
            await _actorService.AddAsync(new Actor("Anna", "Lohvin"));

            var first  = _watchServieMovie.GetGenre("Title1");

            foreach(var item in first)
            {
                Console.WriteLine($" _watchServieMovie.GetGenre(): {item.Id}, {item.Genres.Title}");
            }

            var second = _watchServieShow.GetYear(1996);

            foreach (var item in second)
            {
                Console.WriteLine($" _watchServieShow.GetYear(): {item.Id}, {item.Year}");
            }
        }
    }
}
