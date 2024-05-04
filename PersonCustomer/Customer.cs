namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public class Customer:Person
    {
        public bool MailingList { get; set; }

        public Customer() : base()
        {
            MailingList = false;
        }

        public Customer(string name, string address, int phone, bool mailList):base(name, address, phone)
        {
            MailingList = mailList;
        }
    }
}
