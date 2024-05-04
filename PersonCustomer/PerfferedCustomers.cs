namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public class PerfferedCustomers:Customer
    {
        decimal PurchasedTotal { get; set; }
        decimal DiscountLevel { get; set; }

        public PerfferedCustomers() : base()
        {
            PurchasedTotal = 0m;
            DiscountLevel = 0;
        }

        public PerfferedCustomers(string name, string address, int phone, bool mailList, decimal purchased, decimal discountLevel):base(name, address, phone, mailList)
        {
            PurchasedTotal = purchased;
            DiscountLevel = discountLevel;
        } 
        private decimal getDiscountLevel()
        {
            return 0m;
        }
    }
}
