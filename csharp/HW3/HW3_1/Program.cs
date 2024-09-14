// 3. Создайте базовый класс Employee с общими свойствами, такими как Name, Position, Salary, и методом Work().
// Создайте производные классы Manager, Engineer и Intern. В каждом классе добавьте уникальные методы, 
// например, ManageTeam() для Manager, WriteCode() для Engineer и Assist() для Intern.
// Создайте массив объектов Employee, включающий различные типы сотрудников, и вызовите метод Work() для каждого объекта.

namespace HW3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Manager("John", "Developer", 2000);

            List<Employee> list = new List<Employee>{
                new Manager("John", "Manager", 4000),
                new Engineer("Sam", "Engineer", 3000),
                new Intern("Kate", "Intern", 2000)
            };

            foreach (Employee emp in list)
            {
                emp.Work();
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}