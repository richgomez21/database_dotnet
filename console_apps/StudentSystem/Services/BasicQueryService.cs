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

    // public List<string> GetDepartmentWithMostCourses(){
    //     return _context.Departments
    //         .OrderByDescending(department => department.Courses.Count)
    //         .SelectMany(department => department.Courses.Count == department.Courses.Count.First())
    //         .Select(department => department.Name).ToList();
    // }

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
        return _context.Instructors.Where(instr => instr. == instructorName)
                                    .Select(instr => instr.Courses)
                                    .ToList();
    }


}
