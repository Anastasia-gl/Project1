using Project1.Model;
using Project1.Interface.Service;
namespace Project1.Service
{
    public class ActorService  : IActorService
    {
        private readonly AppContext _dbContext;

        public ActorService(AppContext dbContext)
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

        public async Task EditAsync(Actor actor, int id, string firstName, string lastName)
        {
            if (actor != null)
            {
                actor.Id = id;
                actor.FisrtName = firstName;
                actor.LastName = lastName;
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
