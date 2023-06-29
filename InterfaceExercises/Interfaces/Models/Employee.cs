using InterfaceExercises.Interfaces;

namespace InterfaceExercises.Models;

public class Employee : IPayable{
    public double Salary {get; set;}

    public double DeductTax(double rate)
    {
        double tax = this.Salary * (rate / 100);
        this.Salary -= tax;

        return this.Salary * (rate / 100);
    }

    public double IncreaseSalary(double increment)
    {
        return this.Salary += increment;
    }

    public double PayBonus(double amount)
    {
        return this.Salary += amount;
    }
}