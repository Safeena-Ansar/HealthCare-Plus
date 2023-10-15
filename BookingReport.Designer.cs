namespace HealthCare_Plus
{
    partial class BookingReport
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
            panel1 = new Panel();
            btnClearFilter = new Button();
            btnLoadReport = new Button();
            cmbGender = new ComboBox();
            cmbDoctor = new ComboBox();
            cmbPatient = new ComboBox();
            lblPaymentStatus = new Label();
            lblDoctor = new Label();
            lblPatient = new Label();
            dgvDoctor = new DataGridView();
            lblDocReport = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearFilter);
            panel1.Controls.Add(btnLoadReport);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(cmbDoctor);
            panel1.Controls.Add(cmbPatient);
            panel1.Controls.Add(lblPaymentStatus);
            panel1.Controls.Add(lblDoctor);
            panel1.Controls.Add(lblPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 850);
            panel1.TabIndex = 54;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Maroon;
            btnClearFilter.FlatAppearance.BorderColor = Color.Maroon;
            btnClearFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearFilter.ForeColor = Color.MistyRose;
            btnClearFilter.Location = new Point(34, 500);
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
            btnLoadReport.Location = new Point(243, 500);
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
            cmbGender.Items.AddRange(new object[] { "Approved", "Pending" });
            cmbGender.Location = new Point(156, 411);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(261, 28);
            cmbGender.TabIndex = 6;
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.MistyRose;
            cmbDoctor.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(156, 345);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(261, 28);
            cmbDoctor.TabIndex = 5;
            // 
            // cmbPatient
            // 
            cmbPatient.BackColor = Color.MistyRose;
            cmbPatient.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(156, 280);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(261, 28);
            cmbPatient.TabIndex = 4;
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaymentStatus.ForeColor = Color.Maroon;
            lblPaymentStatus.Location = new Point(34, 414);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(77, 20);
            lblPaymentStatus.TabIndex = 3;
            lblPaymentStatus.Text = "Payment";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctor.ForeColor = Color.Maroon;
            lblDoctor.Location = new Point(34, 348);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(63, 20);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "Doctor";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatient.ForeColor = Color.Maroon;
            lblPatient.Location = new Point(34, 283);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(64, 20);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Patient";
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
            dgvDoctor.Location = new Point(571, 92);
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
            dgvDoctor.Size = new Size(990, 699);
            dgvDoctor.TabIndex = 53;
            // 
            // lblDocReport
            // 
            lblDocReport.AutoSize = true;
            lblDocReport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocReport.ForeColor = Color.FromArgb(128, 64, 0);
            lblDocReport.Location = new Point(979, 39);
            lblDocReport.Name = "lblDocReport";
            lblDocReport.Size = new Size(192, 23);
            lblDocReport.TabIndex = 52;
            lblDocReport.Text = "BOOKING REPORT";
            // 
            // BookingReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1649, 850);
            Controls.Add(panel1);
            Controls.Add(dgvDoctor);
            Controls.Add(lblDocReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingReport";
            Text = "BookingReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClearFilter;
        private Button btnLoadReport;
        private ComboBox cmbGender;
        private ComboBox cmbDoctor;
        private ComboBox cmbPatient;
        private Label lblPaymentStatus;
        private Label lblDoctor;
        private Label lblPatient;
        private DataGridView dgvDoctor;
        private Label lblDocReport;
    }
}