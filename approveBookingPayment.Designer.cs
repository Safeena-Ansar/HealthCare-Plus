namespace HealthCare_Plus
{
    partial class approveBookingPayment
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnApprove = new Button();
            txtScheduleCode = new TextBox();
            txtAppointmentDate = new TextBox();
            txtSpeciality = new TextBox();
            txtDoctor = new TextBox();
            txtDepartment = new TextBox();
            panel1 = new Panel();
            txtBookingNumber = new TextBox();
            lblBookingNumber = new Label();
            txtPatient = new TextBox();
            txtAppointmentCharge = new TextBox();
            lblPatient = new Label();
            label2 = new Label();
            lblDate = new Label();
            lblDepartment = new Label();
            lblSpeciality = new Label();
            lblDoctorID = new Label();
            lblScheduleCode = new Label();
            dgvApproveBookingPayment = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApproveBookingPayment).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(286, 681);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 53);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(253, 618);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(126, 20);
            lblWarningMessage.TabIndex = 46;
            lblWarningMessage.Text = "Warning Message";
            lblWarningMessage.Visible = false;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Teal;
            btnApprove.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(445, 681);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(130, 53);
            btnApprove.TabIndex = 7;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // txtScheduleCode
            // 
            txtScheduleCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtScheduleCode.Location = new Point(253, 143);
            txtScheduleCode.Name = "txtScheduleCode";
            txtScheduleCode.Size = new Size(322, 32);
            txtScheduleCode.TabIndex = 1;
            // 
            // txtAppointmentDate
            // 
            txtAppointmentDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAppointmentDate.Location = new Point(253, 415);
            txtAppointmentDate.Name = "txtAppointmentDate";
            txtAppointmentDate.Size = new Size(322, 32);
            txtAppointmentDate.TabIndex = 5;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpeciality.Location = new Point(253, 280);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(322, 32);
            txtSpeciality.TabIndex = 3;
            // 
            // txtDoctor
            // 
            txtDoctor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctor.Location = new Point(253, 211);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(322, 32);
            txtDoctor.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(253, 349);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(322, 32);
            txtDepartment.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBookingNumber);
            panel1.Controls.Add(lblBookingNumber);
            panel1.Controls.Add(txtPatient);
            panel1.Controls.Add(txtAppointmentCharge);
            panel1.Controls.Add(lblPatient);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(txtScheduleCode);
            panel1.Controls.Add(lblDepartment);
            panel1.Controls.Add(txtAppointmentDate);
            panel1.Controls.Add(lblSpeciality);
            panel1.Controls.Add(txtSpeciality);
            panel1.Controls.Add(txtDoctor);
            panel1.Controls.Add(lblDoctorID);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(lblScheduleCode);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 897);
            panel1.TabIndex = 47;
            panel1.Paint += panel1_Paint;
            // 
            // txtBookingNumber
            // 
            txtBookingNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookingNumber.Location = new Point(253, 78);
            txtBookingNumber.Name = "txtBookingNumber";
            txtBookingNumber.Size = new Size(322, 32);
            txtBookingNumber.TabIndex = 80;
            // 
            // lblBookingNumber
            // 
            lblBookingNumber.AutoSize = true;
            lblBookingNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookingNumber.Location = new Point(28, 85);
            lblBookingNumber.Name = "lblBookingNumber";
            lblBookingNumber.Size = new Size(177, 25);
            lblBookingNumber.TabIndex = 81;
            lblBookingNumber.Text = "Booking Number :";
            // 
            // txtPatient
            // 
            txtPatient.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatient.Location = new Point(253, 558);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(322, 32);
            txtPatient.TabIndex = 79;
            // 
            // txtAppointmentCharge
            // 
            txtAppointmentCharge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAppointmentCharge.Location = new Point(253, 486);
            txtAppointmentCharge.Name = "txtAppointmentCharge";
            txtAppointmentCharge.Size = new Size(322, 32);
            txtAppointmentCharge.TabIndex = 78;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatient.Location = new Point(31, 565);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(85, 25);
            lblPatient.TabIndex = 77;
            lblPatient.Text = "Patient :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 493);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 76;
            label2.Text = "Appointment Charge :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(31, 422);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(187, 25);
            lblDate.TabIndex = 73;
            lblDate.Text = "Appointment Date :";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.Location = new Point(31, 356);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(130, 25);
            lblDepartment.TabIndex = 72;
            lblDepartment.Text = "Department :";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpeciality.Location = new Point(31, 287);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(106, 25);
            lblSpeciality.TabIndex = 71;
            lblSpeciality.Text = "Speciality :";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorID.Location = new Point(31, 218);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(84, 25);
            lblDoctorID.TabIndex = 69;
            lblDoctorID.Text = "Doctor :";
            // 
            // lblScheduleCode
            // 
            lblScheduleCode.AutoSize = true;
            lblScheduleCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblScheduleCode.Location = new Point(28, 150);
            lblScheduleCode.Name = "lblScheduleCode";
            lblScheduleCode.Size = new Size(153, 25);
            lblScheduleCode.TabIndex = 68;
            lblScheduleCode.Text = "Schedule Code :";
            // 
            // dgvApproveBookingPayment
            // 
            dgvApproveBookingPayment.AllowUserToAddRows = false;
            dgvApproveBookingPayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvApproveBookingPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApproveBookingPayment.BackgroundColor = Color.LightCyan;
            dgvApproveBookingPayment.BorderStyle = BorderStyle.None;
            dgvApproveBookingPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApproveBookingPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApproveBookingPayment.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApproveBookingPayment.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApproveBookingPayment.EnableHeadersVisualStyles = false;
            dgvApproveBookingPayment.GridColor = SystemColors.Control;
            dgvApproveBookingPayment.Location = new Point(659, 64);
            dgvApproveBookingPayment.Name = "dgvApproveBookingPayment";
            dgvApproveBookingPayment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvApproveBookingPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvApproveBookingPayment.RowHeadersWidth = 51;
            dgvApproveBookingPayment.RowTemplate.Height = 29;
            dgvApproveBookingPayment.Size = new Size(964, 775);
            dgvApproveBookingPayment.TabIndex = 48;
            dgvApproveBookingPayment.CellClick += dgvApproveBookingPayment_CellClick;
            // 
            // approveBookingPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1667, 897);
            Controls.Add(dgvApproveBookingPayment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "approveBookingPayment";
            Text = "approveBookingPayment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApproveBookingPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnApprove;
        private TextBox txtScheduleCode;
        private TextBox txtAppointmentDate;
        private TextBox txtSpeciality;
        private TextBox txtDoctor;
        private TextBox txtDepartment;
        private Panel panel1;
        private DataGridView dgvApproveBookingPayment;
        private TextBox txtPatient;
        private TextBox txtAppointmentCharge;
        private Label lblPatient;
        private Label label2;
        private Label lblDate;
        private Label lblDepartment;
        private Label lblSpeciality;
        private Label lblDoctorID;
        private Label lblScheduleCode;
        private TextBox txtBookingNumber;
        private Label lblBookingNumber;
    }
}