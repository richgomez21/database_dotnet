public class Stack<T>{
    private List<T> items;

    public Stack(){
        items = new List<T>();
    }

    public void Push(T item){
        items.Add(item);
    }

    public T Pop(){
        if(IsEmpty()){
            System.Console.WriteLine("Cannot pop. Stack is empty.");
        }

        int lastIndex = items.Count -1;
        T poppedItem = items[lastIndex];
        items.RemoveAt(lastIndex);
        return poppedItem;
    }

    public bool IsEmpty(){
        return items.Count == 0;
    }
}