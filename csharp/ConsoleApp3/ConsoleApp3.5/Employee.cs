using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._5
{
    public abstract class Employee
    {
        public abstract double Rate { get; set; }
        public abstract double Salary { get; set; }
        public abstract void CalculateSalary();
        public abstract string GetRole();
    }
}
