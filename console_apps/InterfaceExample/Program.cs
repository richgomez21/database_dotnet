

Car carA = new Car("CarA");
Car carB = new Car("CarB");
Car carC = new Car("CarC");

Boat boatA = new Boat("BoatA");
Boat boatB = new Boat("BoatB");
Boat boatC = new Boat("BoatC");

Airplane airplaneA = new Airplane("AirplaneA");
Airplane airplaneB = new Airplane("AirplaneB");
Airplane airplaneC = new Airplane("AirplaneC");

Airplane[] planes = {airplaneA, airplaneB};

IVehicle[] vehiclesArr = {airplaneA, boatA, carA};

foreach(IVehicle vehicle in vehiclesArr){
    vehicle.StartEngine();
}

Console.WriteLine("==========================================");

IVehicle airplaneZ = new Airplane("airplaneZ");
Console.WriteLine(airplaneZ.GetType());