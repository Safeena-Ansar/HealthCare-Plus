namespace HealthCare_Plus
{
    partial class adminMedicine
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvMedicine = new DataGridView();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            lblMedicineName = new Label();
            lblMedicineCode = new Label();
            lblGenericName = new Label();
            lblCostPrice = new Label();
            txtMedicineCode = new TextBox();
            txtSellingPrice = new TextBox();
            txtGenericName = new TextBox();
            txtMedicineName = new TextBox();
            txtCostPrice = new TextBox();
            lblSellingPrice = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicine
            // 
            dgvMedicine.AllowUserToAddRows = false;
            dgvMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.BorderStyle = BorderStyle.None;
            dgvMedicine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMedicine.ColumnHeadersHeight = 55;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Maroon;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMedicine.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMedicine.EnableHeadersVisualStyles = false;
            dgvMedicine.GridColor = SystemColors.Control;
            dgvMedicine.Location = new Point(715, 62);
            dgvMedicine.Name = "dgvMedicine";
            dgvMedicine.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMedicine.RowHeadersWidth = 51;
            dgvMedicine.RowTemplate.Height = 29;
            dgvMedicine.Size = new Size(898, 788);
            dgvMedicine.TabIndex = 46;
            dgvMedicine.CellClick += dgvMedicine_CellClick;
            dgvMedicine.CellContentClick += dgvMedicine_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(115, 536);
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
            lblWarningMessage.Location = new Point(227, 468);
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
            btnAdd.Location = new Point(419, 536);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(266, 536);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 53);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblMedicineName);
            panel1.Controls.Add(lblMedicineCode);
            panel1.Controls.Add(lblGenericName);
            panel1.Controls.Add(lblCostPrice);
            panel1.Controls.Add(txtMedicineCode);
            panel1.Controls.Add(txtSellingPrice);
            panel1.Controls.Add(txtGenericName);
            panel1.Controls.Add(txtMedicineName);
            panel1.Controls.Add(txtCostPrice);
            panel1.Controls.Add(lblSellingPrice);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 944);
            panel1.TabIndex = 45;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "In Use", "Not In Use" });
            cmbStatus.Location = new Point(227, 408);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(322, 33);
            cmbStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(27, 411);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 25);
            lblStatus.TabIndex = 48;
            lblStatus.Text = "Status";
            // 
            // lblMedicineName
            // 
            lblMedicineName.AutoSize = true;
            lblMedicineName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicineName.ForeColor = Color.Black;
            lblMedicineName.Location = new Point(27, 179);
            lblMedicineName.Name = "lblMedicineName";
            lblMedicineName.Size = new Size(150, 25);
            lblMedicineName.TabIndex = 24;
            lblMedicineName.Text = "Medicine Name";
            // 
            // lblMedicineCode
            // 
            lblMedicineCode.AutoSize = true;
            lblMedicineCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicineCode.ForeColor = Color.Black;
            lblMedicineCode.Location = new Point(27, 124);
            lblMedicineCode.Name = "lblMedicineCode";
            lblMedicineCode.Size = new Size(144, 25);
            lblMedicineCode.TabIndex = 23;
            lblMedicineCode.Text = "Medicine Code";
            // 
            // lblGenericName
            // 
            lblGenericName.AutoSize = true;
            lblGenericName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenericName.ForeColor = Color.Black;
            lblGenericName.Location = new Point(27, 238);
            lblGenericName.Name = "lblGenericName";
            lblGenericName.Size = new Size(137, 25);
            lblGenericName.TabIndex = 25;
            lblGenericName.Text = "Generic Name";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCostPrice.ForeColor = Color.Black;
            lblCostPrice.Location = new Point(27, 296);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(100, 25);
            lblCostPrice.TabIndex = 26;
            lblCostPrice.Text = "Cost Price";
            // 
            // txtMedicineCode
            // 
            txtMedicineCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicineCode.Location = new Point(227, 121);
            txtMedicineCode.Name = "txtMedicineCode";
            txtMedicineCode.Size = new Size(322, 32);
            txtMedicineCode.TabIndex = 1;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSellingPrice.Location = new Point(227, 346);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(322, 32);
            txtSellingPrice.TabIndex = 5;
            // 
            // txtGenericName
            // 
            txtGenericName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenericName.Location = new Point(227, 235);
            txtGenericName.Name = "txtGenericName";
            txtGenericName.Size = new Size(322, 32);
            txtGenericName.TabIndex = 3;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicineName.Location = new Point(227, 176);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(322, 32);
            txtMedicineName.TabIndex = 2;
            // 
            // txtCostPrice
            // 
            txtCostPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCostPrice.Location = new Point(227, 293);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(322, 32);
            txtCostPrice.TabIndex = 4;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellingPrice.ForeColor = Color.Black;
            lblSellingPrice.Location = new Point(27, 353);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(121, 25);
            lblSellingPrice.TabIndex = 32;
            lblSellingPrice.Text = "Selling Price";
            // 
            // adminMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 944);
            Controls.Add(dgvMedicine);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminMedicine";
            Text = "adminMedicine";
            Load += adminMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMedicine;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private Button btnUpdate;
        private Panel panel1;
        private Label lblMedicineName;
        private Label lblMedicineCode;
        private Label lblGenericName;
        private Label lblCostPrice;
        private TextBox txtMedicineCode;
        private TextBox txtSellingPrice;
        private TextBox txtGenericName;
        private TextBox txtMedicineName;
        private TextBox txtCostPrice;
        private Label lblSellingPrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbStatus;
        private Label lblStatus;
    }
}