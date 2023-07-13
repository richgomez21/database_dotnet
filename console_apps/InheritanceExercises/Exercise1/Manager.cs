
public class Manager : Employee{
    public override double Salary(int hoursWorked){
        double managerPayRate = 25.0; 
        return managerPayRate * hoursWorked;
    }
}