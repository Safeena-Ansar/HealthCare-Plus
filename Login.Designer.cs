namespace HealthCare_Plus
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            LblUsername = new Label();
            LblPassword = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            BtnCancel = new Button();
            lblLoginValidation = new Label();
            lblVerifyUsername = new Label();
            lblVerifyPassword = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblHealthCarePlus = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsername.ForeColor = Color.Teal;
            LblUsername.Location = new Point(484, 217);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(106, 28);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblPassword.ForeColor = Color.Teal;
            LblPassword.Location = new Point(484, 310);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(101, 28);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(629, 214);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(308, 34);
            TxtUsername.TabIndex = 2;
            TxtUsername.TextChanged += TxtUsername_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(629, 307);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(308, 34);
            TxtPassword.TabIndex = 3;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Teal;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(792, 390);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(145, 57);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.Teal;
            BtnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(638, 390);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(148, 57);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // lblLoginValidation
            // 
            lblLoginValidation.AutoSize = true;
            lblLoginValidation.ForeColor = Color.Red;
            lblLoginValidation.Location = new Point(629, 191);
            lblLoginValidation.Name = "lblLoginValidation";
            lblLoginValidation.Size = new Size(263, 20);
            lblLoginValidation.TabIndex = 6;
            lblLoginValidation.Text = "* Username or password do not match";
            lblLoginValidation.Visible = false;
            // 
            // lblVerifyUsername
            // 
            lblVerifyUsername.AutoSize = true;
            lblVerifyUsername.ForeColor = Color.Red;
            lblVerifyUsername.Location = new Point(629, 251);
            lblVerifyUsername.Name = "lblVerifyUsername";
            lblVerifyUsername.Size = new Size(194, 20);
            lblVerifyUsername.TabIndex = 7;
            lblVerifyUsername.Text = "* Please enter the Username";
            lblVerifyUsername.Visible = false;
            // 
            // lblVerifyPassword
            // 
            lblVerifyPassword.AutoSize = true;
            lblVerifyPassword.ForeColor = Color.Red;
            lblVerifyPassword.Location = new Point(629, 344);
            lblVerifyPassword.Name = "lblVerifyPassword";
            lblVerifyPassword.Size = new Size(189, 20);
            lblVerifyPassword.TabIndex = 8;
            lblVerifyPassword.Text = "* Please enter the Password";
            lblVerifyPassword.Visible = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(484, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 57);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 636);
            panel1.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(21, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 245);
            panel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(287, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 57);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(851, 57);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(287, 602);
            panel4.Name = "panel4";
            panel4.Size = new Size(851, 34);
            panel4.TabIndex = 12;
            // 
            // lblHealthCarePlus
            // 
            lblHealthCarePlus.AutoSize = true;
            lblHealthCarePlus.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHealthCarePlus.ForeColor = Color.FromArgb(128, 64, 64);
            lblHealthCarePlus.Location = new Point(565, 98);
            lblHealthCarePlus.Name = "lblHealthCarePlus";
            lblHealthCarePlus.Size = new Size(264, 36);
            lblHealthCarePlus.TabIndex = 13;
            lblHealthCarePlus.Text = "Health Care Plus";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 636);
            Controls.Add(lblHealthCarePlus);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(lblVerifyPassword);
            Controls.Add(lblVerifyUsername);
            Controls.Add(lblLoginValidation);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblPassword);
            Controls.Add(LblUsername);
            Name = "FrmLogin";
            Text = "Health Care Plus";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUsername;
        private Label LblPassword;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Button BtnCancel;
        private Label lblLoginValidation;
        private Label lblVerifyUsername;
        private Label lblVerifyPassword;
        private Button btnExit;
        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblHealthCarePlus;
    }
}