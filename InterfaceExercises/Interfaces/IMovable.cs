namespace InterfaceExercises.Interfaces;

public interface IMovable{
    int MoveForward(int distance);
    int MoveBackward(int distance);
    int TurnAngle(int angle);
}