namespace HealthCare_Plus
{
    partial class adminDoctors
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvDoctor = new DataGridView();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            cmbGender = new ComboBox();
            lblFirstName = new Label();
            lblDoctorID = new Label();
            lblLastName = new Label();
            lblLicenseNumber = new Label();
            txtDoctorID = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            txtContactNumber = new TextBox();
            txtFirstName = new TextBox();
            lblContactNumber = new Label();
            txtLicenseNumber = new TextBox();
            lblGender = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtEmail = new TextBox();
            panel1 = new Panel();
            txtDepartment = new TextBox();
            lblDepartment = new Label();
            txtQualifications = new TextBox();
            lblQualifications = new Label();
            txtSpeciality = new TextBox();
            lblSpeciality = new Label();
            btnViewSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoctor
            // 
            dgvDoctor.AllowUserToAddRows = false;
            dgvDoctor.BorderStyle = BorderStyle.None;
            dgvDoctor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctor.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctor.EnableHeadersVisualStyles = false;
            dgvDoctor.GridColor = SystemColors.Control;
            dgvDoctor.Location = new Point(555, 56);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctor.RowHeadersWidth = 51;
            dgvDoctor.RowTemplate.Height = 29;
            dgvDoctor.Size = new Size(1084, 788);
            dgvDoctor.TabIndex = 46;
            dgvDoctor.CellClick += dgvDoctor_CellClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(209, 743);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 53);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(226, 695);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(126, 20);
            lblWarningMessage.TabIndex = 46;
            lblWarningMessage.Text = "Warning Message";
            lblWarningMessage.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(350, 743);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(73, 743);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 53);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(224, 465);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(254, 33);
            cmbGender.TabIndex = 8;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(24, 114);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 25);
            lblFirstName.TabIndex = 24;
            lblFirstName.Text = "First Name";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorID.Location = new Point(24, 59);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(99, 25);
            lblDoctorID.TabIndex = 23;
            lblDoctorID.Text = "Doctor ID";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(24, 173);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(104, 25);
            lblLastName.TabIndex = 25;
            lblLastName.Text = "Last Name";
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblLicenseNumber.Location = new Point(24, 231);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(155, 25);
            lblLicenseNumber.TabIndex = 26;
            lblLicenseNumber.Text = "License Number";
            // 
            // txtDoctorID
            // 
            txtDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorID.Location = new Point(224, 56);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(254, 32);
            txtDoctorID.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(224, 407);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(254, 32);
            txtAddress.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(224, 170);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(254, 32);
            txtLastName.TabIndex = 3;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumber.Location = new Point(224, 346);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(254, 32);
            txtContactNumber.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(224, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(254, 32);
            txtFirstName.TabIndex = 2;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(24, 349);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(160, 25);
            lblContactNumber.TabIndex = 35;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtLicenseNumber.Location = new Point(224, 228);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(254, 32);
            txtLicenseNumber.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(24, 468);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(78, 25);
            lblGender.TabIndex = 34;
            lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(24, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(135, 25);
            lblEmail.TabIndex = 32;
            lblEmail.Text = "Email Address";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(24, 410);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 25);
            lblAddress.TabIndex = 33;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(224, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 32);
            txtEmail.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewSchedule);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(lblDepartment);
            panel1.Controls.Add(txtQualifications);
            panel1.Controls.Add(lblQualifications);
            panel1.Controls.Add(txtSpeciality);
            panel1.Controls.Add(lblSpeciality);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblDoctorID);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblLicenseNumber);
            panel1.Controls.Add(txtDoctorID);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtContactNumber);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblContactNumber);
            panel1.Controls.Add(txtLicenseNumber);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAddress);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 897);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(224, 629);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(254, 32);
            txtDepartment.TabIndex = 11;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.Location = new Point(24, 632);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(120, 25);
            lblDepartment.TabIndex = 52;
            lblDepartment.Text = "Department";
            // 
            // txtQualifications
            // 
            txtQualifications.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtQualifications.Location = new Point(226, 576);
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(254, 32);
            txtQualifications.TabIndex = 10;
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblQualifications.Location = new Point(26, 579);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(133, 25);
            lblQualifications.TabIndex = 50;
            lblQualifications.Text = "Qualifications";
            // 
            // txtSpeciality
            // 
            txtSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpeciality.Location = new Point(226, 521);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(254, 32);
            txtSpeciality.TabIndex = 9;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpeciality.Location = new Point(26, 524);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(96, 25);
            lblSpeciality.TabIndex = 48;
            lblSpeciality.Text = "Speciality";
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.Teal;
            btnViewSchedule.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewSchedule.ForeColor = Color.White;
            btnViewSchedule.Location = new Point(73, 813);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(407, 53);
            btnViewSchedule.TabIndex = 53;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += btnViewSchedule_Click;
            // 
            // adminDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1667, 897);
            Controls.Add(dgvDoctor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDoctors";
            Text = "adminDoctors";
            Load += adminDoctors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDoctor;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private Button btnUpdate;
        private ComboBox cmbGender;
        private Label lblFirstName;
        private Label lblDoctorID;
        private Label lblLastName;
        private Label lblLicenseNumber;
        private TextBox txtDoctorID;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtContactNumber;
        private TextBox txtFirstName;
        private Label lblContactNumber;
        private TextBox txtLicenseNumber;
        private Label lblGender;
        private Label lblEmail;
        private Label lblAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtEmail;
        private Panel panel1;
        private TextBox txtDepartment;
        private Label lblDepartment;
        private TextBox txtQualifications;
        private Label lblQualifications;
        private TextBox txtSpeciality;
        private Label lblSpeciality;
        private Button btnViewSchedule;
    }
}