namespace HealthCare_Plus
{
    partial class ViewDoctorProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDoctorProfile));
            pictureBox1 = new PictureBox();
            lblDoctorID = new Label();
            lblLicenceNo = new Label();
            lblGender = new Label();
            lblDepartment = new Label();
            lblSpeciality = new Label();
            btnClose = new Button();
            lblDoctorNameView = new Label();
            lblQualificationView = new Label();
            lblDepartmentView = new Label();
            lblSpecialityView = new Label();
            lblLicenceNoView = new Label();
            lblGenderView = new Label();
            lblDoctorIDView = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorID.Location = new Point(101, 374);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(109, 25);
            lblDoctorID.TabIndex = 1;
            lblDoctorID.Text = "Doctor ID :";
            // 
            // lblLicenceNo
            // 
            lblLicenceNo.AutoSize = true;
            lblLicenceNo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblLicenceNo.Location = new Point(101, 473);
            lblLicenceNo.Name = "lblLicenceNo";
            lblLicenceNo.Size = new Size(119, 25);
            lblLicenceNo.TabIndex = 4;
            lblLicenceNo.Text = "Licence No :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(101, 421);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(88, 25);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender :";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartment.Location = new Point(101, 580);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(130, 25);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "Department :";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpeciality.Location = new Point(101, 528);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(106, 25);
            lblSpeciality.TabIndex = 5;
            lblSpeciality.Text = "Speciality :";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Teal;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(471, 702);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 53);
            btnClose.TabIndex = 67;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblDoctorNameView
            // 
            lblDoctorNameView.AutoSize = true;
            lblDoctorNameView.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoctorNameView.Location = new Point(190, 276);
            lblDoctorNameView.Name = "lblDoctorNameView";
            lblDoctorNameView.Size = new Size(131, 25);
            lblDoctorNameView.TabIndex = 68;
            lblDoctorNameView.Text = "Doctor Name";
            // 
            // lblQualificationView
            // 
            lblQualificationView.AutoSize = true;
            lblQualificationView.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblQualificationView.Location = new Point(190, 313);
            lblQualificationView.Name = "lblQualificationView";
            lblQualificationView.Size = new Size(125, 25);
            lblQualificationView.TabIndex = 69;
            lblQualificationView.Text = "Qualification";
            // 
            // lblDepartmentView
            // 
            lblDepartmentView.AutoSize = true;
            lblDepartmentView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartmentView.Location = new Point(341, 580);
            lblDepartmentView.Name = "lblDepartmentView";
            lblDepartmentView.Size = new Size(117, 25);
            lblDepartmentView.TabIndex = 74;
            lblDepartmentView.Text = "Department ";
            // 
            // lblSpecialityView
            // 
            lblSpecialityView.AutoSize = true;
            lblSpecialityView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpecialityView.Location = new Point(341, 528);
            lblSpecialityView.Name = "lblSpecialityView";
            lblSpecialityView.Size = new Size(97, 25);
            lblSpecialityView.TabIndex = 73;
            lblSpecialityView.Text = "Speciality ";
            // 
            // lblLicenceNoView
            // 
            lblLicenceNoView.AutoSize = true;
            lblLicenceNoView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLicenceNoView.Location = new Point(341, 473);
            lblLicenceNoView.Name = "lblLicenceNoView";
            lblLicenceNoView.Size = new Size(110, 25);
            lblLicenceNoView.TabIndex = 72;
            lblLicenceNoView.Text = "Licence No ";
            // 
            // lblGenderView
            // 
            lblGenderView.AutoSize = true;
            lblGenderView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderView.Location = new Point(341, 421);
            lblGenderView.Name = "lblGenderView";
            lblGenderView.Size = new Size(79, 25);
            lblGenderView.TabIndex = 71;
            lblGenderView.Text = "Gender ";
            // 
            // lblDoctorIDView
            // 
            lblDoctorIDView.AutoSize = true;
            lblDoctorIDView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoctorIDView.Location = new Point(341, 374);
            lblDoctorIDView.Name = "lblDoctorIDView";
            lblDoctorIDView.Size = new Size(97, 25);
            lblDoctorIDView.TabIndex = 70;
            lblDoctorIDView.Text = "Doctor ID ";
            // 
            // ViewDoctorProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(663, 767);
            Controls.Add(lblDepartmentView);
            Controls.Add(lblSpecialityView);
            Controls.Add(lblLicenceNoView);
            Controls.Add(lblGenderView);
            Controls.Add(lblDoctorIDView);
            Controls.Add(lblQualificationView);
            Controls.Add(lblDoctorNameView);
            Controls.Add(btnClose);
            Controls.Add(lblDepartment);
            Controls.Add(lblSpeciality);
            Controls.Add(lblLicenceNo);
            Controls.Add(lblGender);
            Controls.Add(lblDoctorID);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDoctorProfile";
            Text = "ViewDoctorProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDoctorID;
        private Label lblLicenceNo;
        private Label lblGender;
        private Label lblDepartment;
        private Label lblSpeciality;
        private Button btnClose;
        private Button button1;
        private Label lblDoctorNameView;
        private Label lblQualificationView;
        private Label lblDepartmentView;
        private Label lblSpecialityView;
        private Label lblLicenceNoView;
        private Label lblGenderView;
        private Label lblDoctorIDView;
    }
}