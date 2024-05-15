namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public class Customer:Person
    {
        public bool MailingList { get; set; }
        public int customerID { get; set; }

        public Customer() : base()
        {
            MailingList = false;
        }

        public Customer(string name, string address, string phone, bool mailList, int ID):base(name, address, phone)
        {
            MailingList = mailList;
            customerID = ID;
        }
    }
}
