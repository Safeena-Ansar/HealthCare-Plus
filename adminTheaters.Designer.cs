namespace HealthCare_Plus
{
    partial class adminTheaters
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
            cmbTheaterType = new ComboBox();
            dgvTheaters = new DataGridView();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            lblTheaterType = new Label();
            lblTheaterNumber = new Label();
            lblTheaterCapacity = new Label();
            lblTheaterPrice = new Label();
            txtTheaterNumber = new TextBox();
            txtNote = new TextBox();
            txtTheaterCapacity = new TextBox();
            txtTheaterPrice = new TextBox();
            lblNote = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTheaterType
            // 
            cmbTheaterType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTheaterType.FormattingEnabled = true;
            cmbTheaterType.Items.AddRange(new object[] { "Operating Room", "Surgical Suite" });
            cmbTheaterType.Location = new Point(226, 241);
            cmbTheaterType.Name = "cmbTheaterType";
            cmbTheaterType.Size = new Size(322, 33);
            cmbTheaterType.TabIndex = 47;
            // 
            // dgvTheaters
            // 
            dgvTheaters.AllowUserToAddRows = false;
            dgvTheaters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTheaters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheaters.BorderStyle = BorderStyle.None;
            dgvTheaters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTheaters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTheaters.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTheaters.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTheaters.EnableHeadersVisualStyles = false;
            dgvTheaters.GridColor = SystemColors.Control;
            dgvTheaters.Location = new Point(674, 62);
            dgvTheaters.Name = "dgvTheaters";
            dgvTheaters.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTheaters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTheaters.RowHeadersWidth = 51;
            dgvTheaters.RowTemplate.Height = 29;
            dgvTheaters.Size = new Size(970, 788);
            dgvTheaters.TabIndex = 50;
            dgvTheaters.CellClick += dgvTheaters_CellClick;
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
            // lblTheaterType
            // 
            lblTheaterType.AutoSize = true;
            lblTheaterType.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTheaterType.ForeColor = Color.Black;
            lblTheaterType.Location = new Point(28, 244);
            lblTheaterType.Name = "lblTheaterType";
            lblTheaterType.Size = new Size(126, 25);
            lblTheaterType.TabIndex = 24;
            lblTheaterType.Text = "Theater Type";
            // 
            // lblTheaterNumber
            // 
            lblTheaterNumber.AutoSize = true;
            lblTheaterNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTheaterNumber.ForeColor = Color.Black;
            lblTheaterNumber.Location = new Point(28, 189);
            lblTheaterNumber.Name = "lblTheaterNumber";
            lblTheaterNumber.Size = new Size(158, 25);
            lblTheaterNumber.TabIndex = 23;
            lblTheaterNumber.Text = "Theater Number";
            // 
            // lblTheaterCapacity
            // 
            lblTheaterCapacity.AutoSize = true;
            lblTheaterCapacity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTheaterCapacity.ForeColor = Color.Black;
            lblTheaterCapacity.Location = new Point(28, 303);
            lblTheaterCapacity.Name = "lblTheaterCapacity";
            lblTheaterCapacity.Size = new Size(159, 25);
            lblTheaterCapacity.TabIndex = 3;
            lblTheaterCapacity.Text = "Theater Capacity";
            // 
            // lblTheaterPrice
            // 
            lblTheaterPrice.AutoSize = true;
            lblTheaterPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTheaterPrice.ForeColor = Color.Black;
            lblTheaterPrice.Location = new Point(28, 361);
            lblTheaterPrice.Name = "lblTheaterPrice";
            lblTheaterPrice.Size = new Size(128, 25);
            lblTheaterPrice.TabIndex = 26;
            lblTheaterPrice.Text = "Theater Price";
            // 
            // txtTheaterNumber
            // 
            txtTheaterNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheaterNumber.Location = new Point(228, 186);
            txtTheaterNumber.Name = "txtTheaterNumber";
            txtTheaterNumber.Size = new Size(322, 32);
            txtTheaterNumber.TabIndex = 1;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.Location = new Point(228, 411);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(322, 32);
            txtNote.TabIndex = 5;
            // 
            // txtTheaterCapacity
            // 
            txtTheaterCapacity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheaterCapacity.Location = new Point(228, 300);
            txtTheaterCapacity.Name = "txtTheaterCapacity";
            txtTheaterCapacity.Size = new Size(322, 32);
            txtTheaterCapacity.TabIndex = 3;
            // 
            // txtTheaterPrice
            // 
            txtTheaterPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheaterPrice.Location = new Point(228, 358);
            txtTheaterPrice.Name = "txtTheaterPrice";
            txtTheaterPrice.Size = new Size(322, 32);
            txtTheaterPrice.TabIndex = 4;
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
            // panel1
            // 
            panel1.Controls.Add(cmbTheaterType);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblTheaterType);
            panel1.Controls.Add(lblTheaterNumber);
            panel1.Controls.Add(lblTheaterCapacity);
            panel1.Controls.Add(lblTheaterPrice);
            panel1.Controls.Add(txtTheaterNumber);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(txtTheaterCapacity);
            panel1.Controls.Add(txtTheaterPrice);
            panel1.Controls.Add(lblNote);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 944);
            panel1.TabIndex = 49;
            // 
            // adminTheaters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1685, 944);
            Controls.Add(dgvTheaters);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminTheaters";
            Text = "adminTheaters";
            Load += adminTheaters_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheaters).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbTheaterType;
        private DataGridView dgvTheaters;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lblTheaterType;
        private Label lblTheaterNumber;
        private Label lblTheaterCapacity;
        private Label lblTheaterPrice;
        private TextBox txtTheaterNumber;
        private TextBox txtNote;
        private TextBox txtTheaterCapacity;
        private TextBox txtTheaterPrice;
        private Label lblNote;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
    }
}