public class Boat : IVehicle{
    public string Name {get; set;}

    public Boat(string name){
      this.Name = name;
   }

   public void StartEngine(){
      Console.WriteLine("BOAT START ENGINE()");
   }
   public void StopEngine(){

   }
   public void Drive(){
    
   }
   public void TurnLeft(){
    
   }
   public void TurnRight(){
    
   }
}