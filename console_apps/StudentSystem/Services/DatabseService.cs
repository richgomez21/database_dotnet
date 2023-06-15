using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class DataBaseService{
    private ApplicationDbContext _context;

    public DataBaseService(ApplicationDbContext context){
        this._context = context;
    }

    public List<Student> GetAll(){
        return _context.Instructors
                .Include(Instructor => Instructor.Departments);
    }
}