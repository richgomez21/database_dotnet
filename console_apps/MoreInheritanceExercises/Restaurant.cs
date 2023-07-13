
public class Restaurant{
    public string Name {get; set;}
    public string Type {get; set;}

    public virtual string ServeDish(string dish){
        return dish;
    }
}