namespace HealthCare_Plus
{
    partial class adminTestings
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
            lblTestCost = new Label();
            btnClear = new Button();
            lblWarningMessage = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            lblTestingCode = new Label();
            lblTestingName = new Label();
            lblDescription = new Label();
            lblNormalRange = new Label();
            txtTestingName = new TextBox();
            txtTurnAroundTime = new TextBox();
            txtDescription = new TextBox();
            txtTestingCode = new TextBox();
            txtNormalRange = new TextBox();
            lblTurnAroundTime = new Label();
            dgvTestings = new DataGridView();
            panel1 = new Panel();
            txtTestCost = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTestings).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTestCost
            // 
            lblTestCost.AutoSize = true;
            lblTestCost.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestCost.ForeColor = Color.Black;
            lblTestCost.Location = new Point(27, 411);
            lblTestCost.Name = "lblTestCost";
            lblTestCost.Size = new Size(90, 25);
            lblTestCost.TabIndex = 48;
            lblTestCost.Text = "Test Cost";
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
            // lblTestingCode
            // 
            lblTestingCode.AutoSize = true;
            lblTestingCode.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestingCode.ForeColor = Color.Black;
            lblTestingCode.Location = new Point(27, 179);
            lblTestingCode.Name = "lblTestingCode";
            lblTestingCode.Size = new Size(126, 25);
            lblTestingCode.TabIndex = 24;
            lblTestingCode.Text = "Testing Code";
            // 
            // lblTestingName
            // 
            lblTestingName.AutoSize = true;
            lblTestingName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestingName.ForeColor = Color.Black;
            lblTestingName.Location = new Point(27, 124);
            lblTestingName.Name = "lblTestingName";
            lblTestingName.Size = new Size(132, 25);
            lblTestingName.TabIndex = 23;
            lblTestingName.Text = "Testing Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(27, 238);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 25;
            lblDescription.Text = "Description";
            // 
            // lblNormalRange
            // 
            lblNormalRange.AutoSize = true;
            lblNormalRange.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblNormalRange.ForeColor = Color.Black;
            lblNormalRange.Location = new Point(27, 296);
            lblNormalRange.Name = "lblNormalRange";
            lblNormalRange.Size = new Size(140, 25);
            lblNormalRange.TabIndex = 26;
            lblNormalRange.Text = "Normal Range";
            // 
            // txtTestingName
            // 
            txtTestingName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestingName.Location = new Point(227, 121);
            txtTestingName.Name = "txtTestingName";
            txtTestingName.Size = new Size(322, 32);
            txtTestingName.TabIndex = 1;
            // 
            // txtTurnAroundTime
            // 
            txtTurnAroundTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTurnAroundTime.Location = new Point(227, 346);
            txtTurnAroundTime.Name = "txtTurnAroundTime";
            txtTurnAroundTime.Size = new Size(322, 32);
            txtTurnAroundTime.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(227, 235);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(322, 32);
            txtDescription.TabIndex = 3;
            // 
            // txtTestingCode
            // 
            txtTestingCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestingCode.Location = new Point(227, 176);
            txtTestingCode.Name = "txtTestingCode";
            txtTestingCode.Size = new Size(322, 32);
            txtTestingCode.TabIndex = 2;
            // 
            // txtNormalRange
            // 
            txtNormalRange.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNormalRange.Location = new Point(227, 293);
            txtNormalRange.Name = "txtNormalRange";
            txtNormalRange.Size = new Size(322, 32);
            txtNormalRange.TabIndex = 4;
            // 
            // lblTurnAroundTime
            // 
            lblTurnAroundTime.AutoSize = true;
            lblTurnAroundTime.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnAroundTime.ForeColor = Color.Black;
            lblTurnAroundTime.Location = new Point(27, 353);
            lblTurnAroundTime.Name = "lblTurnAroundTime";
            lblTurnAroundTime.Size = new Size(120, 25);
            lblTurnAroundTime.TabIndex = 32;
            lblTurnAroundTime.Text = "Time To Test";
            // 
            // dgvTestings
            // 
            dgvTestings.AllowUserToAddRows = false;
            dgvTestings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTestings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestings.BorderStyle = BorderStyle.None;
            dgvTestings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestings.ColumnHeadersHeight = 55;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Brown;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTestings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTestings.EnableHeadersVisualStyles = false;
            dgvTestings.GridColor = SystemColors.Control;
            dgvTestings.Location = new Point(730, 62);
            dgvTestings.Name = "dgvTestings";
            dgvTestings.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTestings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTestings.RowHeadersWidth = 51;
            dgvTestings.RowTemplate.Height = 29;
            dgvTestings.Size = new Size(919, 788);
            dgvTestings.TabIndex = 48;
            dgvTestings.CellClick += dgvTestings_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTestCost);
            panel1.Controls.Add(lblTestCost);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblWarningMessage);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblTestingCode);
            panel1.Controls.Add(lblTestingName);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblNormalRange);
            panel1.Controls.Add(txtTestingName);
            panel1.Controls.Add(txtTurnAroundTime);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtTestingCode);
            panel1.Controls.Add(txtNormalRange);
            panel1.Controls.Add(lblTurnAroundTime);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 944);
            panel1.TabIndex = 47;
            // 
            // txtTestCost
            // 
            txtTestCost.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestCost.Location = new Point(227, 408);
            txtTestCost.Name = "txtTestCost";
            txtTestCost.Size = new Size(322, 32);
            txtTestCost.TabIndex = 49;
            // 
            // adminTestings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1685, 944);
            Controls.Add(dgvTestings);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminTestings";
            Text = "adminTestings";
            Load += adminTestings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTestCost;
        private Button btnClear;
        private Label lblWarningMessage;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lblTestingCode;
        private Label lblTestingName;
        private Label lblDescription;
        private Label lblNormalRange;
        private TextBox txtTestingName;
        private TextBox txtTurnAroundTime;
        private TextBox txtDescription;
        private TextBox txtTestingCode;
        private TextBox txtNormalRange;
        private Label lblTurnAroundTime;
        private DataGridView dgvTestings;
        private Panel panel1;
        private TextBox txtTestCost;
    }
}