namespace HealthCare_Plus
{
    partial class adminViewPatientDetails
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
            lblPatientDetailsReport = new Label();
            cmbDepartment = new ComboBox();
            lblRecord = new Label();
            dgvPatient = new DataGridView();
            lblPatient = new Label();
            btnClose = new Button();
            btnLoad = new Button();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
            SuspendLayout();
            // 
            // lblPatientDetailsReport
            // 
            lblPatientDetailsReport.AutoSize = true;
            lblPatientDetailsReport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientDetailsReport.ForeColor = Color.FromArgb(128, 64, 0);
            lblPatientDetailsReport.Location = new Point(273, 36);
            lblPatientDetailsReport.Name = "lblPatientDetailsReport";
            lblPatientDetailsReport.Size = new Size(183, 23);
            lblPatientDetailsReport.TabIndex = 50;
            lblPatientDetailsReport.Text = "PATIENT DETAILS";
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = Color.MistyRose;
            cmbDepartment.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Booking Report", "Test Report" });
            cmbDepartment.Location = new Point(174, 130);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(160, 28);
            cmbDepartment.TabIndex = 52;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecord.ForeColor = Color.Maroon;
            lblRecord.Location = new Point(51, 133);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(117, 20);
            lblRecord.TabIndex = 51;
            lblRecord.Text = "Record Type: ";
            // 
            // dgvPatient
            // 
            dgvPatient.AllowUserToAddRows = false;
            dgvPatient.BackgroundColor = Color.DarkSalmon;
            dgvPatient.BorderStyle = BorderStyle.None;
            dgvPatient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatient.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPatient.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPatient.EnableHeadersVisualStyles = false;
            dgvPatient.GridColor = SystemColors.Control;
            dgvPatient.Location = new Point(51, 188);
            dgvPatient.Name = "dgvPatient";
            dgvPatient.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPatient.RowHeadersWidth = 51;
            dgvPatient.RowTemplate.Height = 29;
            dgvPatient.Size = new Size(658, 457);
            dgvPatient.TabIndex = 53;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatient.ForeColor = Color.FromArgb(128, 64, 0);
            lblPatient.Location = new Point(51, 76);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(183, 23);
            lblPatient.TabIndex = 54;
            lblPatient.Text = "PATIENT DETAILS";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.FlatAppearance.BorderColor = Color.Maroon;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.MistyRose;
            btnClose.Location = new Point(545, 679);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 53);
            btnClose.TabIndex = 55;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Maroon;
            btnLoad.FlatAppearance.BorderColor = Color.Maroon;
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.MistyRose;
            btnLoad.Location = new Point(362, 123);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 38);
            btnLoad.TabIndex = 56;
            btnLoad.Text = "Filter";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.Blue;
            lblWarning.Location = new Point(51, 166);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(177, 19);
            lblWarning.TabIndex = 57;
            lblWarning.Text = "Record Type Is Required";
            lblWarning.Visible = false;
            // 
            // adminViewPatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(767, 770);
            Controls.Add(lblWarning);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(lblPatient);
            Controls.Add(dgvPatient);
            Controls.Add(cmbDepartment);
            Controls.Add(lblRecord);
            Controls.Add(lblPatientDetailsReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminViewPatientDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminViewPatientDetails";
            ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientDetailsReport;
        private ComboBox cmbDepartment;
        private Label lblRecord;
        private DataGridView dgvPatient;
        private Label lblPatient;
        private Button btnClose;
        private Button btnLoad;
        private Label lblWarning;
    }
}