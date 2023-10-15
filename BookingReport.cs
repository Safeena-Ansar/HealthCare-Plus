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
    public partial class BookingReport : Form
    {
        public BookingReport()
        {
            InitializeComponent();
            load_booking_report();
            load_patient_drop();
            load_doctor_drop();
        }

        private void load_patient_drop()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT CONCAT(patientCode, ' | ', patientFName, ' ', patientLName) as patient FROM patient_details GROUP BY patientCode";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbPatient.Items.Add(readPatData["patient"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void load_doctor_drop()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT CONCAT(doctorID, ' | ', doctorFName, ' ', doctorLName) as doctor FROM doctor_details GROUP BY doctorID";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbDoctor.Items.Add(readPatData["doctor"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void load_booking_report()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT appointment_master.scheduleCode AS `Schedule Code`, scheduleDate AS `Schedule Date`, appointment_master.doctorID AS `Doctor ID`, CONCAT(doctorFName, ' ', doctorLName) as `Doctor Name`, appointentCharge AS `Appointment Charge`, CASE WHEN paymentApproved = 1 THEN 'Approved' WHEN paymentApproved = 0 THEN 'Pending' END AS `Payment Approved`, patient_appointments.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name` FROM patient_appointments JOIN appointment_master ON appointment_master.scheduleCode = patient_appointments.scheduleCode JOIN patient_details ON patient_details.patientCode = patient_appointments.patientCode JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable docTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(docTable);
                    BindingSource docbindingSource = new BindingSource();
                    docbindingSource.DataSource = docTable;
                    dgvDoctor.DataSource = docbindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            string patient = cmbPatient.Text;
            string[] patient_arr = patient.Split(" | ");
            string patientCode = patient_arr[0];

            string doctor = cmbDoctor.Text;
            string[] doctor_arr = doctor.Split(" | ");
            string doctorID = doctor_arr[0];

            string paymentType = cmbGender.Text;
            string where = "";
            string typeInt = "";

            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT appointment_master.scheduleCode AS `Schedule Code`, scheduleDate AS `Schedule Date`, appointment_master.doctorID AS `Doctor ID`, CONCAT(doctorFName, ' ', doctorLName) as `Doctor Name`, appointentCharge AS `Appointment Charge`, CASE WHEN paymentApproved = 1 THEN 'Approved' WHEN paymentApproved = 0 THEN 'Pending' END AS `Payment Approved`, patient_appointments.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name` FROM patient_appointments JOIN appointment_master ON appointment_master.scheduleCode = patient_appointments.scheduleCode JOIN patient_details ON patient_details.patientCode = patient_appointments.patientCode JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID";

            if (!string.IsNullOrEmpty(patient))
            {
                if (where == string.Empty)
                {
                    query += " WHERE ";
                    where = "where";
                }
                else
                {
                    query += " AND ";
                }
                query += "patient_appointments.patientCode LIKE '%" + patientCode + "%'";
            }
            if (!string.IsNullOrEmpty(doctor))
            {
                if (where == string.Empty)
                {
                    query += " WHERE ";
                    where = "where";
                }
                else
                {
                    query += " AND ";
                }
                query += " appointment_master.doctorID LIKE '%" + doctorID + "%'";
            }
            if (!string.IsNullOrEmpty(paymentType))
            {
                if (paymentType == "Pending")
                {
                    typeInt = 0.ToString();
                }
                else
                {
                    typeInt = 1.ToString();
                }
                if (where == string.Empty)
                {
                    query += " WHERE ";
                    where = "where";
                }
                else
                {
                    query += " AND ";
                }
                query += " paymentApproved ='" + typeInt + "'";
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
                    dgvDoctor.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbDoctor.Text = string.Empty;
            cmbGender.Text = string.Empty;
            cmbPatient.Text = string.Empty;
            load_booking_report();
        }
    }
}
