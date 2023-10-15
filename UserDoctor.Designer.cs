namespace HealthCare_Plus
{
    partial class UserDoctor
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
            btnViewSchedule = new Button();
            lblWarningMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).BeginInit();
            SuspendLayout();
            // 
            // dgvDoctor
            // 
            dgvDoctor.AllowUserToAddRows = false;
            dgvDoctor.BackgroundColor = Color.LightCyan;
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
            dgvDoctor.Location = new Point(129, 61);
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
            dgvDoctor.Size = new Size(1453, 721);
            dgvDoctor.TabIndex = 47;
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.Teal;
            btnViewSchedule.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewSchedule.ForeColor = Color.White;
            btnViewSchedule.Location = new Point(1349, 818);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(233, 53);
            btnViewSchedule.TabIndex = 54;
            btnViewSchedule.Text = "View Doctor Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += btnViewSchedule_Click;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(129, 28);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(275, 20);
            lblWarningMessage.TabIndex = 55;
            lblWarningMessage.Text = "Please Select a Doctor to View Schedule";
            lblWarningMessage.Visible = false;
            // 
            // UserDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1688, 918);
            Controls.Add(lblWarningMessage);
            Controls.Add(btnViewSchedule);
            Controls.Add(dgvDoctor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDoctor";
            Text = "UserDoctor";
            ((System.ComponentModel.ISupportInitialize)dgvDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDoctor;
        private Button btnViewSchedule;
        private Label lblWarningMessage;
    }
}