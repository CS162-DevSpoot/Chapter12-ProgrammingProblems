namespace CS162_Chapter12_ProgrammingProblems.FactoryClasses
{
    partial class FactoryMain
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
            manageEmployee_Button = new Button();
            manageShifts_Button = new Button();
            viewEarnings_Button = new Button();
            close_Button = new Button();
            SuspendLayout();
            // 
            // manageEmployee_Button
            // 
            manageEmployee_Button.BackColor = Color.SpringGreen;
            manageEmployee_Button.Location = new Point(25, 29);
            manageEmployee_Button.Name = "manageEmployee_Button";
            manageEmployee_Button.Size = new Size(277, 40);
            manageEmployee_Button.TabIndex = 0;
            manageEmployee_Button.Text = "Manage Employees";
            manageEmployee_Button.UseVisualStyleBackColor = false;
            manageEmployee_Button.Click += manageEmployee_Button_Click;
            // 
            // manageShifts_Button
            // 
            manageShifts_Button.BackColor = Color.SpringGreen;
            manageShifts_Button.Location = new Point(25, 75);
            manageShifts_Button.Name = "manageShifts_Button";
            manageShifts_Button.Size = new Size(277, 40);
            manageShifts_Button.TabIndex = 1;
            manageShifts_Button.Text = "Manage Shifts";
            manageShifts_Button.UseVisualStyleBackColor = false;
            // 
            // viewEarnings_Button
            // 
            viewEarnings_Button.BackColor = Color.SpringGreen;
            viewEarnings_Button.Location = new Point(25, 121);
            viewEarnings_Button.Name = "viewEarnings_Button";
            viewEarnings_Button.Size = new Size(277, 40);
            viewEarnings_Button.TabIndex = 2;
            viewEarnings_Button.Text = "Manage Trainings";
            viewEarnings_Button.UseVisualStyleBackColor = false;
            // 
            // close_Button
            // 
            close_Button.BackColor = Color.Tomato;
            close_Button.ForeColor = SystemColors.Control;
            close_Button.Location = new Point(25, 167);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(277, 23);
            close_Button.TabIndex = 3;
            close_Button.Text = "Close";
            close_Button.UseVisualStyleBackColor = false;
            close_Button.Click += close_Button_Click;
            // 
            // FactoryMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(328, 220);
            Controls.Add(close_Button);
            Controls.Add(viewEarnings_Button);
            Controls.Add(manageShifts_Button);
            Controls.Add(manageEmployee_Button);
            Name = "FactoryMain";
            Text = "FactoryMain";
            ResumeLayout(false);
        }

        #endregion

        private Button manageEmployee_Button;
        private Button manageShifts_Button;
        private Button viewEarnings_Button;
        private Button close_Button;
    }
}