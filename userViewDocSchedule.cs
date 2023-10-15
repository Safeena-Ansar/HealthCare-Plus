using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class userViewDocSchedule : Form
    {
        private string docID;
        public userViewDocSchedule(string docID, string docName)
        {
            InitializeComponent();
            this.docID = docID;
            lblDocDetail.Text = docID + " | " + docName;
            Load_doctor_schedule();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            UserDashboard objUserDashboard = Application.OpenForms.OfType<UserDashboard>().FirstOrDefault();
            if (objUserDashboard != null)
            {
                objUserDashboard.Focus();
            }
        }

        private void Load_doctor_schedule()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT scheduleCode AS `Schedule Code`, scheduleDate AS `Schedule Date`, totalAppointment AS `Total Appointment`, appointentCharge AS `Appointment Charge` FROM `appointment_master` WHERE doctorID = '" + docID + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable scheduleTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(scheduleTable);
                    BindingSource docbindingSource = new BindingSource();
                    docbindingSource.DataSource = scheduleTable;
                    dgvDoctorSchedule.DataSource = docbindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
