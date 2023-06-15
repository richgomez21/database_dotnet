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


}