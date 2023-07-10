using InterfacePractice.Interfaces;

namespace InterfacePractice.Models;

public class Book : IPrintable{
    public string Title {get; set;}
    public string Author {get; set;}
    public string Genre {get; set;}

    public string PrintDetails(){
        return ($"Book:{Title}, by:{Author}, Genre:{Genre}");
    }
}