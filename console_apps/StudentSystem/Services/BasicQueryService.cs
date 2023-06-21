using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Services;

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
            .Select(department => department.DeptName)
            .FirstOrDefault();
    }

    public List<string> GetStudentsEnrolledInMoreThanFiveCourses(){
        return _context.Students.Where(stud => stud.Courses.Count > 5)
                                .Select(stud => stud.FirstName)
                                .ToList();
    }             

    public List<string> GetInstructorsInDepartment(string departmentName){
        return _context.Departments.Where(dept => dept.DeptName == departmentName)
                                    .SelectMany(dept => dept.Courses
                                                        .Select(course => course.Instructor.LastName)
                                    )
                                    .Distinct()
                                    .ToList();
    }                  

    public List<string> GetCoursesByInstructor(string instructorName){
        return _context.Instructors.Where(instr => instr.FirstName == instructorName)
                                    .SelectMany(instr => instr.Courses)
                                    .Select(instr => instr.CourseName)
                                    .ToList();
    }

    public List<string> GetStudentsWithNoCourses(){
        return _context.Students.Where(student => student.Courses.Count == 0)
                                .Select(student => student.FirstName)
                                .ToList();
    }

    public List<string> GetDepartmentsWithNoCourses(){
        return _context.Departments.Where(dept => dept.Courses.Count == 0)
                                    .Select(dept => dept.DeptName)
                                    .ToList();
    }

    public string GetInstructorWithMostCourses(){
        return _context.Instructors.OrderByDescending(instructor => instructor.Courses.Count)
                                    .Select(instructor => instructor.FirstName)
                                    .FirstOrDefault();
    }


}
