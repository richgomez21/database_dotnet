namespace InterfaceExercises.Interfaces;

public interface IPayable{
    double IncreaseSalary(double increment);
    double DeductTax(double rate);
    double PayBonus(double amount);
}