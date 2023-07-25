
public class Novel : Book{
    public override string Read(int pages){
        return (pages + 5).ToString();
    }
}