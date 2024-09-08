using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._5
{
    public class PartTimeEmployee : Employee
    {
        public override double Rate { get; set; }
        public override double Salary { get; set; }

        public override void CalculateSalary()
        {
            Salary = Rate * 0.5;
        }

        public override string GetRole()
        {
            return "Part Time Employee";
        }
    }
}
