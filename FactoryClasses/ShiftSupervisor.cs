namespace CS162_Chapter12_ProgrammingProblems.FactoryClasses
{
    public class ShiftSupervisor:Employee
    {
        public decimal Salary { get; set; }
        public decimal Bonous { get; set; }

        public ShiftSupervisor()
        {
            Salary = 0;
            Bonous = 0;
        }

        public ShiftSupervisor(string name, int number, decimal salary, decimal bonous) :base(name, number)
        {
            Salary = salary;
            Bonous = bonous;
        }
    }
}
