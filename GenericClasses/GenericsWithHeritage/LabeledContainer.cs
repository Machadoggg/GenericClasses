namespace GenericClasses.GenericsWithHeritage
{
    public class LabeledContainer<T> : Container<T>
    {
        public string Label { get; set; } = default!;
    }
}
