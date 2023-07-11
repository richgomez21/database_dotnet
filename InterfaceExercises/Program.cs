using InterfaceExercises.Interfaces;
using InterfaceExercises.Models;

GameCharacter dolphin = new GameCharacter();
int depthResult = dolphin.Dive(100);

Console.WriteLine($@"
                    depthResult: {depthResult}
                    dolphin.CurentDepth: {dolphin.CurrentDepth}");
Console.WriteLine("====================================================");

Robot earl = new Robot();
int angleResult = earl.TurnAngle(400);
Console.WriteLine($@"
                    angleResult: {angleResult}
                    earl.CurrentDirection: {earl.CurrentDirection}");
Console.WriteLine("====================================================");

Employee bob = new Employee();
double tax = bob.DeductTax(.6);

