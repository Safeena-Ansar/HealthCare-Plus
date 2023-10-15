namespace HealthCare_Plus
{
    partial class labDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labDashboard));
            btnAddTestResult = new Button();
            panelNavBar = new Panel();
            btnLogout = new Button();
            panelBottom = new Panel();
            txtEmpID = new TextBox();
            panelTop = new Panel();
            btnUser = new Button();
            panelMain = new Panel();
            panelNavBar.SuspendLayout();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTestResult
            // 
            btnAddTestResult.BackColor = Color.Silver;
            btnAddTestResult.Location = new Point(24, 252);
            btnAddTestResult.Name = "btnAddTestResult";
            btnAddTestResult.Size = new Size(178, 38);
            btnAddTestResult.TabIndex = 6;
            btnAddTestResult.Text = "Add Test Result";
            btnAddTestResult.UseVisualStyleBackColor = false;
            btnAddTestResult.Click += btnAddTestResult_Click;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Teal;
            panelNavBar.Controls.Add(btnAddTestResult);
            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.Location = new Point(0, 49);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(221, 686);
            panelNavBar.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.Location = new Point(24, 306);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(178, 38);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Teal;
            panelBottom.Controls.Add(txtEmpID);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 735);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1141, 26);
            panelBottom.TabIndex = 8;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(1013, -1);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(125, 27);
            txtEmpID.TabIndex = 0;
            txtEmpID.Visible = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Teal;
            panelTop.Controls.Add(btnUser);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1141, 49);
            panelTop.TabIndex = 6;
            // 
            // btnUser
            // 
            btnUser.BackgroundImage = Properties.Resources.defaultimg;
            btnUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Location = new Point(1061, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(68, 42);
            btnUser.TabIndex = 0;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // panelMain
            // 
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1141, 761);
            panelMain.TabIndex = 7;
            // 
            // labDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 761);
            Controls.Add(panelNavBar);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "labDashboard";
            Text = "labDashboard";
            panelNavBar.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTestResult;
        private Panel panelNavBar;
        private Button btnLogout;
        private Panel panelBottom;
        private TextBox txtEmpID;
        private Panel panelTop;
        private Button btnUser;
        private Panel panelMain;
    }
}