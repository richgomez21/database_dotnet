using System;
using System.IO;
using System.Text.Json;
using ClassesIntro.Models;
using ClassesIntro.Services;

//path to json file
string jsonFile = "./university.json";

string json = File.ReadAllText(jsonFile);
// Console.WriteLine(json);

//JSON.parse() in JavaScript
University uni = JsonSerializer.Deserialize<University>(json);

Console.WriteLine(uni.Departments[0].DeptHead.FullName);

UniversityService uniService = new UniversityService(uni);

List<string> foundNames = uniService.GetFounderNames();
foreach(string name in foundNames){
    Console.WriteLine(name);
}

List<string> departmentNames = uniService.GetDepartmentNames();
foreach(string name in departmentNames){
    Console.WriteLine(name);
}


