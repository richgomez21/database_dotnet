
Box<double> boxA = new Box<double>(8.0);
Box<string> boxB = new Box<string>("HOLA MUNDO");
AdvancedBox<string, int> boxC = new AdvancedBox<string, int>("hello", 8);

System.Console.WriteLine($"BoxA: {boxA.GetItem()} and {boxA.DisplayType()}");
System.Console.WriteLine($"BoxB: {boxB.GetItem()} and {boxB.DisplayType()}");

System.Console.WriteLine($"boxC.itemA: {boxC.ItemA}");

