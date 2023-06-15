using System.Text.Json.Serialization;

namespace ClassesIntro.Models;

public class Department{
    public string Id { get; set; }

    public string Name { get; set; }

    [JsonPropertyName("Head")]

    public Head DeptHead { get; set; }
    
    public List<Course> Courses { get; set; }
}