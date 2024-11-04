namespace GenericClasses.GenericWithInterfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int index);
    }
}
