namespace HealthCare_Plus
{
    partial class passwordChange
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
            lblChangePassword = new Label();
            txtEmpPassword = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangePassword.Location = new Point(27, 39);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(292, 25);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "Change Password for Employee";
            // 
            // txtEmpPassword
            // 
            txtEmpPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpPassword.Location = new Point(231, 176);
            txtEmpPassword.Name = "txtEmpPassword";
            txtEmpPassword.PasswordChar = '*';
            txtEmpPassword.Size = new Size(261, 32);
            txtEmpPassword.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Teal;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(433, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 48);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(293, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 48);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(101, 120);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 23);
            lblUserName.TabIndex = 51;
            lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(101, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 52;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(231, 117);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 32);
            txtUserName.TabIndex = 53;
            // 
            // passwordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(598, 378);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtEmpPassword);
            Controls.Add(lblChangePassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "passwordChange";
            Text = "Change Employee Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChangePassword;
        private TextBox txtEmpPassword;
        private Button btnCancel;
        private Button btnSave;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
    }
}