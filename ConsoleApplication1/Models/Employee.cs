using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models.Interfaces;

namespace ConsoleApplication1.Models
{
    public class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private decimal salary;

        public Employee(string firstName, string lastName, decimal salary = 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                //todo
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                //todo
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                //todo
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + "(" + this.Salary + ")";
        }
    }
}
