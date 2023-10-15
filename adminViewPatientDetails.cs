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
    public partial class adminViewPatientDetails : Form
    {
        private string patientCode;
        public adminViewPatientDetails(string patientCode, string patientName)
        {
            InitializeComponent();
            load_patient_details();
            lblPatient.Text = patientCode + " | " + patientName;
            this.patientCode = patientCode;
        }

        private void load_patient_details()
        {
            string type = cmbDepartment.Text;
            if (type == "Booking Report")
            {
                lblWarning.Hide();
                MySqlConnection conn = DBConnection.connectToDb();
                string query = $"SELECT test_result.testCode AS `Test Code`, testName AS `Test Name`, normalRange AS `Normal Range`, testResult AS `Test Result`, testCost AS `Test Cost` FROM test_result JOIN test_details ON test_details.testCode = test_result.testCode WHERE patientCode = '" + patientCode + "'";
                MySqlCommand command = new MySqlCommand(query, conn);

                DataTable patientTable = new DataTable();

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patientTable);
                        BindingSource patientbindingSource = new BindingSource();
                        patientbindingSource.DataSource = patientTable;
                        dgvPatient.DataSource = patientbindingSource;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (type == "Test Report")
            {
                lblWarning.Hide();
                MySqlConnection conn = DBConnection.connectToDb();
                string query = $"SELECT appointment_master.scheduleCode AS `Schedule Code`, scheduleDate AS `Schedule Date`, appointentCharge AS `Appointment Charge`, paymentApproved AS `Payment Approved` FROM patient_appointments JOIN appointment_master ON appointment_master.scheduleCode = patient_appointments.scheduleCode WHERE patientCode = '" + patientCode + "'";
                MySqlCommand command = new MySqlCommand(query, conn);

                DataTable patientTable = new DataTable();

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patientTable);
                        BindingSource patientbindingSource = new BindingSource();
                        patientbindingSource.DataSource = patientTable;
                        dgvPatient.DataSource = patientbindingSource;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                lblWarning.Show();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load_patient_details();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard objAdminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
            if (objAdminDashboard != null)
            {
                objAdminDashboard.Focus();
            }
        }
    }
}
