namespace GenericClasses.GenericsWithRestrictions
{
    public class Repository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}
