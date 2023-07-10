using InterfacePractice.Interfaces;

namespace InterfacePractice.Models;

public class Student : IPrintable{
    public string Name {get; set;}
    public string Age {get; set;}
    public string Major {get; set;}

    public string PrintDetails(){
        return ($"Book:{Name}, Age:{Age}, Major:{Major}");
    }
}