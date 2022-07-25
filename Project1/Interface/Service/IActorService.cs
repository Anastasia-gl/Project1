using Project1.Model;

namespace Project1.Interface.Service
{
    internal interface IActorService : IDestructive<Actor>
    {
        public async Task EditAsync(Actor actor, int id, string firstName, string lastName) { }
    }
}
