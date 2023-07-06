
Employee employee1 = new Employee();
employee1.Name = "John Doe";
employee1.Position = "Assistant";
double salary1 = employee1.Salary(40);
Console.WriteLine($"Salary for {employee1.Name} ({employee1.Position}): ${salary1}");
Console.WriteLine("=====================================");
Employee manager = new Employee();
manager.Name = "Dominique Jones";
manager.Position = "CEO";
double salary2 = manager.Salary(600);
Console.WriteLine($"Salary for {manager.Name} ({manager.Position}): ${salary2}");
Console.WriteLine("=====================================");
Dog dog = new Dog();
dog.Name = "Duke";
string dogNoise = dog.MakeSound();
Console.WriteLine($"{dog.Name} says: {dogNoise}");
Console.WriteLine("=====================================");
Cat cat = new Cat();
cat.Name = "Muffin";
string catNoise = cat.MakeSound();
Console.WriteLine($"{cat.Name} says: {catNoise}");
Console.WriteLine("=====================================");
Triangle triangle = new Triangle();
System.Console.WriteLine(triangle.Area(8,12));
Console.WriteLine("=====================================");
Rectangle rectangle = new Rectangle();
System.Console.WriteLine(rectangle.Area(2,20));
Console.WriteLine("=====================================");


