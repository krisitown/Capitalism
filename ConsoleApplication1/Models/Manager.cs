using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models.Interfaces;

namespace ConsoleApplication1.Models
{
    public class Manager : Employee, IManager
    {
        private IDepartment department;

        public Manager(string firstName, string lastName, decimal salary, IDepartment department) 
            : base(firstName,lastName,salary)
        {
            this.Department = department;
        }

        public IDepartment Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
    }
}
