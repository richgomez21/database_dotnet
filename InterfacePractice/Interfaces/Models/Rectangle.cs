using InterfacePractice.Interfaces;

namespace InterfacePractice.Models;

public class Rectangle : IMeasurable{
  public double Length {get; set;}
 public double Width {get; set;}
   public double CalculateArea(){
        return (Length * Width);
   }

   public double CalculatePerimeter(){
        return (2 * (Length + Width));
   } 
}