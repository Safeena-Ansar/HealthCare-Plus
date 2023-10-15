using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCare_Plus
{
    public partial class ViewScheduleDetails : Form
    {
        public ViewScheduleDetails(string scheduleCode)
        {
            InitializeComponent();
            Load_schedule_details(scheduleCode);
        }

        private void Load_schedule_details(string scheduleCode)
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string query = "SELECT appointment_master.scheduleCode AS ScheduleCode,appointment_master.doctorID AS DoctorID,CONCAT( doctorFName, doctorLName ) AS DoctorName,speciality AS Speciality,department AS Department,scheduleDate AS Date,totalAppointment AS TotalAppointments, (totalAppointment - IFNULL(bookedApp, 0)) AS availableAppointments, appointentCharge FROM appointment_master JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID LEFT JOIN (SELECT count(bookingNumber) AS bookedApp, scheduleCode FROM patient_appointments)booked ON booked.scheduleCode = appointment_master.scheduleCode WHERE appointment_master.scheduleCode = '" + scheduleCode + "'";
                MySqlCommand userQuery = new MySqlCommand(query, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    lblScheduleCodeView.Text = scheduleCode;
                    lblDoctorIDView.Text = readData["DoctorID"].ToString();
                    lblDoctorNameView.Text = readData["DoctorName"].ToString();
                    lblDepartmentView.Text = readData["Department"].ToString();
                    lblSpecialityView.Text = readData["Speciality"].ToString();
                    lblAppointmentDateView.Text = readData["Date"].ToString();
                    lblTotalAppoitmentView.Text = readData["TotalAppointments"].ToString();
                    lblAvailableAppointmentView.Text = readData["availableAppointments"].ToString();
                    lblAppointmentChargeView.Text = readData["appointentCharge"].ToString();
                }
                conn.Close();
                conn.Open();
                string patientQuery = "SELECT CONCAT(patientCode, ' | ', patientFName, ' ', patientLName) AS patient FROM patient_details";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbPatientSelect.Items.Add(readPatData["patient"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ViewScheduleDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard objadminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
            labDashboard objlabDashboard = Application.OpenForms.OfType<labDashboard>().FirstOrDefault();
            officialDashboard objofficialDashboard = Application.OpenForms.OfType<officialDashboard>().FirstOrDefault();
            UserDashboard objUserDashboard = Application.OpenForms.OfType<UserDashboard>().FirstOrDefault();
            if (objadminDashboard != null)
            {
                objadminDashboard.Focus();
            }
            else if (objlabDashboard != null)
            {
                objlabDashboard.Focus();
            }
            else if (objofficialDashboard != null)
            {
                objofficialDashboard.Focus();
            }
            else if (objUserDashboard != null)
            {
                objUserDashboard.Focus();
            }
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            string DocID = lblDoctorIDView.Text;
            var objViewScheduleDetails = new ViewDoctorProfile(DocID);
            objViewScheduleDetails.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int bookingNumber = 1;
            string DocID = lblDoctorIDView.Text;
            string patientDetails = cmbPatientSelect.Text;
            string[] patientDetails_arr = patientDetails.Split(" | ");
            string patientCode = patientDetails_arr[0];
            string scheduleCode = lblScheduleCodeView.Text;

            MySqlConnection conn = DBConnection.connectToDb();
            string query = "SELECT COUNT(bookingNumber) as recordNumber FROM patient_appointments";
            MySqlCommand userQuery = new MySqlCommand(query, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                bookingNumber = Convert.ToInt32(readData["recordNumber"]);
                bookingNumber += 1;
            }
            conn.Close();
            conn.Open();

            string insertQuery = "INSERT INTO patient_appointments " +
                                    "(bookingNumber,patientCode,scheduleCode,paymentApproved)" +
                                "VALUES " +
                                    "(@bookingNumber,@patientCode,@scheduleCode,@paymentApproved)";

            using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
            {
                command.Parameters.AddWithValue("@bookingNumber", bookingNumber);
                command.Parameters.AddWithValue("@patientCode", patientCode);
                command.Parameters.AddWithValue("@scheduleCode", scheduleCode);
                command.Parameters.AddWithValue("@paymentApproved", (int)0);

                int rowsAffected = command.ExecuteNonQuery();
            }

            btnClose_Click(sender, e);
        }
    }
}
