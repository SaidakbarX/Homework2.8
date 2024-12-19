using Homework2._8.Services.DTOs;

namespace Homework2._8.Services;

public interface ISchoolService
{  
    Guid AddSchool (SchoolCreatDto school);
    void DeleteSchool (Guid schoolId);
    void UpdateSchool (SchoolUpdateDto school);
    List<SchoolGetDto> GetSchools();
    SchoolGetDto GetSchoolById (Guid schoolId);

}