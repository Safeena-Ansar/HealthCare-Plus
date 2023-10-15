namespace HealthCare_Plus
{
    partial class userPatient
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
            dgvPatients = new DataGridView();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnAdd = new Button();
            dtpDateOfBirth = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            txtEContactName = new TextBox();
            lblEContactName = new Label();
            txtEContactNumber = new TextBox();
            lblEContactNumber = new Label();
            cmbGender = new ComboBox();
            lblFirstName = new Label();
            lblPatientCode = new Label();
            lblDateOfBirth = new Label();
            lblLastName = new Label();
            txtPatientCode = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtContactNumber = new TextBox();
            txtFirstName = new TextBox();
            lblContactNumber = new Label();
            lblGender = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.BackgroundColor = Color.LightCyan;
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = SystemColors.Control;
            dgvPatients.Location = new Point(567, 59);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 29;
            dgvPatients.Size = new Size(1084, 788);
            dgvPatients.TabIndex = 48;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(207, 730);
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
            lblWarningMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(224, 675);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(133, 20);
            lblWarningMessage.TabIndex = 46;
            lblWarningMessage.Text = "Warning Message";
            lblWarningMessage.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(348, 730);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "";
            dtpDateOfBirth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(224, 335);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(254, 32);
            dtpDateOfBirth.TabIndex = 6;
            dtpDateOfBirth.Value = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(24, 529);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 51;
            label1.Text = "Emergency Contact Details";
            // 
            // txtEContactName
            // 
            txtEContactName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEContactName.Location = new Point(224, 627);
            txtEContactName.Name = "txtEContactName";
            txtEContactName.Size = new Size(254, 32);
            txtEContactName.TabIndex = 49;
            // 
            // lblEContactName
            // 
            lblEContactName.AutoSize = true;
            lblEContactName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblEContactName.Location = new Point(24, 630);
            lblEContactName.Name = "lblEContactName";
            lblEContactName.Size = new Size(138, 25);
            lblEContactName.TabIndex = 50;
            lblEContactName.Text = "Contact Name";
            // 
            // txtEContactNumber
            // 
            txtEContactNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEContactNumber.Location = new Point(224, 567);
            txtEContactNumber.Name = "txtEContactNumber";
            txtEContactNumber.Size = new Size(254, 32);
            txtEContactNumber.TabIndex = 9;
            // 
            // lblEContactNumber
            // 
            lblEContactNumber.AutoSize = true;
            lblEContactNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblEContactNumber.Location = new Point(24, 570);
            lblEContactNumber.Name = "lblEContactNumber";
            lblEContactNumber.Size = new Size(160, 25);
            lblEContactNumber.TabIndex = 48;
            lblEContactNumber.Text = "Contact Number";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(224, 400);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(254, 33);
            cmbGender.TabIndex = 7;
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
            // lblPatientCode
            // 
            lblPatientCode.AutoSize = true;
            lblPatientCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientCode.Location = new Point(24, 59);
            lblPatientCode.Name = "lblPatientCode";
            lblPatientCode.Size = new Size(126, 25);
            lblPatientCode.TabIndex = 23;
            lblPatientCode.Text = "Patient Code";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(24, 341);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(128, 25);
            lblDateOfBirth.TabIndex = 41;
            lblDateOfBirth.Text = "Date Of Birth";
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
            // txtPatientCode
            // 
            txtPatientCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientCode.Location = new Point(224, 56);
            txtPatientCode.Name = "txtPatientCode";
            txtPatientCode.Size = new Size(254, 32);
            txtPatientCode.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(224, 461);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(254, 32);
            txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(224, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 32);
            txtEmail.TabIndex = 5;
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
            txtContactNumber.Location = new Point(224, 229);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(254, 32);
            txtContactNumber.TabIndex = 4;
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
            lblContactNumber.Location = new Point(24, 232);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(160, 25);
            lblContactNumber.TabIndex = 35;
            lblContactNumber.Text = "Contact Number";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(24, 403);
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
            lblAddress.Location = new Point(24, 464);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 25);
            lblAddress.TabIndex = 33;
            lblAddress.Text = "Address";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEContactName);
            panel1.Controls.Add(lblEContactName);
            panel1.Controls.Add(txtEContactNumber);
            panel1.Controls.Add(lblEContactNumber);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblPatientCode);
            panel1.Controls.Add(lblDateOfBirth);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtPatientCode);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtContactNumber);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(lblContactNumber);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAddress);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 918);
            panel1.TabIndex = 47;
            // 
            // userPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1688, 918);
            Controls.Add(dgvPatients);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userPatient";
            Text = "userPatient";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPatients;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private DateTimePicker dtpDateOfBirth;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox txtEContactName;
        private Label lblEContactName;
        private TextBox txtEContactNumber;
        private Label lblEContactNumber;
        private ComboBox cmbGender;
        private Label lblFirstName;
        private Label lblPatientCode;
        private Label lblDateOfBirth;
        private Label lblLastName;
        private TextBox txtPatientCode;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtContactNumber;
        private TextBox txtFirstName;
        private Label lblContactNumber;
        private Label lblGender;
        private Label lblEmail;
        private Label lblAddress;
        private Panel panel1;
    }
}