using System.Text.Json.Serialization;

namespace ClassesIntro.Models;

public class Course{
    public string Id { get; set; }

    public string Name { get; set; }

    [JsonPropertyName("Instructor")]
    
    public Instructor CourseInstructor { get; set; }
}