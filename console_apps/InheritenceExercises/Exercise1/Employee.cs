
public class Employee{
    public string Name {get; set;}
    public string Position {get; set;}

        public virtual double Salary(int hoursWorked){
            double basePayRate = 15.0; 
            return basePayRate * hoursWorked;
        }
}