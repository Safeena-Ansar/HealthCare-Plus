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
    public partial class UserBookingPayment : Form
    {
        public UserBookingPayment()
        {
            InitializeComponent();
            Load_pending_payment();
            Load_approved_payment();
        }

        private void Load_pending_payment()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT bookingNumber AS `Booking No`, patient_appointments.scheduleCode AS `Schedule Code`, CONCAT(doctor_details.doctorID, ' | ', doctorFName, ' ', doctorLName) AS `Doctor`, CONCAT(patient_appointments.patientCode, ' | ', patientFName, ' ', patientLName) AS Patient, speciality AS `Speciality`, department AS `Department`, scheduleDate AS `Appointment Date`, appointentCharge AS `Charge` FROM patient_appointments JOIN appointment_master ON appointment_master.scheduleCode = patient_appointments.scheduleCode JOIN patient_details ON patient_details.patientCode = patient_appointments.patientCode JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID WHERE paymentApproved = 0";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvBookingPaymentPending.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Load_approved_payment()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT bookingNumber AS `Booking No`, patient_appointments.scheduleCode AS `Schedule Code`, CONCAT(doctor_details.doctorID, ' | ', doctorFName, ' ', doctorLName) AS `Doctor`, CONCAT(patient_appointments.patientCode, ' | ', patientFName, ' ', patientLName) AS Patient, speciality AS `Speciality`, department AS `Department`, scheduleDate AS `Appointment Date`, appointentCharge AS `Charge` FROM patient_appointments JOIN appointment_master ON appointment_master.scheduleCode = patient_appointments.scheduleCode JOIN patient_details ON patient_details.patientCode = patient_appointments.patientCode JOIN doctor_details ON doctor_details.doctorID = appointment_master.doctorID WHERE paymentApproved = 1";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvBookingPaymentApproved.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
