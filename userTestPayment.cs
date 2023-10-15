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
    public partial class userTestPayment : Form
    {
        public userTestPayment()
        {
            InitializeComponent();
            Load_pending_test_payment();
            Load_approved_test_payment();
        }

        private void Load_pending_test_payment()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT testResultNumber AS `Test Number`, test_result.testCode AS `Test Code`, testName AS `Test Name`, test_result.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name`, testCost AS `Test Charge` FROM\ttest_result JOIN test_details ON test_result.testCode = test_details.testCode JOIN patient_details ON patient_details.patientCode = test_result.patientCode WHERE paymentApproved = 0";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvTestPaymentPending.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Load_approved_test_payment()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT testResultNumber AS `Test Number`, test_result.testCode AS `Test Code`, testName AS `Test Name`, test_result.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name`, testCost AS `Test Charge` FROM\ttest_result JOIN test_details ON test_result.testCode = test_details.testCode JOIN patient_details ON patient_details.patientCode = test_result.patientCode WHERE paymentApproved = 1";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvTestPaymentApproved.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
