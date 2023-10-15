namespace HealthCare_Plus
{
    partial class adminDocSchedule
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
            btnAdd = new Button();
            btnUpdate = new Button();
            lblScheduleCode = new Label();
            lblScheduleDate = new Label();
            lblTotalAppointments = new Label();
            txtScheduleCode = new TextBox();
            txtAppointmentCharge = new TextBox();
            txtTotalAppointments = new TextBox();
            lblAppointmentCharge = new Label();
            dgvDoctorSchedule = new DataGridView();
            panel1 = new Panel();
            dtpScheduleDate = new DateTimePicker();
            btnDelete = new Button();
            lblDoctorID = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoctorSchedule).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(204, 593);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 53);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(259, 459);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(126, 20);
            lblWarningMessage.TabIndex = 46;
            lblWarningMessage.Text = "Warning Message";
            lblWarningMessage.Visible = false;
            lblWarningMessage.Click += lblWarningMessage_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(357, 519);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(204, 519);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 53);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblScheduleCode
            // 
            lblScheduleCode.AutoSize = true;
            lblScheduleCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblScheduleCode.ForeColor = Color.Black;
            lblScheduleCode.Location = new Point(44, 234);
            lblScheduleCode.Name = "lblScheduleCode";
            lblScheduleCode.Size = new Size(143, 25);
            lblScheduleCode.TabIndex = 23;
            lblScheduleCode.Text = "Schedule Code";
            // 
            // lblScheduleDate
            // 
            lblScheduleDate.AutoSize = true;
            lblScheduleDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblScheduleDate.ForeColor = Color.Black;
            lblScheduleDate.Location = new Point(44, 293);
            lblScheduleDate.Name = "lblScheduleDate";
            lblScheduleDate.Size = new Size(138, 25);
            lblScheduleDate.TabIndex = 3;
            lblScheduleDate.Text = "Schedule Date";
            // 
            // lblTotalAppointments
            // 
            lblTotalAppointments.AutoSize = true;
            lblTotalAppointments.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAppointments.ForeColor = Color.Black;
            lblTotalAppointments.Location = new Point(44, 354);
            lblTotalAppointments.Name = "lblTotalAppointments";
            lblTotalAppointments.Size = new Size(187, 25);
            lblTotalAppointments.TabIndex = 26;
            lblTotalAppointments.Text = "Total Appointments";
            // 
            // txtScheduleCode
            // 
            txtScheduleCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtScheduleCode.Location = new Point(259, 231);
            txtScheduleCode.Name = "txtScheduleCode";
            txtScheduleCode.Size = new Size(228, 32);
            txtScheduleCode.TabIndex = 1;
            // 
            // txtAppointmentCharge
            // 
            txtAppointmentCharge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAppointmentCharge.Location = new Point(259, 404);
            txtAppointmentCharge.Name = "txtAppointmentCharge";
            txtAppointmentCharge.Size = new Size(228, 32);
            txtAppointmentCharge.TabIndex = 4;
            // 
            // txtTotalAppointments
            // 
            txtTotalAppointments.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAppointments.Location = new Point(259, 351);
            txtTotalAppointments.Name = "txtTotalAppointments";
            txtTotalAppointments.Size = new Size(228, 32);
            txtTotalAppointments.TabIndex = 3;
            // 
            // lblAppointmentCharge
            // 
            lblAppointmentCharge.AutoSize = true;
            lblAppointmentCharge.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppointmentCharge.ForeColor = Color.Black;
            lblAppointmentCharge.Location = new Point(44, 407);
            lblAppointmentCharge.Name = "lblAppointmentCharge";
            lblAppointmentCharge.Size = new Size(199, 25);
            lblAppointmentCharge.TabIndex = 32;
            lblAppointmentCharge.Text = "Appointment Charge";
            // 
            // dgvDoctorSchedule
            // 
            dgvDoctorSchedule.AllowUserToAddRows = false;
            dgvDoctorSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctorSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctorSchedule.BorderStyle = BorderStyle.None;
            dgvDoctorSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDoctorSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctorSchedule.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDoctorSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctorSchedule.EnableHeadersVisualStyles = false;
            dgvDoctorSchedule.GridColor = SystemColors.Control;
            dgvDoctorSchedule.Location = new Point(601, 59);
            dgvDoctorSchedule.Name = "dgvDoctorSchedule";
            dgvDoctorSchedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDoctorSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctorSchedule.RowHeadersWidth = 51;
            dgvDoctorSchedule.RowTemplate.Height = 29;
            dgvDoctorSchedule.Size = new Size(786, 718);
            dgvDoctorSchedule.TabIndex = 52;
            dgvDoctorSchedule.CellClick += dgvDoctorSchedule_CellClick;
            dgvDoctorSchedule.CellContentClick += dgvDoctorSchedule_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpScheduleDate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblDoctorID);
            panel1.Controls.Add(lblScheduleCode);
            panel1.Controls.Add(lblScheduleDate);
            panel1.Controls.Add(lblTotalAppointments);
            panel1.Controls.Add(txtScheduleCode);
            panel1.Controls.Add(txtAppointmentCharge);
            panel1.Controls.Add(txtTotalAppointments);
            panel1.Controls.Add(lblAppointmentCharge);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 917);
            panel1.TabIndex = 51;
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.CustomFormat = "";
            dtpScheduleDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpScheduleDate.Format = DateTimePickerFormat.Short;
            dtpScheduleDate.Location = new Point(259, 287);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.Size = new Size(228, 32);
            dtpScheduleDate.TabIndex = 47;
            dtpScheduleDate.Value = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(357, 593);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 53);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorID.ForeColor = Color.Maroon;
            lblDoctorID.Location = new Point(44, 156);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(99, 25);
            lblDoctorID.TabIndex = 24;
            lblDoctorID.Text = "Doctor ID";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1228, 813);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(159, 53);
            btnClose.TabIndex = 48;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // adminDocSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 917);
            Controls.Add(btnClose);
            Controls.Add(dgvDoctorSchedule);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDocSchedule";
            Text = "adminDocSchedule";
            Load += adminDocSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctorSchedule).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lblScheduleCode;
        private Label lblScheduleDate;
        private Label lblTotalAppointments;
        private TextBox txtScheduleCode;
        private TextBox txtAppointmentCharge;
        private TextBox txtTotalAppointments;
        private Label lblAppointmentCharge;
        private DataGridView dgvDoctorSchedule;
        private Panel panel1;
        private Button btnDelete;
        private Label lblDoctorID;
        private DateTimePicker dtpScheduleDate;
        private Button btnClose;
    }
}