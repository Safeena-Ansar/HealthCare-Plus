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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCare_Plus
{
    public partial class adminEmployee : Form
    {
        public adminEmployee()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminEmployee_Load(object sender, EventArgs e)
        {
            load_employee_table();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_employee_table()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT empNumber AS `Employee Number`, empFName AS `First Name`, empLName AS `Last Name`, NICnumber AS `NIC Number`, email AS Email, contactNumber AS `Contact Number`, CASE WHEN gender = 1 THEN 'Male' WHEN gender = 2 THEN 'Female' END AS Gender, address AS Address, CASE WHEN userType = 1 THEN 'Administrator' WHEN userType = 2 THEN 'Basic User' WHEN userType = 3 THEN 'Health Officials' WHEN userType = 4 THEN 'Laboratory User' END AS `User Type` FROM employee_details";
            MySqlCommand command = new MySqlCommand(query, conn);

            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dgvEmployee.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvEmp = new DataGridView();
            dgvEmp = dgvEmployee;
            txtEmpNumber.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvEmp.CurrentRow.Cells[2].Value.ToString();
            txtNICnumber.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
            txtContactNumber.Text = dgvEmp.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvEmp.CurrentRow.Cells[7].Value.ToString();

            if (dgvEmp.CurrentRow.Cells[6].Value.ToString() == "Male")
            {
                cmbGender.SelectedIndex = 0;
            }
            else
            {
                cmbGender.SelectedIndex = 1;
            }

            if (dgvEmp.CurrentRow.Cells[8].Value.ToString() == "Administrator")
            {
                cmbUserType.SelectedIndex = 0;
            }
            else if (dgvEmp.CurrentRow.Cells[8].Value.ToString() == "Basic User")
            {
                cmbUserType.SelectedIndex = 1;
            }
            else if (dgvEmp.CurrentRow.Cells[8].Value.ToString() == "Health Official")
            {
                cmbUserType.SelectedIndex = 2;
            }
            else if (dgvEmp.CurrentRow.Cells[8].Value.ToString() == "Laboratory User")
            {
                cmbUserType.SelectedIndex = 3;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string empNumber = txtEmpNumber.Text;
            string email = txtEmail.Text;
            string statement = "SELECT * FROM employee_details WHERE empNumber = '" + empNumber + "' OR email = '" + email + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Employee Number or Email already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO employee_details " +
                                     "(empFName, empLName, NICnumber, email, contactNumber, gender, address, empNumber, joinedDate, userType, timestamp)" +
                                 "VALUES " +
                                     "(@empFName, @empLName, @NICnumber, @email, @contactNumber, @gender, @address, @empNumber, @joinedDate, @userType, @timestamp)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@empFName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@empLName", txtLastName.Text);
                    command.Parameters.AddWithValue("@NICnumber", txtNICnumber.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                    command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@empNumber", txtEmpNumber.Text);
                    command.Parameters.AddWithValue("@joinedDate", dtpJoinedDate.Value);
                    command.Parameters.AddWithValue("@userType", (cmbUserType.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_employee_table();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();
            string email = txtEmail.Text;
            string empNumber = txtEmpNumber.Text;
            string statement = "SELECT * FROM employee_details WHERE email = '" + email + "' AND empNumber != '" + empNumber + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Employee Email already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string updateQuery = "UPDATE employee_details SET " +
                                        "empFName = @empFName," +
                                        "empLName = @empLName," +
                                        "NICnumber = @NICnumber," +
                                        "email = @email," +
                                        "contactNumber = @contactNumber," +
                                        "gender = @gender," +
                                        "address = @address," +
                                        "joinedDate = @joinedDate," +
                                        "userType = @userType," +
                                        "timestamp = @timestamp " +
                                    "WHERE " +
                                        "empNumber = '" + empNumber + "'";

                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@empFName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@empLName", txtLastName.Text);
                    command.Parameters.AddWithValue("@NICnumber", txtNICnumber.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                    command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@joinedDate", dtpJoinedDate.Value);
                    command.Parameters.AddWithValue("@userType", (cmbUserType.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_employee_table();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtEmpNumber.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNICnumber.Text = "";
            txtEmail.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            cmbUserType.Text = "";
            cmbGender.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string empNumber = txtEmpNumber.Text;
            string deleteQuery = "DELETE FROM employee_details WHERE empNumber = '" + empNumber + "'";

            using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            conn.Close();
            load_employee_table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empNumber = txtEmpNumber.Text;
            string empName = txtFirstName.Text + " " + txtLastName.Text;

            if (empNumber != "")
            {
                var objpasswordChange = new passwordChange(empNumber, empName);
                objpasswordChange.Show();
            }
        }
    }
}
