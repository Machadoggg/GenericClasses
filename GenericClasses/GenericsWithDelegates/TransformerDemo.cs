namespace GenericClasses.GenericsWithDelegates
{
    public delegate T Transformer<T>(T arg);

    public class TransformerDemo
    {
        public static T Square<T>(T x) where T : struct
        {
            dynamic value = x;
            return value * value;
        }
    }
}
