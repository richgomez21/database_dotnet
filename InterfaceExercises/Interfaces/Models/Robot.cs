using InterfaceExercises.Interfaces;

namespace InterfaceExercises.Models;

public class Robot : IMovable{
    public int CurrentPosition {get; set;}
    public int CurrentDirection {get; set;} // angle in degrees

    public int MoveForward(int distance){
        return (this.CurrentPosition += distance);
    }
    public int MoveBackward(int distance){
        return (this.CurrentPosition -= distance);
    }
    public int TurnAngle(int angle){
        return (this.CurrentDirection = (this.CurrentDirection + angle) % 360);
    }

}