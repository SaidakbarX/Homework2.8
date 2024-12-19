using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._8.Services.DTOs;

public class SchoolCreatDto : BaseSchoolDto
{
    public Guid Id { get; set; }
    public string Password { get; set; }
}
