namespace HealthCare_Plus
{
    partial class searchDoctors
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
            dgvSearchDoctor = new DataGridView();
            dtpAppoinmentDate = new DateTimePicker();
            lblDoctorName = new Label();
            lblDoctorID = new Label();
            lblAppoinmentDate = new Label();
            lblDoctorSpeciality = new Label();
            lblDepartment = new Label();
            txtDoctorID = new TextBox();
            txtQualification = new TextBox();
            txtDoctorSpeciality = new TextBox();
            txtDoctorName = new TextBox();
            txtDepartment = new TextBox();
            lblQualification = new Label();
            lblSearchDoctor = new Label();
            btnSearchDoctor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchDoctor).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchDoctor
            // 
            dgvSearchDoctor.AllowUserToAddRows = false;
            dgvSearchDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearchDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchDoctor.BackgroundColor = Color.LightCyan;
            dgvSearchDoctor.BorderStyle = BorderStyle.None;
            dgvSearchDoctor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSearchDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSearchDoctor.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSearchDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSearchDoctor.EnableHeadersVisualStyles = false;
            dgvSearchDoctor.GridColor = SystemColors.Control;
            dgvSearchDoctor.Location = new Point(228, 379);
            dgvSearchDoctor.Name = "dgvSearchDoctor";
            dgvSearchDoctor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSearchDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSearchDoctor.RowHeadersWidth = 51;
            dgvSearchDoctor.RowTemplate.Height = 29;
            dgvSearchDoctor.Size = new Size(1167, 517);
            dgvSearchDoctor.TabIndex = 47;
            dgvSearchDoctor.CellClick += dgvSearchDoctor_CellClick;
            // 
            // dtpAppoinmentDate
            // 
            dtpAppoinmentDate.CustomFormat = "";
            dtpAppoinmentDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAppoinmentDate.Format = DateTimePickerFormat.Short;
            dtpAppoinmentDate.Location = new Point(1047, 234);
            dtpAppoinmentDate.Name = "dtpAppoinmentDate";
            dtpAppoinmentDate.Size = new Size(254, 32);
            dtpAppoinmentDate.TabIndex = 53;
            dtpAppoinmentDate.Value = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorName.Location = new Point(315, 188);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(131, 25);
            lblDoctorName.TabIndex = 56;
            lblDoctorName.Text = "Doctor Name";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorID.Location = new Point(315, 133);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(99, 25);
            lblDoctorID.TabIndex = 55;
            lblDoctorID.Text = "Doctor ID";
            // 
            // lblAppoinmentDate
            // 
            lblAppoinmentDate.AutoSize = true;
            lblAppoinmentDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppoinmentDate.Location = new Point(847, 240);
            lblAppoinmentDate.Name = "lblAppoinmentDate";
            lblAppoinmentDate.Size = new Size(170, 25);
            lblAppoinmentDate.TabIndex = 61;
            lblAppoinmentDate.Text = "Appoinment Date";
            // 
            // lblDoctorSpeciality
            // 
            lblDoctorSpeciality.AutoSize = true;
            lblDoctorSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorSpeciality.Location = new Point(315, 247);
            lblDoctorSpeciality.Name = "lblDoctorSpeciality";
            lblDoctorSpeciality.Size = new Size(163, 25);
            lblDoctorSpeciality.TabIndex = 57;
            lblDoctorSpeciality.Text = "Doctor Speciality";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.Location = new Point(847, 130);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(120, 25);
            lblDepartment.TabIndex = 58;
            lblDepartment.Text = "Department";
            // 
            // txtDoctorID
            // 
            txtDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorID.Location = new Point(515, 130);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(254, 32);
            txtDoctorID.TabIndex = 1;
            // 
            // txtQualification
            // 
            txtQualification.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtQualification.Location = new Point(1047, 180);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(254, 32);
            txtQualification.TabIndex = 52;
            // 
            // txtDoctorSpeciality
            // 
            txtDoctorSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorSpeciality.Location = new Point(515, 244);
            txtDoctorSpeciality.Name = "txtDoctorSpeciality";
            txtDoctorSpeciality.Size = new Size(254, 32);
            txtDoctorSpeciality.TabIndex = 3;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorName.Location = new Point(515, 185);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(254, 32);
            txtDoctorName.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartment.Location = new Point(1047, 127);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(254, 32);
            txtDepartment.TabIndex = 4;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblQualification.Location = new Point(847, 187);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(125, 25);
            lblQualification.TabIndex = 59;
            lblQualification.Text = "Qualification";
            // 
            // lblSearchDoctor
            // 
            lblSearchDoctor.AutoSize = true;
            lblSearchDoctor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearchDoctor.ForeColor = Color.DarkRed;
            lblSearchDoctor.Location = new Point(734, 54);
            lblSearchDoctor.Name = "lblSearchDoctor";
            lblSearchDoctor.Size = new Size(198, 37);
            lblSearchDoctor.TabIndex = 62;
            lblSearchDoctor.Text = "Search Doctor";
            // 
            // btnSearchDoctor
            // 
            btnSearchDoctor.BackColor = Color.Teal;
            btnSearchDoctor.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchDoctor.ForeColor = Color.White;
            btnSearchDoctor.Location = new Point(1121, 300);
            btnSearchDoctor.Name = "btnSearchDoctor";
            btnSearchDoctor.Size = new Size(180, 53);
            btnSearchDoctor.TabIndex = 63;
            btnSearchDoctor.Text = "Search Doctor";
            btnSearchDoctor.UseVisualStyleBackColor = false;
            btnSearchDoctor.Click += btnSearchDoctor_Click;
            // 
            // searchDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1685, 944);
            Controls.Add(btnSearchDoctor);
            Controls.Add(lblSearchDoctor);
            Controls.Add(dtpAppoinmentDate);
            Controls.Add(lblDoctorName);
            Controls.Add(lblDoctorID);
            Controls.Add(lblAppoinmentDate);
            Controls.Add(lblDoctorSpeciality);
            Controls.Add(lblDepartment);
            Controls.Add(txtDoctorID);
            Controls.Add(txtQualification);
            Controls.Add(txtDoctorSpeciality);
            Controls.Add(txtDoctorName);
            Controls.Add(txtDepartment);
            Controls.Add(lblQualification);
            Controls.Add(dgvSearchDoctor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "searchDoctors";
            Text = "searchDoctors";
            ((System.ComponentModel.ISupportInitialize)dgvSearchDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSearchDoctor;
        private DateTimePicker dtpAppoinmentDate;
        private Label lblDoctorName;
        private Label lblDoctorID;
        private Label lblAppoinmentDate;
        private Label lblDoctorSpeciality;
        private Label lblDepartment;
        private TextBox txtDoctorID;
        private TextBox txtQualification;
        private TextBox txtDoctorSpeciality;
        private TextBox txtDoctorName;
        private TextBox txtDepartment;
        private Label lblQualification;
        private Label lblSearchDoctor;
        private Button btnSearchDoctor;
    }
}