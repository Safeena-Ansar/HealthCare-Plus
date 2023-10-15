using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class UserDashboard : Form
    {
        public UserDashboard(string empNumber)
        {
            InitializeComponent();
            txtEmpID.Text = empNumber;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string empNumber = txtEmpID.Text;
            loadUserForm(new profileView(empNumber));
        }
        public void loadUserForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var objFrmLogin = new FrmLogin();
            objFrmLogin.Show();
            Visible = false;
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            loadUserForm(new searchDoctors());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            loadUserForm(new userPatient());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            loadUserForm(new UserDoctor());
        }

        private void btnTestPayment_Click(object sender, EventArgs e)
        {
            loadUserForm(new userTestPayment());
        }

        private void btnBookingPayment_Click(object sender, EventArgs e)
        {
            loadUserForm(new UserBookingPayment());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (panelPayment.Height == 128)
            {
                panelPayment.Height = 42;
            }
            else
            {
                panelPayment.Height = 128;
            }
        }
    }
}
