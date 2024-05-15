namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Person()
        {
            Name = "";
            Address = "";
            Phone = "";
        }

        public Person(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
