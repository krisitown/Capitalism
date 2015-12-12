using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        decimal Salary { get; }
    }
}
