public class Printer{
    public void Print<T>(T itemA, T itemB){
        System.Console.WriteLine($"Value 1: {itemA.ToString()}, Value 2: {itemB.ToString()}");
    }
}