public class Pair<T, U>{
    public T First;
    public U Second;

    public void SetValueT(T item){
        this.First = item;
    }

    public T GetValueT(){
        return this.First;
    }

    public void SetValueU(U item){
        this.Second = item;
    }

    public U GetValueU(){
        return this.Second;
    }
}