using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.Models.Interfaces;

namespace ConsoleApplication1.Persistance
{
    static class Database
    {
        public static List<IDepartment> departments = new List<IDepartment>();
        public static List<IEmployee> employees = new List<IEmployee>();

        public static IDepartment FindDepartment(string name)
        {
            foreach (var department in departments)
            {
                if (department.Name == name)
                {
                    return department;
                    
                }
            }
            return null;
        }

        public static IEmployee FindEmployee(string firstName, string lastName)
        {
            foreach (var employee in employees)
            {
                if (employee.FirstName == firstName && employee.LastName == lastName)
                {
                    return employee;   
                }
            }
            return null;
        }
    }
}
