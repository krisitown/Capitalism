using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models.Interfaces;

namespace ConsoleApplication1.Models
{
    public class CleaningLady : Employee, IEmployee
    {
        public CleaningLady(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
        }
    }
}
