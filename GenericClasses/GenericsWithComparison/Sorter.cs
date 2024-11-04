namespace GenericClasses.GenericsWithComparison
{
    public class Sorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            list.Sort();
        }
    }
}
