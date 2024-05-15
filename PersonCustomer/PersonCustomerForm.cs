using System.Runtime.CompilerServices;

namespace CS162_Chapter12_ProgrammingProblems.PersonCustomer
{
    public partial class PersonCustomerForm : Form
    {
        public PersonCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomer_Clicked(object snder, EventArgs e)
        {
            getInputs();
        }
        private void getInputs()
        {
            try
            {
                //Person Info
                string name = name_TextBox.Text;
                string phone = phone_TextBox.Text;
                string address = address_TextBox.Text;

                //Customer Info
                int ID = int.Parse(customerID_TextBox.Text);
                bool wantsMail = mailingList_CheckBox.Checked;

                //Preffered Customer Info

                if(purchases_TextBox.Text == "" || purchases_TextBox.Text == " ")
                {
                    loadInfo(name, phone, address, ID, wantsMail);
                }
                else
                {
                    decimal purchases = decimal.Parse(purchases_TextBox.Text);
                    loadInfo(name, phone, address, ID, wantsMail, purchases);
                }

            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void loadInfo(string name, string phone, string address, int id, bool mail)
        {
            Customer newCustomer = new Customer(name, address, phone, mail, id);

            name_Label.Text = newCustomer.Name;
            phone_Label.Text = newCustomer.Phone.ToString();
            address_Label.Text = newCustomer.Address.ToString();
            customerID_Label.Text = newCustomer.customerID.ToString();
            mailingList_Label.Text = newCustomer.MailingList.ToString();
            discount_Label.Text = "N/A";
        }

        private void loadInfo(string name, string phone, string address, int id, bool mail, decimal purchases)
        {
            PerfferedCustomers newCustomer = new PerfferedCustomers(name, address, phone, id, mail, purchases);

            name_Label.Text = newCustomer.Name;
            phone_Label.Text = newCustomer.Phone.ToString();
            address_Label.Text = newCustomer.Address.ToString();
            customerID_Label.Text = newCustomer.customerID.ToString();
            mailingList_Label.Text = newCustomer.MailingList.ToString();
            discount_Label.Text = newCustomer.DiscountLevel.ToString("p");
        }
    }

}
