using Project1.Model;
using Project1.Interface.Service;
namespace Project1.Service
{
    public class ActorStore  : IActorGenreStore<Actor>
    {
        private readonly AppContext _dbContext;

        public ActorStore(AppContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public async Task AddAsync(Actor actor)
        {
            _dbContext.Add(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Actor actor)
        {
            _dbContext.Remove(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Actor actor)
        {
            if (actor != null)
            {
                _dbContext.Actor.Update(actor);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
