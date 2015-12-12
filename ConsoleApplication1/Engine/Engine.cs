using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.Persistance;

namespace ConsoleApplication1.Engine
{
    public class Engine
    {
        public Engine()
        {
        }

        public void Run()
        {
            Factory factory = new Factory();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split(' ');
                switch (tokens[0])
                {
                    case "create-company":
                        string companyName = tokens[1];
                        string ceoName = tokens[2] + " " + tokens[3];
                        decimal salary = Decimal.Parse(tokens[4]);
                        Database.departments.Add(factory.CreateDepartment(companyName, ceoName, salary));
                        break;
                    case "create-department":
                        companyName = tokens[1];
                        string departmentName = tokens[2];
                        string managerName = tokens[3] + " " + tokens[4];
                        Department newDepartment = (Department)factory.CreateDepartment(departmentName, managerName, 0,
                            tokens.Length == 6 ? tokens[5] : null);

                        if (tokens.Length == 6)
                        {
                            Database.FindDepartment(tokens[5]).AddDepartment(newDepartment);
                        }
                        else
                        {
                            Database.FindDepartment(companyName).AddDepartment(newDepartment);
                        }

                        Database.departments.Add(newDepartment);
                        break;

                    case "create-employee":
                        string firstName = tokens[1];
                        string lastName = tokens[2];
                        string typeOfWorker = tokens[3];
                        companyName = tokens[4];
                        
                        Employee currentEmployee = (Employee)factory.CreateEmployee(firstName, lastName, typeOfWorker, 0, tokens.Length == 6 ? tokens[5] : null);
                        Database.employees.Add(currentEmployee);
                        if (tokens.Length != 6)
                        {
                            Database.FindDepartment(companyName).AddEmployee(currentEmployee);
                        }                    
                        break;
                    case "show-employees":
                        companyName = tokens[1];
                        Database.FindDepartment(companyName).PrintDepartment(0);
                        break;
                    case "pay-salaries":
                        companyName = tokens[1];
                        //TODO
                        break;
                }
                line = Console.ReadLine();
            }
            string debug = "Pesho";
        }
    }
}
