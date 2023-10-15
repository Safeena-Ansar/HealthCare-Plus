namespace HealthCare_Plus
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            btnPatient = new Button();
            btnBookingPayment = new Button();
            btnTestPayment = new Button();
            btnPayment = new Button();
            panelPayment = new Panel();
            panelNavBar = new Panel();
            btnSearchDoctor = new Button();
            btnDoctors = new Button();
            btnLogout = new Button();
            panelBottom = new Panel();
            txtEmpID = new TextBox();
            panelTop = new Panel();
            btnUser = new Button();
            panelMain = new Panel();
            panelPayment.SuspendLayout();
            panelNavBar.SuspendLayout();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.Silver;
            btnPatient.Location = new Point(12, 240);
            btnPatient.Margin = new Padding(3, 2, 3, 2);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(156, 28);
            btnPatient.TabIndex = 6;
            btnPatient.Text = "Patients";
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnBookingPayment
            // 
            btnBookingPayment.BackColor = Color.Aquamarine;
            btnBookingPayment.Dock = DockStyle.Top;
            btnBookingPayment.Location = new Point(0, 64);
            btnBookingPayment.Margin = new Padding(3, 2, 3, 2);
            btnBookingPayment.Name = "btnBookingPayment";
            btnBookingPayment.Size = new Size(156, 32);
            btnBookingPayment.TabIndex = 2;
            btnBookingPayment.Text = "Booking Payment";
            btnBookingPayment.UseVisualStyleBackColor = false;
            btnBookingPayment.Click += btnBookingPayment_Click;
            // 
            // btnTestPayment
            // 
            btnTestPayment.BackColor = Color.Aquamarine;
            btnTestPayment.Dock = DockStyle.Top;
            btnTestPayment.Location = new Point(0, 32);
            btnTestPayment.Margin = new Padding(3, 2, 3, 2);
            btnTestPayment.Name = "btnTestPayment";
            btnTestPayment.Size = new Size(156, 32);
            btnTestPayment.TabIndex = 1;
            btnTestPayment.Text = "Test Payment";
            btnTestPayment.UseVisualStyleBackColor = false;
            btnTestPayment.Click += btnTestPayment_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Silver;
            btnPayment.Dock = DockStyle.Top;
            btnPayment.Location = new Point(0, 0);
            btnPayment.Margin = new Padding(3, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(156, 32);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // panelPayment
            // 
            panelPayment.BackColor = Color.Black;
            panelPayment.Controls.Add(btnBookingPayment);
            panelPayment.Controls.Add(btnTestPayment);
            panelPayment.Controls.Add(btnPayment);
            panelPayment.Location = new Point(12, 324);
            panelPayment.Margin = new Padding(3, 2, 3, 2);
            panelPayment.MaximumSize = new Size(156, 96);
            panelPayment.MinimumSize = new Size(156, 32);
            panelPayment.Name = "panelPayment";
            panelPayment.Size = new Size(156, 32);
            panelPayment.TabIndex = 5;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Teal;
            panelNavBar.Controls.Add(panelPayment);
            panelNavBar.Controls.Add(btnSearchDoctor);
            panelNavBar.Controls.Add(btnPatient);
            panelNavBar.Controls.Add(btnDoctors);
            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.Location = new Point(0, 37);
            panelNavBar.Margin = new Padding(3, 2, 3, 2);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(193, 688);
            panelNavBar.TabIndex = 5;
            // 
            // btnSearchDoctor
            // 
            btnSearchDoctor.BackColor = Color.Silver;
            btnSearchDoctor.Location = new Point(12, 198);
            btnSearchDoctor.Margin = new Padding(3, 2, 3, 2);
            btnSearchDoctor.Name = "btnSearchDoctor";
            btnSearchDoctor.Size = new Size(156, 28);
            btnSearchDoctor.TabIndex = 7;
            btnSearchDoctor.Text = "Search Doctor";
            btnSearchDoctor.UseVisualStyleBackColor = false;
            btnSearchDoctor.Click += btnSearchDoctor_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.Silver;
            btnDoctors.Location = new Point(12, 282);
            btnDoctors.Margin = new Padding(3, 2, 3, 2);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(156, 28);
            btnDoctors.TabIndex = 5;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.Location = new Point(12, 373);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(156, 28);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Teal;
            panelBottom.Controls.Add(txtEmpID);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 725);
            panelBottom.Margin = new Padding(3, 2, 3, 2);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1668, 20);
            panelBottom.TabIndex = 8;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(1556, 0);
            txtEmpID.Margin = new Padding(3, 2, 3, 2);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(110, 23);
            txtEmpID.TabIndex = 0;
            txtEmpID.Visible = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Teal;
            panelTop.Controls.Add(btnUser);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1668, 37);
            panelTop.TabIndex = 6;
            // 
            // btnUser
            // 
            btnUser.BackgroundImage = Properties.Resources.defaultimg;
            btnUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Location = new Point(1598, 3);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(60, 32);
            btnUser.TabIndex = 0;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // panelMain
            // 
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Location = new Point(191, 37);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1477, 688);
            panelMain.TabIndex = 7;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 745);
            Controls.Add(panelNavBar);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            panelPayment.ResumeLayout(false);
            panelNavBar.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatient;
        private Button btnBookingPayment;
        private Button btnTestPayment;
        private Button btnPayment;
        private Panel panelPayment;
        private Panel panelNavBar;
        private Button btnSearchDoctor;
        private Button btnDoctors;
        private Button btnLogout;
        private Panel panelBottom;
        private TextBox txtEmpID;
        private Panel panelTop;
        private Button btnUser;
        private Panel panelMain;
    }
}