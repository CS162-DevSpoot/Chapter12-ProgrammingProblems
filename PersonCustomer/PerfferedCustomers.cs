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

        public PerfferedCustomers(string name, string address, int phone, bool mailList, decimal purchased, ):base(name, address, phone, mailList)
        {
            PurchasedTotal = purchased;
            DiscountLevel = getDiscountLevel();
        } 
        private decimal getDiscountLevel()
        {
            if(PurchasedTotal >= 2000)
            {
                return 0.10m;
            }

            if(PurchasedTotal >= 1500)
            {
                return 0.07m;
            }

            if(PurchasedTotal >= 1000)
            {
                return 0.06m;
            } 

            if(PurchasedTotal >= 500)
            {
                return 0.05m;
            }



            return 0m;
        }
    }
}
