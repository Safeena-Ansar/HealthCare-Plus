namespace HealthCare_Plus
{
    partial class addTestResult
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
            lblPatient = new Label();
            lblTestResult = new Label();
            lblNormalRange = new Label();
            lblTestCost = new Label();
            cmbPatient = new ComboBox();
            cmbTest = new ComboBox();
            txtNormalRange = new TextBox();
            txtTestResult = new TextBox();
            txtCost = new TextBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblTest = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPatient.Location = new Point(304, 174);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(73, 25);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Patient";
            // 
            // lblTestResult
            // 
            lblTestResult.AutoSize = true;
            lblTestResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestResult.Location = new Point(304, 339);
            lblTestResult.Name = "lblTestResult";
            lblTestResult.Size = new Size(104, 25);
            lblTestResult.TabIndex = 3;
            lblTestResult.Text = "Test Result";
            lblTestResult.Click += label2_Click;
            // 
            // lblNormalRange
            // 
            lblNormalRange.AutoSize = true;
            lblNormalRange.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNormalRange.Location = new Point(304, 285);
            lblNormalRange.Name = "lblNormalRange";
            lblNormalRange.Size = new Size(134, 25);
            lblNormalRange.TabIndex = 2;
            lblNormalRange.Text = "Normal Range";
            // 
            // lblTestCost
            // 
            lblTestCost.AutoSize = true;
            lblTestCost.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTestCost.Location = new Point(304, 397);
            lblTestCost.Name = "lblTestCost";
            lblTestCost.Size = new Size(88, 25);
            lblTestCost.TabIndex = 6;
            lblTestCost.Text = "Test Cost";
            // 
            // cmbPatient
            // 
            cmbPatient.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(488, 171);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(313, 33);
            cmbPatient.TabIndex = 7;
            // 
            // cmbTest
            // 
            cmbTest.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTest.FormattingEnabled = true;
            cmbTest.Location = new Point(488, 228);
            cmbTest.Name = "cmbTest";
            cmbTest.Size = new Size(313, 33);
            cmbTest.TabIndex = 8;
            cmbTest.SelectedIndexChanged += cmbTest_SelectedIndexChanged;
            cmbTest.SelectedValueChanged += cmbTest_SelectedValueChanged;
            // 
            // txtNormalRange
            // 
            txtNormalRange.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNormalRange.Location = new Point(488, 282);
            txtNormalRange.Name = "txtNormalRange";
            txtNormalRange.Size = new Size(313, 31);
            txtNormalRange.TabIndex = 9;
            // 
            // txtTestResult
            // 
            txtTestResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTestResult.Location = new Point(488, 336);
            txtTestResult.Name = "txtTestResult";
            txtTestResult.Size = new Size(313, 31);
            txtTestResult.TabIndex = 10;
            // 
            // txtCost
            // 
            txtCost.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCost.Location = new Point(488, 391);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(313, 31);
            txtCost.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(504, 497);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 53);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(655, 497);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 53);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTest.Location = new Point(304, 231);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(46, 25);
            lblTest.TabIndex = 16;
            lblTest.Text = "Test";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Maroon;
            lblMessage.Location = new Point(488, 449);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(84, 25);
            lblMessage.TabIndex = 17;
            lblMessage.Text = "Message";
            lblMessage.Visible = false;
            // 
            // addTestResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1123, 714);
            Controls.Add(lblMessage);
            Controls.Add(lblTest);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtCost);
            Controls.Add(txtTestResult);
            Controls.Add(txtNormalRange);
            Controls.Add(cmbTest);
            Controls.Add(cmbPatient);
            Controls.Add(lblTestCost);
            Controls.Add(lblTestResult);
            Controls.Add(lblNormalRange);
            Controls.Add(lblPatient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addTestResult";
            Text = "addTestResult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientName;
        private Label lblPatient;
        private Label lblTestResult;
        private Label lblNormalRange;
        private Label lblTestName;
        private Label label5;
        private Label lblTestCost;
        private ComboBox cmbPatient;
        private ComboBox cmbTest;
        private TextBox txtNormalRange;
        private TextBox txtTestResult;
        private TextBox txtCost;
        private Button btnClear;
        private Button btnAdd;
        private Label lblTest;
        private Label lblMessage;
    }
}