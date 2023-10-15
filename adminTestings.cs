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
    public partial class adminTestings : Form
    {
        public adminTestings()
        {
            InitializeComponent();
        }

        private void adminTestings_Load(object sender, EventArgs e)
        {
            load_testing_details();
        }

        private void load_testing_details()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT testName AS `Testing Name`,testCode AS `Testing Code`,description AS `Description`,normalRange AS `Normal Range`,turnAroundTime AS `Time To Test (hrs)`,testCost AS `Test Cost` FROM test_details";
            MySqlCommand command = new MySqlCommand(query, conn);

            DataTable testingTable = new DataTable();

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(testingTable);
                    BindingSource testBindingSource = new BindingSource();
                    testBindingSource.DataSource = testingTable;
                    dgvTestings.DataSource = testBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvTestings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvtesting = new DataGridView();
            dgvtesting = dgvTestings;
            txtTestingName.Text = dgvtesting.CurrentRow.Cells[0].Value.ToString();
            txtTestingCode.Text = dgvtesting.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dgvtesting.CurrentRow.Cells[2].Value.ToString();
            txtNormalRange.Text = dgvtesting.CurrentRow.Cells[3].Value.ToString();
            txtTurnAroundTime.Text = dgvtesting.CurrentRow.Cells[4].Value.ToString();
            txtTestCost.Text = dgvtesting.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtTestingName.Text = "";
            txtTestingCode.Text = "";
            txtDescription.Text = "";
            txtNormalRange.Text = "";
            txtTurnAroundTime.Text = "";
            txtTestCost.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string testingCode = txtTestCost.Text;
            string statement = "SELECT * FROM test_details WHERE testCode = '" + testingCode + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Testing Code already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO test_details " +
                                     "(testCode, testName, description, normalRange, turnAroundTime, testCost)" +
                                 "VALUES " +
                                     "(@testCode, @testName, @description, @normalRange, @turnAroundTime, @testCost)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@testCode", txtTestCost.Text);
                    command.Parameters.AddWithValue("@testName", txtTestingName.Text);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.Parameters.AddWithValue("@normalRange", txtNormalRange.Text);
                    command.Parameters.AddWithValue("@turnAroundTime", txtTurnAroundTime.Text);
                    command.Parameters.AddWithValue("@testCost", txtTestCost.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_testing_details();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string testingCode = txtTestCost.Text;
            string updateQuery = "UPDATE medicine_details SET " +
                                    "testName = @testName," +
                                    "description = @description," +
                                    "normalRange = @normalRange," +
                                    "turnAroundTime = @turnAroundTime," +
                                    "testCost = @testCost " +
                                "WHERE " +
                                    "testCode = '" + testingCode + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@testName", txtTestingName.Text);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@normalRange", txtNormalRange.Text);
                command.Parameters.AddWithValue("@turnAroundTime", txtTurnAroundTime.Text);
                command.Parameters.AddWithValue("@testCost", txtTestCost.Text);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_testing_details();
        }
    }
}
