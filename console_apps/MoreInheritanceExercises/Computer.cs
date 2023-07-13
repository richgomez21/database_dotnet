
public class Computer{
    public string Brand {get; set;}
    public string OS {get; set;}

    public virtual string Boot (string mode){
        return $"Booting in {mode}.";
    }
}