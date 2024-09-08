using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._5
{
    public class ContractEmployee : Employee
    {
        public override double Rate { get; set; }
        public override double Salary { get; set; }
        public int Months { get; set; }

        public ContractEmployee(int months)
        {
            Months = months;
        }

        public override void CalculateSalary()
        {
            Salary = Rate / Months;
        }

        public override string GetRole()
        {
            return "Contract Employee";
        }
    }
}
