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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCare_Plus
{
    public partial class addTestResult : Form
    {
        public addTestResult()
        {
            InitializeComponent();
            load_patients();
            load_tests();
        }

        private void load_patients()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT CONCAT (patientCode, ' | ', patientFName, ' ', patientLName) AS patient FROM patient_details";
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
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void load_tests()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT CONCAT(testCode, ' | ', testName) AS test FROM test_details";
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
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TestDetails = cmbTest.Text;
            string[] TestDetailsDetails_arr = TestDetails.Split(" | ");
            string testCode = TestDetailsDetails_arr[0];

            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string testQuery = "SELECT normalRange, testCost FROM test_details WHERE testCode = '" + testCode + "'";
                MySqlCommand userQuery = new MySqlCommand(testQuery, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    txtCost.Text = readData["testCost"].ToString();
                    txtNormalRange.Text = readData["normalRange"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Hide();
            txtNormalRange.Text = string.Empty;
            txtCost.Text = string.Empty;
            txtTestResult.Text = string.Empty;
            cmbTest.Text = string.Empty;
            cmbPatient.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMessage.Hide();
            int bookingNumber = (int)1;
            string TestDetails = cmbTest.Text;
            string[] TestDetailsDetails_arr = TestDetails.Split(" | ");
            string testCode = TestDetailsDetails_arr[0];
            string patientDetails = cmbPatient.Text;
            string[] patientDetails_arr = patientDetails.Split(" | ");
            string patientCode = patientDetails_arr[0];
            string testResult = txtTestResult.Text;

            try
            {
                if (testResult != string.Empty && patientCode != string.Empty && testCode != string.Empty)
                {
                    MySqlConnection conn = DBConnection.connectToDb();
                    string query = "SELECT COUNT(testResultNumber) as recordNumber FROM test_result";
                    MySqlCommand userQuery = new MySqlCommand(query, conn);
                    MySqlDataReader readData = userQuery.ExecuteReader();
                    if (readData.Read())
                    {
                        bookingNumber = Convert.ToInt32(readData["recordNumber"]);
                        bookingNumber += 1;
                    }
                    conn.Close();
                    conn.Open();

                    string insertQuery = "INSERT INTO test_result " +
                                            "(testResultNumber,testCode,patientCode,testResult,paymentApproved)" +
                                        "VALUES " +
                                            "(@testResultNumber,@testCode,@patientCode,@testResult,@paymentApproved)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@testResultNumber", bookingNumber);
                        command.Parameters.AddWithValue("@testCode", testCode);
                        command.Parameters.AddWithValue("@patientCode", patientCode);
                        command.Parameters.AddWithValue("@testResult", testResult);
                        command.Parameters.AddWithValue("@paymentApproved", (int)0);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    lblMessage.Text = "Record Added Successfully!";
                    lblMessage.Show();
                    txtNormalRange.Text = string.Empty;
                    txtCost.Text = string.Empty;
                    txtTestResult.Text = string.Empty;
                    cmbTest.Text = string.Empty;
                    cmbPatient.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void cmbTest_SelectedValueChanged(object sender, EventArgs e)
        {
            string TestDetails = cmbTest.Text;
            string[] TestDetailsDetails_arr = TestDetails.Split(" | ");
            string testCode = TestDetailsDetails_arr[0];

            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string testQuery = "SELECT normalRange, testCost FROM test_details WHERE testCode = '" + testCode + "'";
                MySqlCommand userQuery = new MySqlCommand(testQuery, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    txtCost.Text = readData["testCost"].ToString();
                    txtNormalRange.Text = readData["normalRange"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
