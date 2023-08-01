public class ArrayPrinter{
    public void PrintArray<T>(T[] arr){
        for(int i = 0; i < arr.Length; i++){
            System.Console.WriteLine(arr[i]);
        }
    }
}