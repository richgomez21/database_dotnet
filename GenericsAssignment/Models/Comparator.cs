public class Comparator{
    public bool Compare<T>(T item1, T item2){
        if(item1.Equals(item2)){
            return true;
        } else {
            return false;
        }
    }
}