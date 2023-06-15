using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class BasicQueryService{
    private ApplicationDbContext _context;

    public BasicQueryService(ApplicationDbContext context){
        this._context = context;
    }

    public List<string> GetAllInstructorNames(){
        return _context.Instructors.Select(individualInstructor => individualInstructor.LastName).ToList();
    }

    public List<string> GetStudentsInCourse(string courseName){
        return _context.Courses
                        .Where(course => course.CourseName == courseName)
                        .SelectMany(course => course.Students)
                        .Select(student => student.LastName).ToList();
    }

    public List<string> GetDepartmentsWithMoreThanOneCourses(){
        return _context.Departments.Where(dept => dept.Courses.Count > 0)
                                    .Select(dept => dept.DeptName).ToList();
    }

    public string GetDepartmentWithMostCourses(){
        return _context.Departments
            .OrderByDescending(department => department.Courses.Count)
            .TakeWhile(department => department.Courses.Count == department.Courses.Count.First())
            .Select(department => department.Name).ToList();
    }

    public string GetStudentsEnrolledInMoreThanFiveCourses(){
        return _context.Courses.Where(course => course.Students.Count > 5)
                                .Select(course => course.Students.name).ToList();
    }                               


}
