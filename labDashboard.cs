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
    public partial class labDashboard : Form
    {
        public labDashboard(string empNumber)
        {
            InitializeComponent();
            txtEmpID.Text = empNumber;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var objFrmLogin = new FrmLogin();
            objFrmLogin.Show();
            Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string empNumber = txtEmpID.Text;
            loadLabForm(new profileView(empNumber));
        }

        public void loadLabForm(object Form)
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

        private void btnAddTestResult_Click(object sender, EventArgs e)
        {
            loadLabForm(new addTestResult()); 
        }
    }
}
