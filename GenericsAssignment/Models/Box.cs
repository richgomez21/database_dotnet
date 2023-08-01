
private class Box<T>{
    private T item {get; set;}

    public T Thing {get; set;}

     public Box(T item, T thing){
        this.item = item;
        this.Thing = thing;
    }
}