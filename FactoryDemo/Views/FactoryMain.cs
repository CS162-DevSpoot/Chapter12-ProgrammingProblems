using CS162_Chapter12_ProgrammingProblems.FactoryDemo.Views;

namespace CS162_Chapter12_ProgrammingProblems.FactoryClasses
{
    public partial class FactoryMain : Form
    {
        public FactoryMain()
        {
            InitializeComponent();
        }

        private void manageEmployee_Button_Click(object sender, EventArgs e)
        {
            Form manageForm = new ManageEmployees();
            manageForm.ShowDialog();
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
