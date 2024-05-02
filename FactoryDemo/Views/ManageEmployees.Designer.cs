namespace CS162_Chapter12_ProgrammingProblems.FactoryDemo.Views
{
    partial class ManageEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            employees_ListBox = new ListBox();
            groupBox2 = new GroupBox();
            terminate_Button = new Button();
            monthlyBonous_Label = new Label();
            label14 = new Label();
            bonous_Label = new Label();
            label12 = new Label();
            salary_Label = new Label();
            label10 = new Label();
            number_Label = new Label();
            label8 = new Label();
            name_Label = new Label();
            label6 = new Label();
            hrPay_Label = new Label();
            label4 = new Label();
            role_Label = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            bonous_TextBox = new TextBox();
            salary_TextBox = new TextBox();
            monthlyBonous_TextBox = new TextBox();
            number_TextBox = new TextBox();
            name_TextBox = new TextBox();
            hrPay_TextBox = new TextBox();
            groupBox4 = new GroupBox();
            supervisor_RadioButton = new RadioButton();
            teamLead_RadioButton = new RadioButton();
            production_RadioButton = new RadioButton();
            addEmployee_Button = new Button();
            label3 = new Label();
            label7 = new Label();
            label11 = new Label();
            label15 = new Label();
            label17 = new Label();
            label19 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(40, 40, 40);
            groupBox1.Controls.Add(employees_ListBox);
            groupBox1.ForeColor = Color.SpringGreen;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 467);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employees";
            // 
            // employees_ListBox
            // 
            employees_ListBox.BackColor = Color.FromArgb(40, 40, 40);
            employees_ListBox.BorderStyle = BorderStyle.None;
            employees_ListBox.ForeColor = SystemColors.Window;
            employees_ListBox.FormattingEnabled = true;
            employees_ListBox.ItemHeight = 15;
            employees_ListBox.Location = new Point(6, 22);
            employees_ListBox.Name = "employees_ListBox";
            employees_ListBox.Size = new Size(230, 435);
            employees_ListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(terminate_Button);
            groupBox2.Controls.Add(monthlyBonous_Label);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(bonous_Label);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(salary_Label);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(number_Label);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(name_Label);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(hrPay_Label);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(role_Label);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SpringGreen;
            groupBox2.Location = new Point(272, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select An Employee To View Their Infomation";
            // 
            // terminate_Button
            // 
            terminate_Button.ForeColor = Color.Crimson;
            terminate_Button.Location = new Point(145, 181);
            terminate_Button.Name = "terminate_Button";
            terminate_Button.Size = new Size(240, 28);
            terminate_Button.TabIndex = 14;
            terminate_Button.Text = "TERMINATE";
            terminate_Button.UseVisualStyleBackColor = true;
            // 
            // monthlyBonous_Label
            // 
            monthlyBonous_Label.BackColor = Color.FromArgb(25, 25, 25);
            monthlyBonous_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlyBonous_Label.ForeColor = SystemColors.Control;
            monthlyBonous_Label.Location = new Point(15, 181);
            monthlyBonous_Label.Name = "monthlyBonous_Label";
            monthlyBonous_Label.Size = new Size(112, 28);
            monthlyBonous_Label.TabIndex = 13;
            monthlyBonous_Label.Text = "$2,000";
            monthlyBonous_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(15, 158);
            label14.Name = "label14";
            label14.Size = new Size(112, 23);
            label14.TabIndex = 12;
            label14.Text = "MONTHLY BONOUS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bonous_Label
            // 
            bonous_Label.BackColor = Color.FromArgb(25, 25, 25);
            bonous_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bonous_Label.ForeColor = SystemColors.Control;
            bonous_Label.Location = new Point(273, 115);
            bonous_Label.Name = "bonous_Label";
            bonous_Label.Size = new Size(112, 28);
            bonous_Label.TabIndex = 11;
            bonous_Label.Text = "$2,000";
            bonous_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(273, 92);
            label12.Name = "label12";
            label12.Size = new Size(112, 23);
            label12.TabIndex = 10;
            label12.Text = "BONOUS";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // salary_Label
            // 
            salary_Label.BackColor = Color.FromArgb(25, 25, 25);
            salary_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_Label.ForeColor = SystemColors.Control;
            salary_Label.Location = new Point(145, 115);
            salary_Label.Name = "salary_Label";
            salary_Label.Size = new Size(112, 28);
            salary_Label.TabIndex = 9;
            salary_Label.Text = "$95,300";
            salary_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(145, 92);
            label10.Name = "label10";
            label10.Size = new Size(112, 23);
            label10.TabIndex = 8;
            label10.Text = "SALARY";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // number_Label
            // 
            number_Label.BackColor = Color.FromArgb(25, 25, 25);
            number_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number_Label.ForeColor = SystemColors.Control;
            number_Label.Location = new Point(273, 45);
            number_Label.Name = "number_Label";
            number_Label.Size = new Size(112, 28);
            number_Label.TabIndex = 7;
            number_Label.Text = "000000";
            number_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(273, 22);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 6;
            label8.Text = "NUMBER";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_Label
            // 
            name_Label.BackColor = Color.FromArgb(25, 25, 25);
            name_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_Label.ForeColor = SystemColors.Control;
            name_Label.Location = new Point(145, 45);
            name_Label.Name = "name_Label";
            name_Label.Size = new Size(112, 28);
            name_Label.TabIndex = 5;
            name_Label.Text = "John Doe";
            name_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 22);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 4;
            label6.Text = "NAME";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hrPay_Label
            // 
            hrPay_Label.BackColor = Color.FromArgb(25, 25, 25);
            hrPay_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hrPay_Label.ForeColor = SystemColors.Control;
            hrPay_Label.Location = new Point(15, 115);
            hrPay_Label.Name = "hrPay_Label";
            hrPay_Label.Size = new Size(112, 28);
            hrPay_Label.TabIndex = 3;
            hrPay_Label.Text = "$20/hr";
            hrPay_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 92);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 2;
            label4.Text = "HOURLY PAY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // role_Label
            // 
            role_Label.BackColor = Color.FromArgb(25, 25, 25);
            role_Label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role_Label.ForeColor = SystemColors.Control;
            role_Label.Location = new Point(15, 45);
            role_Label.Name = "role_Label";
            role_Label.Size = new Size(112, 28);
            role_Label.TabIndex = 1;
            role_Label.Text = "Production-Worker";
            role_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "ROLE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bonous_TextBox);
            groupBox3.Controls.Add(salary_TextBox);
            groupBox3.Controls.Add(monthlyBonous_TextBox);
            groupBox3.Controls.Add(number_TextBox);
            groupBox3.Controls.Add(name_TextBox);
            groupBox3.Controls.Add(hrPay_TextBox);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(addEmployee_Button);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label19);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.SpringGreen;
            groupBox3.Location = new Point(272, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(398, 225);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add A New Employee";
            // 
            // bonous_TextBox
            // 
            bonous_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            bonous_TextBox.Enabled = false;
            bonous_TextBox.ForeColor = SystemColors.Info;
            bonous_TextBox.Location = new Point(273, 153);
            bonous_TextBox.Name = "bonous_TextBox";
            bonous_TextBox.Size = new Size(112, 23);
            bonous_TextBox.TabIndex = 21;
            // 
            // salary_TextBox
            // 
            salary_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            salary_TextBox.Enabled = false;
            salary_TextBox.ForeColor = SystemColors.Info;
            salary_TextBox.Location = new Point(145, 153);
            salary_TextBox.Name = "salary_TextBox";
            salary_TextBox.Size = new Size(112, 23);
            salary_TextBox.TabIndex = 20;
            // 
            // monthlyBonous_TextBox
            // 
            monthlyBonous_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            monthlyBonous_TextBox.Enabled = false;
            monthlyBonous_TextBox.ForeColor = SystemColors.Info;
            monthlyBonous_TextBox.Location = new Point(15, 153);
            monthlyBonous_TextBox.Name = "monthlyBonous_TextBox";
            monthlyBonous_TextBox.Size = new Size(112, 23);
            monthlyBonous_TextBox.TabIndex = 19;
            // 
            // number_TextBox
            // 
            number_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            number_TextBox.ForeColor = SystemColors.Info;
            number_TextBox.Location = new Point(273, 80);
            number_TextBox.Name = "number_TextBox";
            number_TextBox.Size = new Size(112, 23);
            number_TextBox.TabIndex = 18;
            // 
            // name_TextBox
            // 
            name_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            name_TextBox.ForeColor = SystemColors.Info;
            name_TextBox.Location = new Point(145, 80);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(112, 23);
            name_TextBox.TabIndex = 17;
            // 
            // hrPay_TextBox
            // 
            hrPay_TextBox.BackColor = Color.FromArgb(25, 25, 25);
            hrPay_TextBox.ForeColor = SystemColors.Info;
            hrPay_TextBox.Location = new Point(15, 80);
            hrPay_TextBox.Name = "hrPay_TextBox";
            hrPay_TextBox.Size = new Size(112, 23);
            hrPay_TextBox.TabIndex = 16;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(supervisor_RadioButton);
            groupBox4.Controls.Add(teamLead_RadioButton);
            groupBox4.Controls.Add(production_RadioButton);
            groupBox4.ForeColor = Color.SpringGreen;
            groupBox4.Location = new Point(15, 17);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 37);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Role";
            // 
            // supervisor_RadioButton
            // 
            supervisor_RadioButton.AutoSize = true;
            supervisor_RadioButton.ForeColor = Color.Honeydew;
            supervisor_RadioButton.Location = new Point(278, 12);
            supervisor_RadioButton.Name = "supervisor_RadioButton";
            supervisor_RadioButton.Size = new Size(85, 19);
            supervisor_RadioButton.TabIndex = 2;
            supervisor_RadioButton.Text = "Supervisor";
            supervisor_RadioButton.UseVisualStyleBackColor = true;
            supervisor_RadioButton.Click += role_Changed;
            // 
            // teamLead_RadioButton
            // 
            teamLead_RadioButton.AutoSize = true;
            teamLead_RadioButton.ForeColor = Color.Honeydew;
            teamLead_RadioButton.Location = new Point(143, 12);
            teamLead_RadioButton.Name = "teamLead_RadioButton";
            teamLead_RadioButton.Size = new Size(84, 19);
            teamLead_RadioButton.TabIndex = 1;
            teamLead_RadioButton.Text = "Team Lead";
            teamLead_RadioButton.UseVisualStyleBackColor = true;
            teamLead_RadioButton.Click += role_Changed;
            // 
            // production_RadioButton
            // 
            production_RadioButton.AutoSize = true;
            production_RadioButton.ForeColor = Color.Honeydew;
            production_RadioButton.Location = new Point(6, 12);
            production_RadioButton.Name = "production_RadioButton";
            production_RadioButton.Size = new Size(86, 19);
            production_RadioButton.TabIndex = 0;
            production_RadioButton.Text = "Production";
            production_RadioButton.UseVisualStyleBackColor = true;
            production_RadioButton.Click += role_Changed;
            // 
            // addEmployee_Button
            // 
            addEmployee_Button.ForeColor = Color.MediumAquamarine;
            addEmployee_Button.Location = new Point(15, 188);
            addEmployee_Button.Name = "addEmployee_Button";
            addEmployee_Button.Size = new Size(370, 28);
            addEmployee_Button.TabIndex = 14;
            addEmployee_Button.Text = "ADD EMPLOYEE";
            addEmployee_Button.UseVisualStyleBackColor = true;
            addEmployee_Button.Click += addEmployee_Button_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 12;
            label3.Text = "MONTHLY BONOUS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(273, 127);
            label7.Name = "label7";
            label7.Size = new Size(112, 23);
            label7.TabIndex = 10;
            label7.Text = "BONOUS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(145, 127);
            label11.Name = "label11";
            label11.Size = new Size(112, 23);
            label11.TabIndex = 8;
            label11.Text = "SALARY";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(273, 57);
            label15.Name = "label15";
            label15.Size = new Size(112, 23);
            label15.TabIndex = 6;
            label15.Text = "NUMBER";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(145, 57);
            label17.Name = "label17";
            label17.Size = new Size(112, 23);
            label17.TabIndex = 4;
            label17.Text = "NAME";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(15, 57);
            label19.Name = "label19";
            label19.Size = new Size(112, 23);
            label19.TabIndex = 2;
            label19.Text = "HOURLY PAY";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(683, 490);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.SpringGreen;
            Name = "ManageEmployees";
            Text = "ManageEmployees";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox employees_ListBox;
        private GroupBox groupBox2;
        private Label role_Label;
        private Label label1;
        private Label monthlyBonous_Label;
        private Label label14;
        private Label bonous_Label;
        private Label label12;
        private Label salary_Label;
        private Label label10;
        private Label number_Label;
        private Label label8;
        private Label name_Label;
        private Label label6;
        private Label hrPay_Label;
        private Label label4;
        private Button terminate_Button;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton supervisor_RadioButton;
        private RadioButton teamLead_RadioButton;
        private RadioButton production_RadioButton;
        private Button addEmployee_Button;
        private Label label3;
        private Label label7;
        private Label label11;
        private Label label15;
        private Label label17;
        private Label label19;
        private TextBox bonous_TextBox;
        private TextBox salary_TextBox;
        private TextBox monthlyBonous_TextBox;
        private TextBox number_TextBox;
        private TextBox name_TextBox;
        private TextBox hrPay_TextBox;
    }
}