namespace HealthCare_Plus
{
    partial class adminPatientReport
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
            btnLoadReport = new Button();
            dgvPatient = new DataGridView();
            lblPatientReport = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
            SuspendLayout();
            // 
            // btnLoadReport
            // 
            btnLoadReport.BackColor = Color.Maroon;
            btnLoadReport.FlatAppearance.BorderColor = Color.Maroon;
            btnLoadReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadReport.ForeColor = Color.MistyRose;
            btnLoadReport.Location = new Point(1188, 760);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(256, 53);
            btnLoadReport.TabIndex = 12;
            btnLoadReport.Text = "View Patient Details";
            btnLoadReport.UseVisualStyleBackColor = false;
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // dgvPatient
            // 
            dgvPatient.AllowUserToAddRows = false;
            dgvPatient.BackgroundColor = Color.MistyRose;
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
            dgvPatient.Location = new Point(177, 115);
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
            dgvPatient.Size = new Size(1267, 608);
            dgvPatient.TabIndex = 50;
            dgvPatient.CellClick += dgvPatient_CellClick;
            // 
            // lblPatientReport
            // 
            lblPatientReport.AutoSize = true;
            lblPatientReport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientReport.ForeColor = Color.FromArgb(128, 64, 0);
            lblPatientReport.Location = new Point(750, 53);
            lblPatientReport.Name = "lblPatientReport";
            lblPatientReport.Size = new Size(180, 23);
            lblPatientReport.TabIndex = 49;
            lblPatientReport.Text = "PATIENT REPORT";
            // 
            // adminPatientReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1649, 850);
            Controls.Add(btnLoadReport);
            Controls.Add(dgvPatient);
            Controls.Add(lblPatientReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminPatientReport";
            Text = "adminPatientReport";
            ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoadReport;
        private DataGridView dgvPatient;
        private Label lblPatientReport;
    }
}