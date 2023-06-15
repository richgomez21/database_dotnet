namespace ClassesIntro.Models;

public class University{
    public string Id { get; set; }
    public string Name { get; set; }

    public List<Founder> Founders { get; set; }
    
    public List<Department> Departments { get; set; }
}
