
public class Book{
    public string Title {get; set;}
    public string Author {get; set;}

    public virtual string Read(int pages){
        return pages.ToString();
    }
}