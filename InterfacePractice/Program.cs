using InterfacePractice.Interfaces;
using InterfacePractice.Models;

Book libro = new Book{
    Title = "Magic Tree House",
    Author = "Sir Tree",
    Genre = "Horror"
};
string newBook = libro.PrintDetails();
System.Console.WriteLine($@"
                    book Info: {newBook}
                    Book Title: {libro.Title}");
Console.WriteLine("====================================================");
Student rick = new Student{
    Name = "Rick Sanchez",
    Age = "55",
    Major = "Science"
};
string studentInfo = rick.PrintDetails();
System.Console.WriteLine($@"
                    info: {studentInfo}
                    Name: {rick.Name}");
Console.WriteLine("====================================================");
BasicCalculations newNumber = new BasicCalculations();
int finalNumber = newNumber.Add(2,5);
System.Console.WriteLine(finalNumber);
Console.WriteLine("====================================================");
BasicCalculations newNumber2 = new BasicCalculations();
int finalNumber2 = newNumber2.Subtract(20,5);
System.Console.WriteLine(finalNumber2);
Console.WriteLine("====================================================");
Circle circle = new Circle{
    Radius = 5.0
};

Rectangle rectangle = new Rectangle{
    Length = 4.0,
    Width = 3.0
};

double circleArea = circle.CalculateArea();
double circlePerimeter = circle.CalculatePerimeter();
double rectangleArea = rectangle.CalculateArea();
double rectanglePerimeter = rectangle.CalculatePerimeter();

Console.WriteLine("Circle Area: " + circleArea);
Console.WriteLine("Circle Perimeter: " + circlePerimeter);
Console.WriteLine("====================================================");
Console.WriteLine("Rectangle Area: " + rectangleArea);
Console.WriteLine("Rectangle Perimeter: " + rectanglePerimeter);