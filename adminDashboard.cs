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
    public partial class adminDashboard : Form
    {
        public adminDashboard(string empNumber)
        {
            InitializeComponent();
            txtEmpID.Text = empNumber;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string empNumber = txtEmpID.Text;
            loadForm(new profileView(empNumber));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasters_Click(object sender, EventArgs e)
        {
            if (panelMaster.Height == 210)
            {
                panelMaster.Height = 42;
            }
            else
            {
                panelMaster.Height = 210;
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            var objFrmLogin = new FrmLogin();
            objFrmLogin.Show();
            Visible = false;
        }

        public void loadForm(object Form)
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (panelReport.Height == 210)
            {
                panelReport.Height = 42;
            }
            else
            {
                panelReport.Height = 210;
            }
        }

        private void btnTheaters_Click(object sender, EventArgs e)
        {
            loadForm(new adminTheaters());
        }

        private void btnTestings_Click(object sender, EventArgs e)
        {
            loadForm(new adminTestings());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            loadForm(new adminRooms());
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            loadForm(new adminMedicine());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            loadForm(new adminEmployee());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            loadForm(new adminDoctors());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            loadForm(new adminPatients());
        }

        private void btnSearchDoctor_Click_1(object sender, EventArgs e)
        {
            loadForm(new searchDoctors());
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new approveTestPayment());
        }

        private void btnBookingPayment_Click(object sender, EventArgs e)
        {
            loadForm(new approveBookingPayment());
        }

        private void btnDoctorReport_Click(object sender, EventArgs e)
        {
            loadForm(new adminReport());
        }

        private void btnPatientReport_Click(object sender, EventArgs e)
        {
            loadForm(new adminPatientReport());
        }

        private void btnTestReport_Click(object sender, EventArgs e)
        {
            loadForm(new TestReport());            
        }

        private void btnBookingReport_Click(object sender, EventArgs e)
        {
            loadForm(new BookingReport()); 
        }
    }
}
