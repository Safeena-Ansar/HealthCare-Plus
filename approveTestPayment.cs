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
    public partial class approveTestPayment : Form
    {
        public approveTestPayment()
        {
            InitializeComponent();
            Load_pending_test_payments();
        }

        private void Load_pending_test_payments()
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
                    dgvApproveTestPayment.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvApproveTestPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvtesting = new DataGridView();
            dgvtesting = dgvApproveTestPayment;
            txtTestNumber.Text = dgvtesting.CurrentRow.Cells[0].Value.ToString();
            txtTestCode.Text = dgvtesting.CurrentRow.Cells[1].Value.ToString();
            txtTestName.Text = dgvtesting.CurrentRow.Cells[2].Value.ToString();
            txtPatientCode.Text = dgvtesting.CurrentRow.Cells[3].Value.ToString();
            txtPatientName.Text = dgvtesting.CurrentRow.Cells[4].Value.ToString();
            txtTestCharge.Text = dgvtesting.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTestNumber.Text = string.Empty;
            txtTestCode.Text = string.Empty;
            txtTestName.Text = string.Empty;
            txtPatientCode.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtTestCharge.Text = string.Empty;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string testNumber = txtTestNumber.Text;
            if (testNumber != string.Empty)
            {
                MySqlConnection conn = DBConnection.connectToDb();
                string updateQuery = "UPDATE test_result SET " +
                                        "paymentApproved = @paymentApproved " +
                                    "WHERE " +
                                        "testResultNumber = '" + testNumber + "'";

                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@paymentApproved", (int)1);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                lblWarningMessage.Text = "Payment Approved for Bill: " + testNumber;
                lblWarningMessage.Show();
                Load_pending_test_payments();
            }
            else
            {
                lblWarningMessage.Text = "Please Select a Bill for Payment";
                lblWarningMessage.Show();
            }
        }
    }
}