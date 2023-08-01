public class Container<T>{
    public List<T> Items {get; set;}
    
    public Container(){
        Items = new List<T>();
    }

    public void AddItem(T item){
        Items.Add(item);
    }

    public void RemoveItem(T item){
        Items.Remove(item);
    }
}