namespace CS162_Chapter12_ProgrammingProblems.FactoryClasses
{
    public class Production_Worker:Employee
    {
        public int ShiftNumber { get; set; }
        public decimal HourlyRate { get; set; }

        public Production_Worker() {
            ShiftNumber = 0;
            HourlyRate = 0;
        }

        public Production_Worker(string name, int number, int shift, decimal hourlyPay):base(name, number)
        {
            ShiftNumber = shift;
            HourlyRate = hourlyPay;
        }
    }
}
