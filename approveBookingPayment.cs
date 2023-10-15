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
    public partial class approveBookingPayment : Form
    {
        public approveBookingPayment()
        {
            InitializeComponent();
            load_booking_pending_payments();
        }

        private void load_booking_pending_payments()
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
                    dgvApproveBookingPayment.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvApproveBookingPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvbooking = new DataGridView();
            dgvbooking = dgvApproveBookingPayment;
            txtBookingNumber.Text = dgvbooking.CurrentRow.Cells[0].Value.ToString();
            txtScheduleCode.Text = dgvbooking.CurrentRow.Cells[1].Value.ToString();
            txtDoctor.Text = dgvbooking.CurrentRow.Cells[2].Value.ToString();
            txtSpeciality.Text = dgvbooking.CurrentRow.Cells[3].Value.ToString();
            txtDepartment.Text = dgvbooking.CurrentRow.Cells[4].Value.ToString();
            txtAppointmentDate.Text = dgvbooking.CurrentRow.Cells[5].Value.ToString();
            txtAppointmentCharge.Text = dgvbooking.CurrentRow.Cells[6].Value.ToString();
            txtPatient.Text = dgvbooking.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtBookingNumber.Text = string.Empty;
            txtScheduleCode.Text = string.Empty;
            txtDoctor.Text = string.Empty;
            txtSpeciality.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtAppointmentDate.Text = string.Empty;
            txtAppointmentCharge.Text = string.Empty;
            txtPatient.Text = string.Empty;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string bookingNumber = txtBookingNumber.Text;
            if(bookingNumber != string.Empty)
            {
                MySqlConnection conn = DBConnection.connectToDb();
                string updateQuery = "UPDATE patient_appointments SET " +
                                        "paymentApproved = @paymentApproved " +
                                    "WHERE " +
                                        "bookingNumber = '" + bookingNumber + "'";

                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@paymentApproved", (int)1);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                lblWarningMessage.Text = "Payment Approved for Bill: " + bookingNumber;
                lblWarningMessage.Show();
                load_booking_pending_payments();
            } else
            {
                lblWarningMessage.Text = "Please Select a Bill for Payment";
                lblWarningMessage.Show();
            }
        }
    }
}
