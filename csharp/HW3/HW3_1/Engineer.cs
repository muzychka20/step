namespace HW3._1
{
    public class Engineer : Employee
    {
        public Engineer(string name, string position, decimal salary)
            : base(name, position, salary) { }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code.");
        }

        public override void Work()
        {
            base.Work();
            WriteCode();
        }
    }
}
