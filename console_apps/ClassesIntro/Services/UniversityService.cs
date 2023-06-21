using System.IO;
using System.Linq;
// using System.Collection.Generic;
using ClassesIntro.Models;

namespace ClassesIntro.Services;

public class UniversityService{
    private University _university;

    public UniversityService(University uni){
        this._university = uni;
    }

    public string Hello(){
        return "hello world";
    }

    public List<string> GetFounderNames(){
        List<string> founderNames = new List<string>();
        foreach(Founder founder in this._university.Founders){
        founderNames.Add(founder.Name);
        }

        founderNames = this._university.Founders.Select(founder=> founder.Name).ToList();

        return founderNames;
    }

    public List<string> GetDepartmentNames(){
        List<string> departmentNames = new List<string>();
        // foreach(Department indivDepartment in this._university.Departments){
        //     departmentNames.Add(indivDepartment.Name);
        // }
        
        departmentNames = this._university.Departments.Select(indivDepartment => indivDepartment.Name).ToList();

          return departmentNames;
    }

    public string GetDepartmentWithMostCourses(){
        List<string> deptWithMostCourses = new List<string>();
        deptWithMostCourses = this._university.Departments.Select
        return Null;
    }

    public List<string> GetDepartmentsWithMoreThanTwoCourses(){
        List<string> deptNames = new List<string>();
        foreach(Department dept in this._university.Departments){
            if(dept.Courses.Count > 2){
                deptNames.Add(dept.Name);
            }
        }
          return deptNames;
    }

    public List<string> GetInstructorsTeachingMultipleCourses(){
        return _university.Departments.SelectMany(department => department.Courses)
                                      .GroupBy();
    }
}