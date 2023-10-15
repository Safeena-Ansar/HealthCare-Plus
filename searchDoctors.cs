using MySql.Data.MySqlClient;
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
    public partial class searchDoctors : Form
    {
        public searchDoctors()
        {
            InitializeComponent();
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            string doctorID = txtDoctorID.Text;
            string department = txtDepartment.Text;
            string doctorName = txtDoctorName.Text;
            string speciality = txtDoctorSpeciality.Text;
            string qualification = txtQualification.Text;
            DateTime selectedDate = dtpAppoinmentDate.Value;
            // Format the date as "yyyy-MM-dd"
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT scheduleCode AS `Schedule Code`, appointment_master.doctorID AS `Doctor ID`, CONCAT(doctorFName, doctorLName) AS `Doctor Name`,speciality AS Speciality,department AS Department,scheduleDate AS `Date`,totalAppointment AS `Total Appointments` FROM appointment_master JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID WHERE deletedYN != 1 ";

            if (!string.IsNullOrEmpty(doctorID))
            {
                query += " AND appointment_master.doctorID LIKE '%" + doctorID + "%'";
            }
            if (!string.IsNullOrEmpty(department))
            {
                query += " AND department LIKE '%" + department + "%'";
            }
            if (!string.IsNullOrEmpty(doctorName))
            {
                query += " AND doctorFName LIKE '%" + doctorName + "%' OR doctorLName LIKE '%" + doctorName + "%'";
            }
            if (!string.IsNullOrEmpty(speciality))
            {
                query += " AND speciality LIKE '%" + speciality + "%'";
            }
            if (!string.IsNullOrEmpty(qualification))
            {
                query += " AND qualification LIKE '%" + qualification + "%'";
            }
            if (!string.IsNullOrEmpty(formattedDate))
            {
                query += " AND scheduleDate LIKE '%" + formattedDate + "%'";
            }

            MySqlCommand command = new MySqlCommand(query, conn);

            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvSearchDoctor.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvSearchDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvDocSer = new DataGridView();
            dgvDocSer = dgvSearchDoctor;
            string scheduleCode = dgvDocSer.CurrentRow.Cells[0].Value.ToString();
            if (scheduleCode != "")
            {
                var objViewScheduleDetails = new ViewScheduleDetails(scheduleCode);
                objViewScheduleDetails.Show();
            }
        }
    }
}
