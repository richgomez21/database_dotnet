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

//PROBLEM 1
var instructorNames = _basicDBService.GetAllInstructorNames();

Console.WriteLine("PROB 1");
foreach(string name in instructorNames){
    Console.WriteLine(name);
}

Console.WriteLine("---------------");

//PROBLEM 2
var studentsInCourses = _basicDBService.GetStudentsInCourse("Algebra");

Console.WriteLine("PROB 2");
foreach(string courseName in studentsInCourses){
    Console.WriteLine(courseName);
}

Console.WriteLine("---------------");

//PROBLEM 3
var deptWithMoreThanOneCourse = _basicDBService.GetDepartmentsWithMoreThanOneCourses();

Console.WriteLine("PROB 3");
foreach(string dept in deptWithMoreThanOneCourse){
    Console.WriteLine(dept);
}
Console.WriteLine("---------------");

//PROBLEM 4
var deptWithMostCourses = _basicDBService.GetDepartmentWithMostCourses();

    Console.WriteLine("PROB 4");
    Console.WriteLine(deptWithMostCourses);


Console.WriteLine("---------------");

//PROBLEM 5
var studWithMoreThanFive = _basicDBService.GetStudentsEnrolledInMoreThanFiveCourses();

Console.WriteLine("PROB 5");
foreach(string stud in studWithMoreThanFive){
    Console.WriteLine(stud);
}
Console.WriteLine("---------------");

//PROBLEM 6
var instructorInDept = _basicDBService.GetInstructorsInDepartment("History");

Console.WriteLine("PROB 6");
foreach(string instructor in instructorInDept){
    Console.WriteLine(instructor);
}
Console.WriteLine("---------------");

//PROBLEM 7
var courseByInstructor = _basicDBService.GetCoursesByInstructor("John");

Console.WriteLine("PROB 7");
foreach(string instructor in courseByInstructor){
    Console.WriteLine(instructor);
}

Console.WriteLine("---------------");

//PROBLEM 8 

var studentsWithNoCourses = _basicDBService.GetStudentsWithNoCourses();

Console.WriteLine("PROB 8");
foreach(string student in studentsWithNoCourses){
    Console.WriteLine("NO COURSES");
    Console.WriteLine(student);
}
Console.WriteLine("---------------");

var deptWithNoCourses = _basicDBService.GetDepartmentsWithNoCourses();

Console.WriteLine("PROB 9");
foreach(string dept in deptWithNoCourses){
    Console.WriteLine(dept);
}
Console.WriteLine("---------------");

var instrWithMostCourses = _basicDBService.GetInstructorWithMostCourses();

Console.WriteLine("PROB 10");
Console.WriteLine(instrWithMostCourses);


/*
    DATABASE SERVICE START
*/
Console.WriteLine("---------------");

var studA = await _dbService.GetStudentById(1);
Console.WriteLine(studA.LastName);

Console.WriteLine("---------------");

Console.WriteLine(studA.Courses[0].CourseName);

var instr = await _dbService.GetInstructorById(1);

Console.WriteLine("---------------");

Console.WriteLine(instr.LastName);
Console.WriteLine(instr.Department.DeptName);

// _dbService.UpdateStudentName(4,"DANIEL", "DEEZINGTON");

_dbService.UpdateStudentName(5,"BOBBY", "DEEZINGTON");

var result = await _dbService.GetAllCoursesWithStudents();

Console.WriteLine("COURSES::::::::::::::::::");
foreach(Course elem in result){
    Console.WriteLine(elem.CourseName);
}

var coursesList = await _dbService.GetAllCoursesWithStudents();

Student newStudent = new Student {
                            FirstName = "Les",
                            LastName = "Stroud",
                            JoiningDate = DateTime.Now,
                            Courses = coursesList
                        };

// await _dbService.AddStudent(newStudent);

// await _dbService.DeleteStudent(6);

var testStudent = await _dbService.GetStudentById(4);
Console.WriteLine("STUDENT LIST BEFORE:");
foreach(var course in testStudent.Courses){
    Console.WriteLine(course.CourseName);
}


await _dbService.EnrollStudentInCourse(4, 2);

Console.WriteLine("STUDENT LIST AFTER:");
foreach(var course in testStudent.Courses){
    Console.WriteLine(course.CourseName);
}






/*
    DATABASE SERVICE End
*/


_serviceProvider.Dispose();