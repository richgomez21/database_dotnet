/*PROBLEM 1*/
Box<int> intBox = new Box<int>();
intBox.SetValue(10);
Console.WriteLine(intBox.GetValue());  // Should output: 10

Box<string> stringBox = new Box<string>();
stringBox.SetValue("Hello, world!");
Console.WriteLine(stringBox.GetValue());  // Should output: Hello, world!

/*PROBLEM 2*/
Printer printer = new Printer();
printer.Print<int>(5, 10);  // Should output: Value 1: 5, Value 2: 10
printer.Print<string>("Hello", "World");  // Should output: Value 1: Hello, Value 2: World

/*PROBLEM 3*/
Pair<int, string> pair = new Pair<int, string> { First = 1, Second = "one" };
Console.WriteLine($"First: {pair.First}, Second: {pair.Second}");  // Should output: First: 1, Second: one

/*PROBLEM 4*/
Comparator comparator = new Comparator();
Console.WriteLine(comparator.Compare<int>(5, 10));  // Should output: False
Console.WriteLine(comparator.Compare<string>("Hello", "Hello"));  // Should output: True

/*PROBLEM 5*/
Triple<int, string, bool> triple = new Triple<int, string, bool> { First = 1, Second = "one", Third = true };
Console.WriteLine($"First: {triple.First}, Second: {triple.Second}, Third: {triple.Third}");  // Should output: First: 1, Second: one, Third: True

/*PROBLEM 6*/
ArrayPrinter arrayPrinter = new ArrayPrinter();
arrayPrinter.PrintArray<int>(new int[] { 1, 2, 3, 4, 5 });  // Should output: 1 2 3 4 5 (on separate lines)
arrayPrinter.PrintArray<string>(new string[] { "Hello", "World" });  // Should output: Hello World (on separate lines)

/*PROBLEM 7*/
Container<int> container = new Container<int>();
container.AddItem(10);
container.AddItem(20);
container.RemoveItem(10);

/*PROBLEM 8*/
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
Console.WriteLine(stack.Pop());  // Should output: 2
Console.WriteLine(stack.IsEmpty());  // Should output: False

/*PROBLEM 9*/
Box<int> box1 = new Box<int> { Value = 10 };
Box<int> box2 = new Box<int> { Value = 20 };
box1.Swap(box2);
Console.WriteLine($"Box1 Value: {box1.Value}, Box2 Value: {box2.Value}");  // Should output: Box1 Value: 20, Box2 Value: 10

/*PROBLEM 10*/
Utilities utilities = new Utilities();
Console.WriteLine(utilities.Max<int>(5, 10));  // Should output: 10
Console.WriteLine(utilities.Max<string>("Hello", "World"));  // Should output: World