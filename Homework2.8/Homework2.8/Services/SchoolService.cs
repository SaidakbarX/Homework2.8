using Homework2._8.DataAccess.Entities;
using Homework2._8.Repositories;
using Homework2._8.Services.DTOs;

namespace Homework2._8.Services;

public class SchoolService : ISchoolService

{
    private readonly ISchoolRepository _schoolRepository;

    public SchoolService()
    {
        _schoolRepository = new SchoolRepository();
    }
    public Guid AddSchool(SchoolCreatDto school)
    {
        var entity = ConvertToEntity(school);
        var id = _schoolRepository.WriteSchool(entity);
        return id;
    }

    public void DeleteSchool(Guid schoolId)
    {
        _schoolRepository.DeleteSchool(schoolId);

    }

    public SchoolGetDto GetSchoolById(Guid schoolId)
    {
        var school = _schoolRepository.ReadSchoolById(schoolId);
        return ConvertToDto(school);
    }

    public List<SchoolGetDto> GetSchools()
    {
        var schools = _schoolRepository.ReadSchools();
        var newSchool = new List<SchoolGetDto>();
        foreach (var school in schools)
        {
            newSchool.Add(ConvertToDto(school));
        }

       return newSchool;

    }

    public void UpdateSchool(SchoolUpdateDto school)
    {
        var UpdateSchool = GetSchoolById(school.Id);
        _schoolRepository.UpdateSchool(ConvertToEntity(school));
    }
    private School ConvertToEntity(SchoolCreatDto entity)
    {
        return new School
        {
            Name = entity.Name,
            CountOfStudent = entity.CountOfStudent,
            Email = entity.Email,
            Id = Guid.NewGuid(),
            Location = entity.Location,
            Password = entity.Password,
            Phone = entity.Phone,
            Rating = entity.Rating,

        };
    }
    private School ConvertToEntity(SchoolUpdateDto entity)
    {
        return new School
        {
            Name = entity.Name,
            CountOfStudent = entity.CountOfStudent,
            Email = entity.Email,
            Id = entity.Id,
            Location = entity.Location,
            Password = entity.Password,
            Phone = entity.Phone,
            Rating = entity.Rating,

        };
    }
    private SchoolGetDto ConvertToDto(School school)
    {
        return new SchoolGetDto
        {
            Name = school.Name,
            CountOfStudent = school.CountOfStudent,
            Email = school.Email,
            Id = school.Id,
            Location = school.Location,
            Phone = school.Phone,
            Rating = school.Rating,
        };
    }



}
