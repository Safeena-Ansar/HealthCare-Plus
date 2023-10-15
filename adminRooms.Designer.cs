namespace HealthCare_Plus
{
    partial class adminRooms
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
            lblRoomType = new Label();
            lblRoomNumber = new Label();
            lblRoomCapacity = new Label();
            lblRoomPrice = new Label();
            txtRoomNumber = new TextBox();
            txtNote = new TextBox();
            txtRoomCapacity = new TextBox();
            txtRoomPrice = new TextBox();
            lblNote = new Label();
            dgvRooms = new DataGridView();
            panel1 = new Panel();
            cmbRoomType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(114, 546);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 53);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(226, 478);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(126, 20);
            lblWarningMessage.TabIndex = 46;
            lblWarningMessage.Text = "Warning Message";
            lblWarningMessage.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(418, 546);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(265, 546);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 53);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomType.ForeColor = Color.Black;
            lblRoomType.Location = new Point(28, 244);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(112, 25);
            lblRoomType.TabIndex = 24;
            lblRoomType.Text = "Room Type";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomNumber.ForeColor = Color.Black;
            lblRoomNumber.Location = new Point(28, 189);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(144, 25);
            lblRoomNumber.TabIndex = 23;
            lblRoomNumber.Text = "Room Number";
            // 
            // lblRoomCapacity
            // 
            lblRoomCapacity.AutoSize = true;
            lblRoomCapacity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomCapacity.ForeColor = Color.Black;
            lblRoomCapacity.Location = new Point(28, 303);
            lblRoomCapacity.Name = "lblRoomCapacity";
            lblRoomCapacity.Size = new Size(145, 25);
            lblRoomCapacity.TabIndex = 3;
            lblRoomCapacity.Text = "Room Capacity";
            // 
            // lblRoomPrice
            // 
            lblRoomPrice.AutoSize = true;
            lblRoomPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomPrice.ForeColor = Color.Black;
            lblRoomPrice.Location = new Point(28, 361);
            lblRoomPrice.Name = "lblRoomPrice";
            lblRoomPrice.Size = new Size(114, 25);
            lblRoomPrice.TabIndex = 26;
            lblRoomPrice.Text = "Room Price";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomNumber.Location = new Point(228, 186);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(322, 32);
            txtRoomNumber.TabIndex = 1;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.Location = new Point(228, 411);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(322, 32);
            txtNote.TabIndex = 5;
            // 
            // txtRoomCapacity
            // 
            txtRoomCapacity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomCapacity.Location = new Point(228, 300);
            txtRoomCapacity.Name = "txtRoomCapacity";
            txtRoomCapacity.Size = new Size(322, 32);
            txtRoomCapacity.TabIndex = 3;
            // 
            // txtRoomPrice
            // 
            txtRoomPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomPrice.Location = new Point(228, 358);
            txtRoomPrice.Name = "txtRoomPrice";
            txtRoomPrice.Size = new Size(322, 32);
            txtRoomPrice.TabIndex = 4;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblNote.ForeColor = Color.Black;
            lblNote.Location = new Point(28, 414);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(56, 25);
            lblNote.TabIndex = 32;
            lblNote.Text = "Note";
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = SystemColors.Control;
            dgvRooms.Location = new Point(656, 62);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowTemplate.Height = 29;
            dgvRooms.Size = new Size(993, 788);
            dgvRooms.TabIndex = 48;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbRoomType);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblRoomType);
            panel1.Controls.Add(lblRoomNumber);
            panel1.Controls.Add(lblRoomCapacity);
            panel1.Controls.Add(lblRoomPrice);
            panel1.Controls.Add(txtRoomNumber);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(txtRoomCapacity);
            panel1.Controls.Add(txtRoomPrice);
            panel1.Controls.Add(lblNote);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 944);
            panel1.TabIndex = 47;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Private", "Ward", "ICU", "PCU" });
            cmbRoomType.Location = new Point(226, 241);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(322, 33);
            cmbRoomType.TabIndex = 47;
            // 
            // adminRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1685, 944);
            Controls.Add(dgvRooms);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminRooms";
            Text = "adminRooms";
            Load += adminRooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
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
        private Label lblRoomType;
        private Label lblRoomNumber;
        private Label lblRoomCapacity;
        private Label lblRoomPrice;
        private TextBox txtRoomNumber;
        private TextBox txtNote;
        private TextBox txtRoomCapacity;
        private TextBox txtRoomPrice;
        private Label lblNote;
        private DataGridView dgvRooms;
        private Panel panel1;
        private ComboBox cmbRoomType;
    }
}