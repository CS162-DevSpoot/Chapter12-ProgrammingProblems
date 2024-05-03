using CS162_Chapter12_ProgrammingProblems.FactoryDemo.Classes;

namespace CS162_Chapter12_ProgrammingProblems.FactoryDemo.Views
{
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }

        List<Production_Worker> productionStaff = new List<Production_Worker>();
        List<TeamLeader> leads = new List<TeamLeader>();
        List<ShiftSupervisor> supervisors = new List<ShiftSupervisor>();

        int selectedROLE = 0;

        private void role_Changed(object sender, EventArgs e)
        {
            RadioButton radioBtt = (RadioButton)sender;
            string selectedRole = radioBtt.Name;

            switch (selectedRole)
            {
                case "production_RadioButton":
                    bonous_TextBox.Enabled = false;
                    monthlyBonous_TextBox.Enabled = false;
                    salary_TextBox.Enabled = false;
                    hrPay_TextBox.Enabled = true;

                    selectedROLE = 0;
                    break;

                case "teamLead_RadioButton":
                    bonous_TextBox.Enabled = false;
                    monthlyBonous_TextBox.Enabled = true;
                    salary_TextBox.Enabled = false;
                    hrPay_TextBox.Enabled = true;

                    selectedROLE = 1;
                    break;

                case "supervisor_RadioButton":
                    bonous_TextBox.Enabled = true;
                    monthlyBonous_TextBox.Enabled = false;
                    salary_TextBox.Enabled = true;
                    hrPay_TextBox.Enabled = false;

                    selectedROLE = 2;
                    break;
            }
        }

        private void addEmployee_Button_Click(object sender, EventArgs e)
        {
            try
            {

                string empName = name_TextBox.Text;
                int empNumber = int.Parse(number_TextBox.Text);


                switch (selectedROLE)
                {
                    case 0:
                        {// Production Worker
                            decimal hourlyPay = decimal.Parse(hrPay_TextBox.Text);
                            Production_Worker newProductionStaff = new Production_Worker(empName, empNumber, 1, hourlyPay);

                            productionStaff.Add(newProductionStaff);

                            break;
                        }

                    case 1:
                        { // Team Leader
                            decimal hourlyPay = decimal.Parse(hrPay_TextBox.Text);
                            decimal monthlyBonous = decimal.Parse(monthlyBonous_TextBox.Text);
                            TeamLeader newTeamLead = new TeamLeader(empName, empNumber, 1, hourlyPay, 18, 0, monthlyBonous);

                            leads.Add(newTeamLead);
                            break;
                        }

                    case 2:
                        { // Shift Supervisor
                            decimal salary = decimal.Parse(salary_TextBox.Text);
                            decimal bonous = decimal.Parse(bonous_TextBox.Text);
                            ShiftSupervisor newSupervisor = new ShiftSupervisor(empName, empNumber, salary, bonous);

                            supervisors.Add(newSupervisor);
                            break;
                        }
                }

                loadAllEmployees();
                MessageBox.Show("Sucessfully added new employee.");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadAllEmployees()
        {
            employees_ListBox.Items.Clear();

            productionStaff.ForEach(staff =>
            {
                employees_ListBox.Items.Add($"[PROD] {staff.Name}");
            });

            leads.ForEach(staff =>
            {
                employees_ListBox.Items.Add($"[LEAD] {staff.Name}");
            });

            supervisors.ForEach(staff =>
            {
                employees_ListBox.Items.Add($"[SUPE] {staff.Name}");
            });
        }

        int? currentSelectedIndex = null;

        private void viewSelectedEmployee(object sender, EventArgs e)
        {
            ListBox senderList = (ListBox)sender;
            string selectedValue = senderList.SelectedItem.ToString();
            string[] empToken = selectedValue.Split();
            int selectedIndex = senderList.SelectedIndex;
            currentSelectedIndex = selectedIndex;

            switch (empToken[0])
            {
                case "[PROD]":
                    {
                        Production_Worker selectedPW = productionStaff[selectedIndex];

                        name_Label.Text = selectedPW.Name;
                        number_Label.Text = selectedPW.Number.ToString();
                        role_Label.Text = "Production-Worker";

                        hrPay_Label.Text = selectedPW.HourlyRate.ToString();
                        monthlyBonous_Label.Text = "N/A";
                        salary_Label.Text = "N/A";
                        bonous_Label.Text = "N/A";

                        break;
                    }

                case "[LEAD]":
                    {

                        TeamLeader selectedLead = leads[selectedIndex];

                        name_Label.Text = selectedLead.Name;
                        number_Label.Text = selectedLead.Number.ToString();
                        role_Label.Text = "Team Lead";

                        hrPay_Label.Text = selectedLead.HourlyRate.ToString("c");
                        monthlyBonous_Label.Text = selectedLead.MonthlyBonus.ToString("c");
                        salary_Label.Text = "N/A";
                        bonous_Label.Text = "N/A";
                        break;
                    }

                case "[SUPE]":
                    {
                        ShiftSupervisor selectedSupervisor= supervisors[selectedIndex];

                        name_Label.Text = selectedSupervisor.Name;
                        number_Label.Text = selectedSupervisor.Number.ToString();
                        role_Label.Text = "Shfit Supervisor";

                        hrPay_Label.Text = "N/A";
                        monthlyBonous_Label.Text = "N/A";
                        salary_Label.Text = selectedSupervisor.Salary.ToString("c");
                        bonous_Label.Text = selectedSupervisor.Bonous.ToString("c");

                        break;
                    }
            }
        }
    }
}
