using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._5
{
    public class FullTimeEmployee : Employee
    {
        public override double Rate { get; set; }
        public override double Salary { get; set; }

        public override void CalculateSalary()
        {
            Salary = Rate * 1;
        }

        public override string GetRole()
        {
            return "Full Time Employee";
        }
    }
}
