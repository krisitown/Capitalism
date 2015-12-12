using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models.Interfaces
{
    public interface IDepartment
    {
        string Name { get; }
        IList<IEmployee> Employees { get; }
        IManager Manager { get; }
        IList<IDepartment> Departments { get; }
        void AddDepartment(IDepartment department);
        void AddEmployee(IEmployee empl);
        void PrintDepartment(int numberOfIndentations);
    }
}
