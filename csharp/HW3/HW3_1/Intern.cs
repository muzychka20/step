namespace HW3._1
{
    public class Intern : Employee
    {
        public Intern(string name, string position, decimal salary)
            : base(name, position, salary) { }

        public void Assist()
        {
            Console.WriteLine($"{Name} is assisting with various tasks.");
        }

        public override void Work()
        {
            base.Work();
            Assist();
        }
    }
}