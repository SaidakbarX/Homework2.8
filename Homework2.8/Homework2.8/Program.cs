using Homework2._8.Services;
using Homework2._8.Services.DTOs;

namespace Homework2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            ISchoolService service = new SchoolService();
            var dto1 = new SchoolCreatDto()
            {

                //Id = Guid.NewGuid(),
                Email = "AFIDUM@gmail.com",
                Location="Sebzor",
                Name = "AFIDUM",
                Phone = "132243131",
                Rating = 4.5,
                CountOfStudent = 300,
                Password = "1234",


            };
            var dto2 = new SchoolUpdateDto()
            {   Id = new Guid("5d2c6516-3589-4755-8b77-c1ea856a3381"),
                Email = "LBShastri@gmail.com",
                Location = "Chorsu",
                Name = "24-maktab",
                Phone = "1322431121",
                Rating = -1,
                CountOfStudent = 300,
                Password = "12455",
            };
            service.UpdateSchool(dto2);


        }
    }
}
