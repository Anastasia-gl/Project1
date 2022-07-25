namespace Project1.Interface.Service
{
    public interface IDestructive<T>
    {
        public async Task AddAsync(T destructive) { }

        public async Task RemoveAsync(T destructive) { }
    }
}
