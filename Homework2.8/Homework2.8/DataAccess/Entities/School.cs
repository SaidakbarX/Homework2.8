using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._8.DataAccess.Entities;


public class School
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int CountOfStudent { get; set; }
    public double Rating { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
