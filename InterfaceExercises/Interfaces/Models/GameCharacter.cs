using InterfaceExercises.Interfaces;

namespace InterfaceExercises.Models;
public class GameCharacter : ISwimmable{
    public int CurrentDepth {get; set;}
    public int TotalDistance {get; set;}
    public int Dive(int depth){
       return (this.CurrentDepth += depth);
    }
    public int Surface(int amount){
       return (this.CurrentDepth -= amount);
    }
    public int SwimDistance(int distance){
        return (this.TotalDistance += distance);
    }
    }