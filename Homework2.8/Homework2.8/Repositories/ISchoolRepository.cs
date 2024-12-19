using Homework2._8.DataAccess.Entities;

namespace Homework2._8.Repositories
{
    public interface ISchoolRepository
    {
        void DeleteSchool(Guid Id);
        School ReadSchoolById(Guid Id);
        List<School> ReadSchools();
        void UpdateSchool(School school);
        Guid WriteSchool(School school);

    }
}