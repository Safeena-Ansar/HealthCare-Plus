namespace HealthCare_Plus
{
    partial class UserBookingPayment
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblPaymentApproved = new Label();
            lblPendingPayment = new Label();
            dgvBookingPaymentApproved = new DataGridView();
            dgvBookingPaymentPending = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBookingPaymentApproved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookingPaymentPending).BeginInit();
            SuspendLayout();
            // 
            // lblPaymentApproved
            // 
            lblPaymentApproved.AutoSize = true;
            lblPaymentApproved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaymentApproved.ForeColor = Color.DarkRed;
            lblPaymentApproved.Location = new Point(971, 24);
            lblPaymentApproved.Name = "lblPaymentApproved";
            lblPaymentApproved.Size = new Size(232, 21);
            lblPaymentApproved.TabIndex = 58;
            lblPaymentApproved.Text = "Payment Approved Bookings";
            // 
            // lblPendingPayment
            // 
            lblPendingPayment.AutoSize = true;
            lblPendingPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendingPayment.ForeColor = Color.DarkRed;
            lblPendingPayment.Location = new Point(237, 24);
            lblPendingPayment.Name = "lblPendingPayment";
            lblPendingPayment.Size = new Size(221, 21);
            lblPendingPayment.TabIndex = 57;
            lblPendingPayment.Text = "Payment Pending Bookings";
            // 
            // dgvBookingPaymentApproved
            // 
            dgvBookingPaymentApproved.AllowUserToAddRows = false;
            dgvBookingPaymentApproved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBookingPaymentApproved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingPaymentApproved.BackgroundColor = Color.Azure;
            dgvBookingPaymentApproved.BorderStyle = BorderStyle.None;
            dgvBookingPaymentApproved.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBookingPaymentApproved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBookingPaymentApproved.ColumnHeadersHeight = 55;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Maroon;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvBookingPaymentApproved.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBookingPaymentApproved.EnableHeadersVisualStyles = false;
            dgvBookingPaymentApproved.GridColor = SystemColors.Control;
            dgvBookingPaymentApproved.Location = new Point(775, 65);
            dgvBookingPaymentApproved.Margin = new Padding(3, 2, 3, 2);
            dgvBookingPaymentApproved.Name = "dgvBookingPaymentApproved";
            dgvBookingPaymentApproved.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBookingPaymentApproved.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBookingPaymentApproved.RowHeadersWidth = 51;
            dgvBookingPaymentApproved.RowTemplate.Height = 29;
            dgvBookingPaymentApproved.Size = new Size(632, 559);
            dgvBookingPaymentApproved.TabIndex = 56;
            // 
            // dgvBookingPaymentPending
            // 
            dgvBookingPaymentPending.AllowUserToAddRows = false;
            dgvBookingPaymentPending.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBookingPaymentPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingPaymentPending.BackgroundColor = Color.Azure;
            dgvBookingPaymentPending.BorderStyle = BorderStyle.None;
            dgvBookingPaymentPending.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvBookingPaymentPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvBookingPaymentPending.ColumnHeadersHeight = 55;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Maroon;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvBookingPaymentPending.DefaultCellStyle = dataGridViewCellStyle11;
            dgvBookingPaymentPending.EnableHeadersVisualStyles = false;
            dgvBookingPaymentPending.GridColor = SystemColors.Control;
            dgvBookingPaymentPending.Location = new Point(53, 65);
            dgvBookingPaymentPending.Margin = new Padding(3, 2, 3, 2);
            dgvBookingPaymentPending.Name = "dgvBookingPaymentPending";
            dgvBookingPaymentPending.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvBookingPaymentPending.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvBookingPaymentPending.RowHeadersWidth = 51;
            dgvBookingPaymentPending.RowTemplate.Height = 29;
            dgvBookingPaymentPending.Size = new Size(632, 559);
            dgvBookingPaymentPending.TabIndex = 55;
            // 
            // UserBookingPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1461, 649);
            Controls.Add(lblPaymentApproved);
            Controls.Add(lblPendingPayment);
            Controls.Add(dgvBookingPaymentApproved);
            Controls.Add(dgvBookingPaymentPending);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserBookingPayment";
            Text = "UserBookingPayment";
            ((System.ComponentModel.ISupportInitialize)dgvBookingPaymentApproved).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookingPaymentPending).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentApproved;
        private Label lblPendingPayment;
        private DataGridView dgvBookingPaymentApproved;
        private DataGridView dgvBookingPaymentPending;
    }
}