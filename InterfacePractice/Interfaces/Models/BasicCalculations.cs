using InterfacePractice.Interfaces;

namespace InterfacePractice.Models;

public class BasicCalculations : ICalculations{
    public int Add(int number1, int number2){
        return (number1 + number2);
    }
      public int Subtract(int number1, int number2){
        return (number1 - number2);
    }
}