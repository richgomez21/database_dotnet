public class Airplane : IVehicle
{
    public string Name { get; set;}

    public Airplane(string name){
      this.Name = name;
   }

   public void Test(){
    Console.WriteLine("Airplane test");
   }

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void StartEngine()
    {
       Console.WriteLine("AIRPLANE START ENGINE()");
    }

    public void StopEngine()
    {
        throw new NotImplementedException();
    }

    public void TurnLeft()
    {
        throw new NotImplementedException();
    }

    public void TurnRight()
    {
        throw new NotImplementedException();
    }
}