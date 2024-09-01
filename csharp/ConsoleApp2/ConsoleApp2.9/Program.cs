/*
Задание 2
Создайте класс Employee, который будет представлять сотрудника.
Класс должен содержать закрытые поля: name(имя), position(должность) и salary(зарплата).
Реализуйте свойства для доступа к этим полям. Добавьте конструктор для инициализации всех полей и метод RaiseSalary,
который увеличивает зарплату на заданный процент.
*/

using System;

namespace ConsoleApp2._9
{
    class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private float salary;
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, string position, int salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public void RaiseSalary(float percentage)
        {
            salary += salary * (percentage / 100);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Employee", "Manager", 1000);
            Console.WriteLine("Salary = " + employee.Salary);
            employee.RaiseSalary(20);
            Console.WriteLine("Salary = " + employee.Salary);
        }
    }
}
