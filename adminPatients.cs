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
    public partial class adminPatients : Form
    {
        public adminPatients()
        {
            InitializeComponent();
        }

        private void adminPatients_Load(object sender, EventArgs e)
        {
            load_patient_details();
        }

        private void load_patient_details()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT patientCode AS `Patient Code`,patientFName AS `First Name`,patientLName AS `Last Name`,contactNumber AS `Contact Number`,email AS `Email`,dateOfBirth AS `Date Of Birth`,CASE WHEN gender = 1 THEN 'Male' WHEN gender = 2 THEN 'Female' END AS `Gender`,address AS `Address`,emergencyContactName AS `E Contact Name`,emergencyContactNumber AS `E Contact Number` FROM patient_details";
            MySqlCommand command = new MySqlCommand(query, conn);

            DataTable patientTable = new DataTable();

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(patientTable);
                    BindingSource patientbindingSource = new BindingSource();
                    patientbindingSource.DataSource = patientTable;
                    dgvPatients.DataSource = patientbindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvPat = new DataGridView();
            dgvPat = dgvPatients;
            txtPatientCode.Text = dgvPat.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvPat.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvPat.CurrentRow.Cells[2].Value.ToString();
            txtContactNumber.Text = dgvPat.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvPat.CurrentRow.Cells[4].Value.ToString();
            dtpDateOfBirth.Text = dgvPat.CurrentRow.Cells[5].Value.ToString();
            if (dgvPat.CurrentRow.Cells[6].Value.ToString() == "Male")
            {
                cmbGender.SelectedIndex = 0;
            }
            else
            {
                cmbGender.SelectedIndex = 1;
            }
            txtAddress.Text = dgvPat.CurrentRow.Cells[7].Value.ToString();
            txtEContactName.Text = dgvPat.CurrentRow.Cells[8].Value.ToString();
            txtEContactNumber.Text = dgvPat.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtPatientCode.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            dtpDateOfBirth.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtEContactName.Text = "";
            txtEContactNumber.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string patientCode = txtPatientCode.Text;
            string statement = "SELECT * FROM patient_details WHERE patientCode = '" + patientCode + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Patient Code already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO patient_details " +
                                     "(patientCode,patientFName,patientLName,contactNumber,email,dateOfBirth,gender,address,emergencyContactName,emergencyContactNumber)" +
                                 "VALUES " +
                                     "(@patientCode,@patientFName,@patientLName,@contactNumber,@email,@dateOfBirth,@gender,@address,@emergencyContactName,@emergencyContactNumber)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@patientCode", txtPatientCode.Text);
                    command.Parameters.AddWithValue("@patientFName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@patientLName", txtLastName.Text);
                    command.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                    command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@emergencyContactName", txtEContactName.Text);
                    command.Parameters.AddWithValue("@emergencyContactNumber", txtEContactNumber.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_patient_details();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();
            string patientCode = txtPatientCode.Text;
            string updateQuery = "UPDATE patient_details " +
                                    "SET " +
                                        "patientFName = @patientFName, " +
                                        "patientLName = @patientLName, " +
                                        "contactNumber = @contactNumber, " +
                                        "email = @email, " +
                                        "dateOfBirth = @dateOfBirth, " +
                                        "gender = @gender, " +
                                        "address = @address, " +
                                        "emergencyContactName = @emergencyContactName, " +
                                        "emergencyContactNumber = @emergencyContactNumber " +
                                    "WHERE patientCode = '" + patientCode + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@patientFName", txtFirstName.Text);
                command.Parameters.AddWithValue("@patientLName", txtLastName.Text);
                command.Parameters.AddWithValue("@contactNumber", txtContactNumber.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@emergencyContactName", txtEContactName.Text);
                command.Parameters.AddWithValue("@emergencyContactNumber", txtEContactNumber.Text);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_patient_details();

        }
    }
}
