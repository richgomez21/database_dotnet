public class Triple<T, U, V>{
    public T First;
    public U Second;
    public V Third;

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

    public void SetValueV(V item){
        this.Third = item;
    }

    public V GetValueV(){
        return this.Third;
    }

}