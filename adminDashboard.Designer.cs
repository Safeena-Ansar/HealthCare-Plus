namespace HealthCare_Plus
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            btnUser = new Button();
            txtEmpID = new TextBox();
            panelTop = new Panel();
            panelMain = new Panel();
            panelBottom = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnEmployee = new Button();
            panelMaster = new Panel();
            btnTheaters = new Button();
            btnRooms = new Button();
            btnTestings = new Button();
            btnMedicine = new Button();
            btnMasters = new Button();
            btnDoctors = new Button();
            panelNavBar = new Panel();
            panelReport = new Panel();
            btnDoctorReport = new Button();
            btnPatientReport = new Button();
            btnTestReport = new Button();
            btnBookingReport = new Button();
            panelPayment = new Panel();
            btnBookingPayment = new Button();
            btnTestPayment = new Button();
            btnPayment = new Button();
            btnSearchDoctor = new Button();
            btnPatient = new Button();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelMaster.SuspendLayout();
            panelNavBar.SuspendLayout();
            panelReport.SuspendLayout();
            panelPayment.SuspendLayout();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.BackgroundImage = Properties.Resources.defaultimg;
            btnUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Location = new Point(1584, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(69, 43);
            btnUser.TabIndex = 0;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(1560, -1);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(125, 27);
            txtEmpID.TabIndex = 0;
            txtEmpID.Visible = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Teal;
            panelTop.Controls.Add(btnUser);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(221, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1685, 49);
            panelTop.TabIndex = 2;
            // 
            // panelMain
            // 
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(221, 49);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1685, 944);
            panelMain.TabIndex = 3;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Teal;
            panelBottom.Controls.Add(txtEmpID);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(221, 966);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1685, 27);
            panelBottom.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.Location = new Point(14, 635);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(178, 37);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Silver;
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(178, 43);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Silver;
            btnEmployee.Location = new Point(14, 451);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(178, 37);
            btnEmployee.TabIndex = 4;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panelMaster
            // 
            panelMaster.BackColor = Color.Black;
            panelMaster.Controls.Add(btnTheaters);
            panelMaster.Controls.Add(btnRooms);
            panelMaster.Controls.Add(btnTestings);
            panelMaster.Controls.Add(btnMedicine);
            panelMaster.Controls.Add(btnMasters);
            panelMaster.Location = new Point(14, 568);
            panelMaster.MaximumSize = new Size(178, 211);
            panelMaster.MinimumSize = new Size(178, 43);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(178, 43);
            panelMaster.TabIndex = 3;
            // 
            // btnTheaters
            // 
            btnTheaters.BackColor = Color.Aquamarine;
            btnTheaters.Dock = DockStyle.Top;
            btnTheaters.Location = new Point(0, 172);
            btnTheaters.Name = "btnTheaters";
            btnTheaters.Size = new Size(178, 43);
            btnTheaters.TabIndex = 4;
            btnTheaters.Text = "Theaters";
            btnTheaters.UseVisualStyleBackColor = false;
            btnTheaters.Click += btnTheaters_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.Aquamarine;
            btnRooms.Dock = DockStyle.Top;
            btnRooms.Location = new Point(0, 129);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(178, 43);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnTestings
            // 
            btnTestings.BackColor = Color.Aquamarine;
            btnTestings.Dock = DockStyle.Top;
            btnTestings.Location = new Point(0, 86);
            btnTestings.Name = "btnTestings";
            btnTestings.Size = new Size(178, 43);
            btnTestings.TabIndex = 2;
            btnTestings.Text = "Testings";
            btnTestings.UseVisualStyleBackColor = false;
            btnTestings.Click += btnTestings_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.BackColor = Color.Aquamarine;
            btnMedicine.Dock = DockStyle.Top;
            btnMedicine.Location = new Point(0, 43);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(178, 43);
            btnMedicine.TabIndex = 1;
            btnMedicine.Text = "Medicine";
            btnMedicine.UseVisualStyleBackColor = false;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // btnMasters
            // 
            btnMasters.BackColor = Color.Silver;
            btnMasters.Dock = DockStyle.Top;
            btnMasters.Location = new Point(0, 0);
            btnMasters.Name = "btnMasters";
            btnMasters.Size = new Size(178, 43);
            btnMasters.TabIndex = 0;
            btnMasters.Text = "Masters";
            btnMasters.UseVisualStyleBackColor = false;
            btnMasters.Click += btnMasters_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.Silver;
            btnDoctors.Location = new Point(14, 395);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(178, 37);
            btnDoctors.TabIndex = 5;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Teal;
            panelNavBar.Controls.Add(panelReport);
            panelNavBar.Controls.Add(panelPayment);
            panelNavBar.Controls.Add(btnSearchDoctor);
            panelNavBar.Controls.Add(btnPatient);
            panelNavBar.Controls.Add(btnDoctors);
            panelNavBar.Controls.Add(panelMaster);
            panelNavBar.Controls.Add(btnEmployee);
            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(221, 993);
            panelNavBar.TabIndex = 1;
            // 
            // panelReport
            // 
            panelReport.Controls.Add(btnDoctorReport);
            panelReport.Controls.Add(btnPatientReport);
            panelReport.Controls.Add(btnTestReport);
            panelReport.Controls.Add(btnBookingReport);
            panelReport.Controls.Add(btnReports);
            panelReport.Location = new Point(14, 507);
            panelReport.Margin = new Padding(3, 4, 3, 4);
            panelReport.MinimumSize = new Size(178, 43);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(178, 43);
            panelReport.TabIndex = 0;
            // 
            // btnDoctorReport
            // 
            btnDoctorReport.BackColor = Color.Aquamarine;
            btnDoctorReport.Dock = DockStyle.Top;
            btnDoctorReport.Location = new Point(0, 172);
            btnDoctorReport.Name = "btnDoctorReport";
            btnDoctorReport.Size = new Size(178, 43);
            btnDoctorReport.TabIndex = 5;
            btnDoctorReport.Text = "Doctor Report";
            btnDoctorReport.UseVisualStyleBackColor = false;
            btnDoctorReport.Click += btnDoctorReport_Click;
            // 
            // btnPatientReport
            // 
            btnPatientReport.BackColor = Color.Aquamarine;
            btnPatientReport.Dock = DockStyle.Top;
            btnPatientReport.Location = new Point(0, 129);
            btnPatientReport.Name = "btnPatientReport";
            btnPatientReport.Size = new Size(178, 43);
            btnPatientReport.TabIndex = 4;
            btnPatientReport.Text = "Patient Report";
            btnPatientReport.UseVisualStyleBackColor = false;
            btnPatientReport.Click += btnPatientReport_Click;
            // 
            // btnTestReport
            // 
            btnTestReport.BackColor = Color.Aquamarine;
            btnTestReport.Dock = DockStyle.Top;
            btnTestReport.Location = new Point(0, 86);
            btnTestReport.Name = "btnTestReport";
            btnTestReport.Size = new Size(178, 43);
            btnTestReport.TabIndex = 3;
            btnTestReport.Text = "Test Report";
            btnTestReport.UseVisualStyleBackColor = false;
            btnTestReport.Click += btnTestReport_Click;
            // 
            // btnBookingReport
            // 
            btnBookingReport.BackColor = Color.Aquamarine;
            btnBookingReport.Dock = DockStyle.Top;
            btnBookingReport.Location = new Point(0, 43);
            btnBookingReport.Name = "btnBookingReport";
            btnBookingReport.Size = new Size(178, 43);
            btnBookingReport.TabIndex = 2;
            btnBookingReport.Text = "Booking Report";
            btnBookingReport.UseVisualStyleBackColor = false;
            btnBookingReport.Click += btnBookingReport_Click;
            // 
            // panelPayment
            // 
            panelPayment.BackColor = Color.Black;
            panelPayment.Controls.Add(btnBookingPayment);
            panelPayment.Controls.Add(btnTestPayment);
            panelPayment.Controls.Add(btnPayment);
            panelPayment.Location = new Point(14, 276);
            panelPayment.MaximumSize = new Size(178, 128);
            panelPayment.MinimumSize = new Size(178, 43);
            panelPayment.Name = "panelPayment";
            panelPayment.Size = new Size(178, 43);
            panelPayment.TabIndex = 5;
            // 
            // btnBookingPayment
            // 
            btnBookingPayment.BackColor = Color.Aquamarine;
            btnBookingPayment.Dock = DockStyle.Top;
            btnBookingPayment.Location = new Point(0, 86);
            btnBookingPayment.Name = "btnBookingPayment";
            btnBookingPayment.Size = new Size(178, 43);
            btnBookingPayment.TabIndex = 2;
            btnBookingPayment.Text = "Booking Payment";
            btnBookingPayment.UseVisualStyleBackColor = false;
            btnBookingPayment.Click += btnBookingPayment_Click;
            // 
            // btnTestPayment
            // 
            btnTestPayment.BackColor = Color.Aquamarine;
            btnTestPayment.Dock = DockStyle.Top;
            btnTestPayment.Location = new Point(0, 43);
            btnTestPayment.Name = "btnTestPayment";
            btnTestPayment.Size = new Size(178, 43);
            btnTestPayment.TabIndex = 1;
            btnTestPayment.Text = "Test Payment";
            btnTestPayment.UseVisualStyleBackColor = false;
            btnTestPayment.Click += button4_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Silver;
            btnPayment.Dock = DockStyle.Top;
            btnPayment.Location = new Point(0, 0);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(178, 43);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += button5_Click;
            // 
            // btnSearchDoctor
            // 
            btnSearchDoctor.BackColor = Color.Silver;
            btnSearchDoctor.Location = new Point(14, 221);
            btnSearchDoctor.Name = "btnSearchDoctor";
            btnSearchDoctor.Size = new Size(178, 37);
            btnSearchDoctor.TabIndex = 7;
            btnSearchDoctor.Text = "Search Doctor";
            btnSearchDoctor.UseVisualStyleBackColor = false;
            btnSearchDoctor.Click += btnSearchDoctor_Click_1;
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.Silver;
            btnPatient.Location = new Point(14, 337);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(178, 37);
            btnPatient.TabIndex = 6;
            btnPatient.Text = "Patients";
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1906, 993);
            Controls.Add(panelBottom);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminDashboard";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelMaster.ResumeLayout(false);
            panelNavBar.ResumeLayout(false);
            panelReport.ResumeLayout(false);
            panelPayment.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnUser;
        private Panel panelTop;
        private Panel panelMain;
        private TextBox txtEmpID;
        private Panel panelBottom;
        private Button btnLogout;
        private Button btnReports;
        private Button btnEmployee;
        private Panel panelMaster;
        private Button btnTheaters;
        private Button btnRooms;
        private Button btnTestings;
        private Button btnMedicine;
        private Button btnMasters;
        private Button btnDoctors;
        private Panel panelNavBar;
        private Button btnPatient;
        private Panel panel1;
        private Button btnSearchDoctor;
        private Panel panelPayment;
        private Button btnBookingPayment;
        private Button btnTestPayment;
        private Button btnPayment;
        private Panel panel2;
        private Button btnPatientReport;
        private Button btnTestReport;
        private Button btnBookingReport;
        private Button btnDoctorReport;
        private Panel panelReport;
    }
}