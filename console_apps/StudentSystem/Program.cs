using Microsoft.Extensions.DependencyInjection;
using StudentSystem.Models;
using StudentSystem.Data;
using System;
using System.Collections.Generic;
using StudentSystem.Services;

ServiceProvider _serviceProvider;
DatabaseService _dbService;
BasicQueryService _basicDBService;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<BasicQueryService>();
services.AddScoped<DatabaseService>();

_serviceProvider = services.BuildServiceProvider();
_basicDBService = _serviceProvider.GetRequiredService<BasicQueryService>();
_dbService = _serviceProvider.GetRequiredService<DatabaseService>();
var instructorNames = _basicDBService.GetAllInstructorNames();

foreach(string name in instructorNames){
    Console.WriteLine(name);
}

Console.WriteLine("---------------");

var studentsInCourses = _basicDBService.GetStudentsInCourse("Algebra");

foreach(string courseName in studentsInCourses){
    Console.WriteLine(courseName);
}

Console.WriteLine("---------------");

var deptWithMoreThanOneCourse = _basicDBService.GetDepartmentsWithMoreThanOneCourses();

foreach(string dept in deptWithMoreThanOneCourse){
    Console.WriteLine(dept);
}
Console.WriteLine("---------------");

var studWithMoreThanFive = _basicDBService.GetStudentsEnrolledInMoreThanFiveCourses();
foreach(string stud in studWithMoreThanFive){
    Console.WriteLine(stud);
}
Console.WriteLine("---------------");

var instructorInDept = _basicDBService.GetInstructorsInDepartment("History");

foreach(string instructor in instructorInDept){
    Console.WriteLine(instructor);
}


/*
    DATABASE SERVICE START
*/

var studA = await _dbService.GetStudentById(1);
Console.WriteLine(studA.LastName);

Console.WriteLine("---------------");

Console.WriteLine(studA.Courses[0].CourseName);

var instr = await _dbService.GetInstructorById(1);

Console.WriteLine("---------------");

Console.WriteLine(instr.LastName);
Console.WriteLine(instr.Department.DeptName);




/*
    DATABASE SERVICE End
*/


_serviceProvider.Dispose();