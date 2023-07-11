public class Car : IVehicle {

   public string Name {get; set;}

   public Car(string name){
      this.Name = name;
   }

   public void StartEngine(){
      Console.WriteLine("CAR START ENGINE()");
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