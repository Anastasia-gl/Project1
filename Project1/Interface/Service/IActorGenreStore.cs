namespace Project1.Interface.Service
{
    public interface IActorGenreStore <T>
    {
        public async Task AddAsync(T entity) { }

        public async Task RemoveAsync(T entity) { }

        public async Task EditAsync(T entity) { }
    }
}
