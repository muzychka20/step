using System;
using System.Collections.Generic;

namespace ConsoleApp3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee { Rate = 1000 });
            employees.Add(new PartTimeEmployee { Rate = 1000 });
            employees.Add(new ContractEmployee(5) { Rate = 1000 });
            
            foreach(var employee in employees)
            {
                employee.CalculateSalary();
                Console.WriteLine($"Employee: {employee.GetRole()}");
                Console.WriteLine($"Employee salary: {employee.Salary}");
                Console.WriteLine("----------------------------------");
            }            
        }
    }
}
