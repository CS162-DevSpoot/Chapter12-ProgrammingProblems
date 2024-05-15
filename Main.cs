using CS162_Chapter12_ProgrammingProblems.FactoryClasses;
using CS162_Chapter12_ProgrammingProblems.PersonCustomer;
namespace CS162_Chapter12_ProgrammingProblems
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void factoryDemo_Button_Click(object sender, EventArgs e)
        {
            Form factoryDemo = new FactoryMain();
            factoryDemo.Show();
        }

        private void personCustomer_Button_Click(object sender, EventArgs e)
        {
            Form personCustomer = new PersonCustomerForm();
            personCustomer.Show();
        }
    }
}
