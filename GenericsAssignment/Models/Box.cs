public class Box<T>{
    public T Value;

    public void SetValue(T item){
        this.Value = item;
    }

    public T GetValue(){
        return this.Value;
    }

    public void Swap(Box<T> sumBox){
        T temp = this.Value;
        this.Value = sumBox.Value;
        sumBox.Value = temp;
    }

}