namespace HealthCare_Plus
{
    partial class adminReport
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
            lblDocReport = new Label();
            dgvDoctor = new DataGridView();
            panel1 = new Panel();
            btnClearFilter = new Button();
            btnLoadReport = new Button();
            cmbGender = new ComboBox();
            cmbSpeciality = new ComboBox();
            cmbDepartment = new ComboBox();
            lblGender = new Label();
            lblSpeciality = new Label();
            lblDepartment = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDocReport
            // 
            lblDocReport.AutoSize = true;
            lblDocReport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocReport.ForeColor = Color.FromArgb(128, 64, 0);
            lblDocReport.Location = new Point(982, 57);
            lblDocReport.Name = "lblDocReport";
            lblDocReport.Size = new Size(194, 23);
            lblDocReport.TabIndex = 0;
            lblDocReport.Text = "DOCTORS REPORT";
            // 
            // dgvDoctor
            // 
            dgvDoctor.AllowUserToAddRows = false;
            dgvDoctor.BackgroundColor = Color.MistyRose;
            dgvDoctor.BorderStyle = BorderStyle.None;
            dgvDoctor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctor.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDoctor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctor.EnableHeadersVisualStyles = false;
            dgvDoctor.GridColor = SystemColors.Control;
            dgvDoctor.Location = new Point(493, 123);
            dgvDoctor.Name = "dgvDoctor";
            dgvDoctor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctor.RowHeadersWidth = 51;
            dgvDoctor.RowTemplate.Height = 29;
            dgvDoctor.Size = new Size(1133, 699);
            dgvDoctor.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearFilter);
            panel1.Controls.Add(btnLoadReport);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(cmbSpeciality);
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblSpeciality);
            panel1.Controls.Add(lblDepartment);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 897);
            panel1.TabIndex = 48;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Maroon;
            btnClearFilter.FlatAppearance.BorderColor = Color.Maroon;
            btnClearFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearFilter.ForeColor = Color.MistyRose;
            btnClearFilter.Location = new Point(30, 537);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(174, 53);
            btnClearFilter.TabIndex = 13;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnLoadReport
            // 
            btnLoadReport.BackColor = Color.Maroon;
            btnLoadReport.FlatAppearance.BorderColor = Color.Maroon;
            btnLoadReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadReport.ForeColor = Color.MistyRose;
            btnLoadReport.Location = new Point(239, 537);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(174, 53);
            btnLoadReport.TabIndex = 12;
            btnLoadReport.Text = "Load Report";
            btnLoadReport.UseVisualStyleBackColor = false;
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.MistyRose;
            cmbGender.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(152, 448);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(261, 28);
            cmbGender.TabIndex = 6;
            // 
            // cmbSpeciality
            // 
            cmbSpeciality.BackColor = Color.MistyRose;
            cmbSpeciality.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSpeciality.FormattingEnabled = true;
            cmbSpeciality.Location = new Point(152, 382);
            cmbSpeciality.Name = "cmbSpeciality";
            cmbSpeciality.Size = new Size(261, 28);
            cmbSpeciality.TabIndex = 5;
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = Color.MistyRose;
            cmbDepartment.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(152, 317);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(261, 28);
            cmbDepartment.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.Maroon;
            lblGender.Location = new Point(30, 451);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(66, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpeciality.ForeColor = Color.Maroon;
            lblSpeciality.Location = new Point(30, 385);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(84, 20);
            lblSpeciality.TabIndex = 1;
            lblSpeciality.Text = "Speciality";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.ForeColor = Color.Maroon;
            lblDepartment.Location = new Point(30, 320);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(101, 20);
            lblDepartment.TabIndex = 0;
            lblDepartment.Text = "Department";
            // 
            // adminReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1667, 897);
            Controls.Add(panel1);
            Controls.Add(dgvDoctor);
            Controls.Add(lblDocReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminReport";
            Text = "adminReport";
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDocReport;
        private DataGridView dgvDoctor;
        private Panel panel1;
        private Label lblDepartment;
        private ComboBox cmbGender;
        private ComboBox cmbSpeciality;
        private ComboBox cmbDepartment;
        private Label lblGender;
        private Label lblSpeciality;
        private Button btnLoadReport;
        private Button btnClearFilter;
    }
}