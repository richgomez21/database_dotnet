using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Services;
public class DatabaseService{
    private ApplicationDbContext _context;

    public DatabaseService(ApplicationDbContext context){
        this._context = context;
    }

    public Student? GetStudentByIdSync(int id){
        return _context.Students.SingleOrDefault(s => s.Id == id);
    }

    public async Task<Student?> GetStudentById(int id){
        return await _context.Students
                        .Include(s => s.Courses)
                        .SingleOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Instructor?> GetInstructorById(int id){
        return await _context.Instructors
                            .Include(instr => instr.Department)
                            .SingleOrDefaultAsync(instr => instr.Id == id);
    }

    public async Task<List<Course>> GetAllCoursesWithStudents(){

        return await _context.Courses.Include(course => course.Students)
                                    .ToListAsync();
    }

    public async void AddStudent(Student student){
        _context.Add(student);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateStudentName(int studentId, string newFirstName, string newLastName){
        //find the student
        var student = await _context.Students.FindAsync(studentId);
        //update the name
        student.FirstName = newFirstName;
        student.LastName = newLastName;
        //save the changes
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudent(int studentId){
        //find the student
        var student = await _context.Students
                                    .SingleOrDefaultAsync(stud => stud.Id == studentId);

        //if the student was found, then delete
        if(student != null){
            //then a student was found
            _context.Students.Remove(student);

            //save the changes
            await _context.SaveChangesAsync();
        }
        
    }

    public async Task EnrollStudentInCourse(int studentId, int courseId){
        //get student & course 
        //update models
        //save changes

        var student = await _context.Students
                                    .SingleOrDefaultAsync(stud => stud.Id == studentId);
        var course = await _context.Courses
                                    .Include(course => course.Students)
                                    .SingleOrDefaultAsync(course => course.Id == courseId);

        if(student != null && course != null){
            // add student to course
            course.Students.Add(student);

            await _context.SaveChangesAsync();
        }
    }


}