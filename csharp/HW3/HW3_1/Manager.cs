namespace HW3._1
{
    public class Manager : Employee
    {
        public Manager(string name, string position, decimal salary)
            : base(name, position, salary) { }

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }

        public override void Work()
        {
            base.Work();
            ManageTeam();
        }
    }
}