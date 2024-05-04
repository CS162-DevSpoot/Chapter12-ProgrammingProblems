namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public Person()
        {
            Name = "";
            Address = "";
            Phone = 0;
        }

        public Person(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
