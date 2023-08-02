public class ArrayPrinter{
    public void PrintArray<T>(T[] array){
        for(int i = 0; i < array.Length; i++){
            System.Console.WriteLine(array[i]);
        }
    }
}