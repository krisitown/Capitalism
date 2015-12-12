using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.Models.Interfaces;
using ConsoleApplication1.Persistance;

namespace ConsoleApplication1.Engine
{
    public class Factory
    {
        public IEmployee CreateEmployee(string firstName, string lastName, string typeOfWorker, decimal salary = 0, string departmentName = null)
        {
            Department currentDepartment = new Department(null,null);
            if (departmentName != null)
            {
                currentDepartment = (Department)Database.FindDepartment(departmentName);
            }
            switch (typeOfWorker)
            {
                case "Manager":
                    return new Manager(firstName, lastName, salary, currentDepartment);
                case "Regular":
                    return new Employee(firstName,lastName);
                case "CleaningLady":
                    return new CleaningLady(firstName, lastName, salary);
                case "Salesman":
                    return new Salesman(firstName, lastName, salary);
                case "Accountant":
                    return new Accountant(firstName, lastName, salary);
                case "ChiefTelephoneOfficer":
                    return new ChiefTelephoneOfficer(firstName, lastName, salary);
            }
            throw new ArgumentException();
        }

        public IDepartment CreateDepartment(string name, string managerName, decimal salary = 0, string departmentName = null)
        {
            string[] managerNames = managerName.Split(' ');
            Manager currentEmployee = (Manager)Database.FindEmployee(managerNames[0], managerNames[1]);
            if (currentEmployee == null)
            {
                currentEmployee = new Manager(managerNames[0], managerNames[1], salary, null);
            }
            Department newDepartment = new Department(name, currentEmployee);
            currentEmployee.Department = newDepartment;
            newDepartment.AddEmployee(currentEmployee);
            return newDepartment;
        }
    }
}
