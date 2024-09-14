namespace HW3._1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working. His position is {Position}. Salary: {Salary}");
        }
    }
}