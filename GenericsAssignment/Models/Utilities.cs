public class Utilities{
    public T Max<T>(T value1, T value2) where T : IComparable<T>{
        return value1.CompareTo(value2) > 0 ? value1 : value2;
    }
}