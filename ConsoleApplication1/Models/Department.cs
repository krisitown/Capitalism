using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models.Interfaces;

namespace ConsoleApplication1.Models
{
    public class Department : IDepartment
    {
        private string name;
        private IList<IEmployee> employees;
        private IManager manager;
        private IList<IDepartment> departments;

        public Department(string name, IManager manager)
        {
            this.Name = name;
            this.Manager = manager;
            departments = new List<IDepartment>();
            employees = new List<IEmployee>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                //todo
                this.name = value;
            }
        }

        public IList<IEmployee> Employees
        {
            get { return this.employees; }
            private set
            {
                this.employees = value;
            }
        }

        public void AddEmployee(IEmployee empl)
        {
            this.employees.Add(empl);
        }

        public IManager Manager {
            get
            {
                return this.manager;
            }
            private set { this.manager = value; }
        }

        public IList<IDepartment> Departments
        {
            get 
            { 
                return this.departments; 
            }
            private set { this.Departments = value; }
        }

        public void AddDepartment(IDepartment department)
        {
            if (department == null)
            {
                throw new ArgumentNullException();
            }
            this.departments.Add(department);
        }

        public void PrintDepartment(int numberOfIdentations = 0)
        {

            Console.WriteLine(new string('\t', numberOfIdentations) + "(" + this.Name + ")");
            foreach (var empl in this.employees)
            {
                Console.WriteLine(
                (new string('\t', numberOfIdentations) + empl));
            }
            foreach (var department in departments)
            {
                department.PrintDepartment(numberOfIdentations+1);
            }
        }
    }
}
