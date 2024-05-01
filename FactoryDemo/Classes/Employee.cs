namespace CS162_Chapter12_ProgrammingProblems.FactoryDemo.Classes
{
    public class Employee
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Employee()
        {
            Name = "";
            Number = 000000;
        }


        public Employee(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
