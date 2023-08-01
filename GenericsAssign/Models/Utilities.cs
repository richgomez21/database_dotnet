public class Utilities{
    public T Max<T>(T itemA, T itemB)where T : IComparable<T>{
        return itemA.CompareTo(itemB) > 0 ? itemA : itemB;
    }
}