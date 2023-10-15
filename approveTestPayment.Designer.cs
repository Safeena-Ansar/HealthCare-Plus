namespace HealthCare_Plus
{
    partial class approveTestPayment
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
            txtTestNumber = new TextBox();
            lblTestNumber = new Label();
            lblTestCharge = new Label();
            lblPatientName = new Label();
            lblPatientCode = new Label();
            lblTestCode = new Label();
            dgvApproveTestPayment = new DataGridView();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnApprove = new Button();
            txtTestCode = new TextBox();
            txtTestCharge = new TextBox();
            txtPatientCode = new TextBox();
            txtTestName = new TextBox();
            txtPatientName = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTestName = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvApproveTestPayment).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTestNumber
            // 
            txtTestNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestNumber.Location = new Point(253, 161);
            txtTestNumber.Name = "txtTestNumber";
            txtTestNumber.Size = new Size(322, 32);
            txtTestNumber.TabIndex = 80;
            // 
            // lblTestNumber
            // 
            lblTestNumber.AutoSize = true;
            lblTestNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestNumber.Location = new Point(28, 168);
            lblTestNumber.Name = "lblTestNumber";
            lblTestNumber.Size = new Size(135, 25);
            lblTestNumber.TabIndex = 81;
            lblTestNumber.Text = "Test Number :";
            // 
            // lblTestCharge
            // 
            lblTestCharge.AutoSize = true;
            lblTestCharge.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestCharge.Location = new Point(31, 505);
            lblTestCharge.Name = "lblTestCharge";
            lblTestCharge.Size = new Size(124, 25);
            lblTestCharge.TabIndex = 73;
            lblTestCharge.Text = "Test Charge :";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientName.Location = new Point(31, 439);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(142, 25);
            lblPatientName.TabIndex = 72;
            lblPatientName.Text = "Patient Name :";
            // 
            // lblPatientCode
            // 
            lblPatientCode.AutoSize = true;
            lblPatientCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatientCode.Location = new Point(31, 370);
            lblPatientCode.Name = "lblPatientCode";
            lblPatientCode.Size = new Size(136, 25);
            lblPatientCode.TabIndex = 71;
            lblPatientCode.Text = "Patient Code :";
            // 
            // lblTestCode
            // 
            lblTestCode.AutoSize = true;
            lblTestCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestCode.Location = new Point(28, 233);
            lblTestCode.Name = "lblTestCode";
            lblTestCode.Size = new Size(107, 25);
            lblTestCode.TabIndex = 68;
            lblTestCode.Text = "Test Code :";
            // 
            // dgvApproveTestPayment
            // 
            dgvApproveTestPayment.AllowUserToAddRows = false;
            dgvApproveTestPayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvApproveTestPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApproveTestPayment.BackgroundColor = Color.LightCyan;
            dgvApproveTestPayment.BorderStyle = BorderStyle.None;
            dgvApproveTestPayment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApproveTestPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApproveTestPayment.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApproveTestPayment.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApproveTestPayment.EnableHeadersVisualStyles = false;
            dgvApproveTestPayment.GridColor = SystemColors.Control;
            dgvApproveTestPayment.Location = new Point(653, 62);
            dgvApproveTestPayment.Name = "dgvApproveTestPayment";
            dgvApproveTestPayment.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvApproveTestPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvApproveTestPayment.RowHeadersWidth = 51;
            dgvApproveTestPayment.RowTemplate.Height = 29;
            dgvApproveTestPayment.Size = new Size(964, 775);
            dgvApproveTestPayment.TabIndex = 50;
            dgvApproveTestPayment.CellClick += dgvApproveTestPayment_CellClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(286, 618);
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
            lblWarningMessage.Location = new Point(253, 555);
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
            btnApprove.Location = new Point(445, 618);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(130, 53);
            btnApprove.TabIndex = 7;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // txtTestCode
            // 
            txtTestCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestCode.Location = new Point(253, 226);
            txtTestCode.Name = "txtTestCode";
            txtTestCode.Size = new Size(322, 32);
            txtTestCode.TabIndex = 1;
            // 
            // txtTestCharge
            // 
            txtTestCharge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestCharge.Location = new Point(253, 498);
            txtTestCharge.Name = "txtTestCharge";
            txtTestCharge.Size = new Size(322, 32);
            txtTestCharge.TabIndex = 5;
            // 
            // txtPatientCode
            // 
            txtPatientCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientCode.Location = new Point(253, 363);
            txtPatientCode.Name = "txtPatientCode";
            txtPatientCode.Size = new Size(322, 32);
            txtPatientCode.TabIndex = 3;
            // 
            // txtTestName
            // 
            txtTestName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestName.Location = new Point(253, 294);
            txtTestName.Name = "txtTestName";
            txtTestName.Size = new Size(322, 32);
            txtTestName.TabIndex = 2;
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientName.Location = new Point(253, 432);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(322, 32);
            txtPatientName.TabIndex = 4;
            // 
            // lblTestName
            // 
            lblTestName.AutoSize = true;
            lblTestName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestName.Location = new Point(31, 301);
            lblTestName.Name = "lblTestName";
            lblTestName.Size = new Size(113, 25);
            lblTestName.TabIndex = 69;
            lblTestName.Text = "Test Name :";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTestNumber);
            panel1.Controls.Add(lblTestNumber);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(lblTestCharge);
            panel1.Controls.Add(txtTestCode);
            panel1.Controls.Add(lblPatientName);
            panel1.Controls.Add(txtTestCharge);
            panel1.Controls.Add(lblPatientCode);
            panel1.Controls.Add(txtPatientCode);
            panel1.Controls.Add(txtTestName);
            panel1.Controls.Add(lblTestName);
            panel1.Controls.Add(txtPatientName);
            panel1.Controls.Add(lblTestCode);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 897);
            panel1.TabIndex = 49;
            // 
            // approveTestPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1667, 897);
            Controls.Add(dgvApproveTestPayment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "approveTestPayment";
            Text = "approveTestPayment";
            ((System.ComponentModel.ISupportInitialize)dgvApproveTestPayment).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTestNumber;
        private Label lblTestNumber;
        private Label lblTestCharge;
        private Label lblPatientName;
        private Label lblPatientCode;
        private Label lblTestCode;
        private DataGridView dgvApproveTestPayment;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnApprove;
        private TextBox txtTestCode;
        private TextBox txtTestCharge;
        private TextBox txtPatientCode;
        private TextBox txtTestName;
        private TextBox txtPatientName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTestName;
        private Panel panel1;
    }
}