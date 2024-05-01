namespace CS162_Chapter12_ProgrammingProblems.FactoryDemo.Classes
{
    public class TeamLeader : Production_Worker
    {
        public int RequiredTrainingHours { get; init; }

        public int AttendedTrainingHours { get; set; }
        public decimal MonthlyBonus { get; set; }

        public TeamLeader()
        {
            RequiredTrainingHours = 0;
            AttendedTrainingHours = 0;
            MonthlyBonus = 0m;
        }

        public TeamLeader(string name, int number, int shift, decimal hourlyPay, int reqTrainingHrs, int attendedHrs, decimal monthlyBonus) : base(name, number, shift, hourlyPay)
        {
            RequiredTrainingHours = reqTrainingHrs;
            AttendedTrainingHours = attendedHrs;
            MonthlyBonus = monthlyBonus;
        }
    }
}
