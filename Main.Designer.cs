namespace CS162_Chapter12_ProgrammingProblems
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            factoryDemo_Button = new Button();
            exit_Button = new Button();
            personCustomer_Button = new Button();
            SuspendLayout();
            // 
            // factoryDemo_Button
            // 
            factoryDemo_Button.Location = new Point(12, 12);
            factoryDemo_Button.Name = "factoryDemo_Button";
            factoryDemo_Button.Size = new Size(214, 23);
            factoryDemo_Button.TabIndex = 0;
            factoryDemo_Button.Text = "Factory Demo";
            factoryDemo_Button.UseVisualStyleBackColor = true;
            factoryDemo_Button.Click += factoryDemo_Button_Click;
            // 
            // exit_Button
            // 
            exit_Button.BackColor = Color.Tomato;
            exit_Button.ForeColor = SystemColors.Control;
            exit_Button.Location = new Point(12, 415);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(214, 23);
            exit_Button.TabIndex = 1;
            exit_Button.Text = "EXIT";
            exit_Button.UseVisualStyleBackColor = false;
            exit_Button.Click += exit_Button_Click;
            // 
            // personCustomer_Button
            // 
            personCustomer_Button.Location = new Point(12, 41);
            personCustomer_Button.Name = "personCustomer_Button";
            personCustomer_Button.Size = new Size(214, 23);
            personCustomer_Button.TabIndex = 2;
            personCustomer_Button.Text = "Person Customer Demo";
            personCustomer_Button.UseVisualStyleBackColor = true;
            personCustomer_Button.Click += personCustomer_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 450);
            Controls.Add(personCustomer_Button);
            Controls.Add(exit_Button);
            Controls.Add(factoryDemo_Button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button factoryDemo_Button;
        private Button exit_Button;
        private Button personCustomer_Button;
    }
}
