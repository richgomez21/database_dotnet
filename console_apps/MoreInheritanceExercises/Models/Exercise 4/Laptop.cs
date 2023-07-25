
public class Laptop : Computer{
    public override string Boot(string mode){
        return $"Booting in {mode} with slower speed.";
    }
}