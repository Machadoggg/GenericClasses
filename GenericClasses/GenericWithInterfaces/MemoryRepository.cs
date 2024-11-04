namespace GenericClasses.GenericWithInterfaces
{
    public class MemoryRepository<T> : IRepository<T>
    {
        private readonly List<T> _storage = new List<T>();

        public void Add(T item)
        {
            _storage.Add(item);
        }

        public T Get(int index)
        {
            return _storage[index];
        }
    }
}
