
Robot walle = new Robot("walle");
Robot johnny5 = new Robot("johnny5");

// Console.WriteLine($"Battery power: {walle.BatteryPower}");

// walle.SuperCharge(80);

// Console.WriteLine($"New battery power: {walle.BatteryPower}");

// var result = Robot.Add(12, 8); // Since method is static, must be called using object
// var result = Robot.SuperCharge(12, 16);
// System.Console.WriteLine($"Result: {result}");

// Console.WriteLine($"Company: {Robot.Company}");
// Robot.Company = "Apertature";
// Console.WriteLine($"Company: {Robot.Company}");

//====================================================

// System.Console.WriteLine($"Name Before: {johnny5.Name}");
// Robot.ChangeName(johnny5, "DEEZ");
// System.Console.WriteLine($"Name Before: {johnny5.Name}");

//====================================================

System.Console.WriteLine(Stage.Name);
var multResult = Stage.Multiply(8,8);
System.Console.WriteLine(multResult);

System.Console.WriteLine($"Name Before: {johnny5.Name}");
Robot.ChangeRobotName(johnny5, "C3-P0");
System.Console.WriteLine($"Name Before: {johnny5.Name}");
