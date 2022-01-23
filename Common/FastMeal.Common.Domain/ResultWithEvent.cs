namespace FastMeal.Commom.Domain
{
    public class ResultWithEvent<T>
    {
        public T Result { get; set; }

        public object Event { get; set; }
    }
}