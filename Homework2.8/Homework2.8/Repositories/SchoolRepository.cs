using Homework2._8.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Homework2._8.Repositories;

public class SchoolRepository : ISchoolRepository
{
    private readonly string _path;
    private List<School> _schools;
    public SchoolRepository()
    {
        _path = "../../../DataAccess/Data/School.json";
        _schools = new List<School>();
        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _schools = ReadSchools();
    }

    public void DeleteSchool(Guid Id)
    {
        var deletSchool = ReadSchoolById(Id);
        _schools.Remove(deletSchool);
        SaveDate();
    }

    public School ReadSchoolById(Guid Id)
    {
        foreach(var  school in _schools)
        {
            if (school.Id == Id)
            {
                return school;
            }
        }
        throw new Exception("Bunday School mavjud emas");
    }

    public List<School> ReadSchools()
    {
        var schoolsJson = File.ReadAllText(_path);
        var schools = JsonSerializer.Deserialize<List<School>>(schoolsJson);
        return schools;
    }

    public void UpdateSchool(School school)
    {
        var updateSchool = ReadSchoolById(school.Id);
        var index = _schools.IndexOf(updateSchool);
        _schools[index] = school;
        SaveDate();
    }

    public Guid WriteSchool(School school)
    {
        _schools.Add(school);
        SaveDate();
        return school.Id;
    }
    private void SaveDate()
    {
        var schoolsJson = JsonSerializer.Serialize(_schools);
        File.WriteAllText(_path, schoolsJson);
    }
}
