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
    public partial class adminDocSchedule : Form
    {
        private string docID;
        private string docName;
        public adminDocSchedule(string docID, string docName)
        {
            InitializeComponent();
            this.docID = docID;
            this.docName = docName;
            lblDoctorID.Text = "Schedule for " + docName;
        }

        private void adminDocSchedule_Load(object sender, EventArgs e)
        {
            load_doctor_schedule();
        }

        private void load_doctor_schedule()
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

        private void dgvDoctorSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvDocSch = new DataGridView();
            dgvDocSch = dgvDoctorSchedule;
            txtScheduleCode.Text = dgvDocSch.CurrentRow.Cells[0].Value.ToString();
            dtpScheduleDate.Text = dgvDocSch.CurrentRow.Cells[1].Value.ToString();
            txtTotalAppointments.Text = dgvDocSch.CurrentRow.Cells[2].Value.ToString();
            txtAppointmentCharge.Text = dgvDocSch.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtScheduleCode.Text = "";
            dtpScheduleDate.Text = "";
            txtTotalAppointments.Text = "";
            txtAppointmentCharge.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string scheduleCode = txtScheduleCode.Text;
            string statement = "SELECT * FROM appointment_master WHERE scheduleCode = '" + scheduleCode + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Schedule Code already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO appointment_master " +
                                     "(scheduleCode, doctorID, scheduleDate, totalAppointment, appointentCharge)" +
                                 "VALUES " +
                                     "(@scheduleCode, @doctorID, @scheduleDate, @totalAppointment, @appointentCharge)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@scheduleCode", txtScheduleCode.Text);
                    command.Parameters.AddWithValue("@doctorID", docID);
                    command.Parameters.AddWithValue("@scheduleDate", dtpScheduleDate.Value);
                    command.Parameters.AddWithValue("@totalAppointment", txtTotalAppointments.Text);
                    command.Parameters.AddWithValue("@appointentCharge", txtAppointmentCharge.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_doctor_schedule();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();
            string scheduleCode = txtScheduleCode.Text;
            string updateQuery = "UPDATE appointment_master " +
                                    "SET doctorID = @doctorID, " +
                                    "scheduleDate = @scheduleDate, " +
                                    "totalAppointment = @totalAppointment, " +
                                    "appointentCharge = @appointentCharge " +
                                    "WHERE scheduleCode = '" + scheduleCode + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@doctorID", docID);
                command.Parameters.AddWithValue("@scheduleDate", dtpScheduleDate.Value);
                command.Parameters.AddWithValue("@totalAppointment", txtTotalAppointments.Text);
                command.Parameters.AddWithValue("@appointentCharge", txtAppointmentCharge.Text);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_doctor_schedule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();
            string scheduleCode = txtScheduleCode.Text;
            string deleteQuery = "UPDATE appointment_master " +
                                    "SET deletedYN = 1 " +
                                    "WHERE scheduleCode = '" + scheduleCode + "'";
            using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            conn.Close();
            load_doctor_schedule();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard objadminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
            if (objadminDashboard != null)
            {
                objadminDashboard.Focus();
            }
        }

        private void lblWarningMessage_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoctorSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}