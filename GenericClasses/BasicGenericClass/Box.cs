namespace GenericClasses.BasicGenericClass
{
    public class Box<T>
    {
        public T Content { get; set; }

        public Box(T content)
        {
            Content = content;
        }

        public void DisplayContent()
        {
            Console.WriteLine($"Content: {Content}");
        }
    }
}
