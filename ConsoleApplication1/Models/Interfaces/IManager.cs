using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models.Interfaces
{
    public interface IManager : IEmployee
    {
        IDepartment Department { get; } 
    }
}
