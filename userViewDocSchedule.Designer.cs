namespace HealthCare_Plus
{
    partial class userViewDocSchedule
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
            btnClose = new Button();
            dgvDoctorSchedule = new DataGridView();
            lblDocDetail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctorSchedule).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(681, 608);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(159, 53);
            btnClose.TabIndex = 53;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvDoctorSchedule
            // 
            dgvDoctorSchedule.AllowUserToAddRows = false;
            dgvDoctorSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctorSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctorSchedule.BackgroundColor = Color.LightCyan;
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
            dgvDoctorSchedule.Location = new Point(70, 122);
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
            dgvDoctorSchedule.Size = new Size(770, 468);
            dgvDoctorSchedule.TabIndex = 54;
            // 
            // lblDocDetail
            // 
            lblDocDetail.AutoSize = true;
            lblDocDetail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocDetail.ForeColor = Color.Maroon;
            lblDocDetail.Location = new Point(295, 27);
            lblDocDetail.Name = "lblDocDetail";
            lblDocDetail.Size = new Size(70, 25);
            lblDocDetail.TabIndex = 55;
            lblDocDetail.Text = "Doctor";
            // 
            // userViewDocSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(917, 713);
            Controls.Add(lblDocDetail);
            Controls.Add(btnClose);
            Controls.Add(dgvDoctorSchedule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userViewDocSchedule";
            Text = "userViewDocSchedule";
            ((System.ComponentModel.ISupportInitialize)dgvDoctorSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private DataGridView dgvDoctorSchedule;
        private Label lblDocDetail;
    }
}