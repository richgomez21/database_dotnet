using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
namespace StudentSystem.Data;
public class ApplicationDbContext : DbContext{
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=school.db");
}