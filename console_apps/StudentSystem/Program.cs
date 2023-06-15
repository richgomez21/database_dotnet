using Microsoft.Extensions.DependencyInjection;
using StudentSystem.Models;
using StudentSystem.Data;
using System;
using System.Collections.Generic;

ServiceProvider _serviceProvider;
// DatabaseService _dvService;
BasicQueryService _basicDBService;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<BasicQueryService>();

_serviceProvider = services.BuildServiceProvider();
_basicDBService = _serviceProvider.GetRequiredService<BasicQueryService>();

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




