public interface IVehicle{
    string Name {get; set;}
    void StartEngine();
    void StopEngine();
    void Drive();
    void TurnLeft();
    void TurnRight();
}