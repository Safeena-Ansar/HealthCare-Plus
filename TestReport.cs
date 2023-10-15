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
    public partial class TestReport : Form
    {
        public TestReport()
        {
            InitializeComponent();
            load_test_report();
            load_patient_drop();
            load_test_drop();
        }

        private void load_test_drop()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT CONCAT(testCode, ' | ', testName) as test FROM test_details GROUP BY testCode";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbTest.Items.Add(readPatData["test"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void load_test_report()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT test_result.testCode AS `Test Code`, testName AS `Test Name`, description AS `Test Detail`, normalRange AS `Normal Range`, testResult AS `Test Result`, testCost AS `Test Cost`, test_result.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name`  FROM test_result JOIN test_details ON test_details.testCode = test_result.testCode JOIN patient_details ON patient_details.patientCode = test_result.patientCode";
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

            string test = cmbTest.Text;
            string[] test_arr = test.Split(" | ");
            string testCode = test_arr[0];

            string paymentType = cmbGender.Text;
            string where = "";
            string typeInt = "";

            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT test_result.testCode AS `Test Code`, testName AS `Test Name`, description AS `Test Detail`, normalRange AS `Normal Range`, testResult AS `Test Result`, testCost AS `Test Cost`, test_result.patientCode AS `Patient Code`, CONCAT(patientFName, ' ', patientLName) AS `Patient Name`  FROM test_result JOIN test_details ON test_details.testCode = test_result.testCode JOIN patient_details ON patient_details.patientCode = test_result.patientCode";

            if (!string.IsNullOrEmpty(patientCode))
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
                query += "test_result.patientCode LIKE '%" + patientCode + "%'";
            }
            if (!string.IsNullOrEmpty(testCode))
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
                query += " test_result.testCode LIKE '%" + testCode + "%'";
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
            cmbGender.Text = string.Empty;
            cmbPatient.Text = string.Empty;
            cmbTest.Text = string.Empty;
            load_test_report();
        }
    }
}
