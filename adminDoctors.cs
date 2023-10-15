using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class adminDoctors : Form
    {
        public adminDoctors()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDoctors_Load(object sender, EventArgs e)
        {
            load_doctors_details();
        }

        private void load_doctors_details()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT doctorID AS `Doctor ID`,doctorFName AS `First Name`,doctorLName AS `Last Name`,CASE WHEN gender = 1 THEN 'Male' WHEN gender = 2 THEN 'Female' END AS `Gender`,mobileNumber AS `Mobile Number`,email AS `Email`,address AS `Address`,licenseNumber AS `Licensce Number`,speciality AS `Speciality`,qualification AS `Qualification`,department AS `Department` FROM doctor_details";
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

        private void dgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvDoc = new DataGridView();
            dgvDoc = dgvDoctor;
            txtDoctorID.Text = dgvDoc.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvDoc.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvDoc.CurrentRow.Cells[2].Value.ToString();
            txtContactNumber.Text = dgvDoc.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvDoc.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvDoc.CurrentRow.Cells[6].Value.ToString();

            txtLicenseNumber.Text = dgvDoc.CurrentRow.Cells[7].Value.ToString();
            txtSpeciality.Text = dgvDoc.CurrentRow.Cells[8].Value.ToString();
            txtQualifications.Text = dgvDoc.CurrentRow.Cells[9].Value.ToString();
            txtDepartment.Text = dgvDoc.CurrentRow.Cells[10].Value.ToString();

            if (dgvDoc.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                cmbGender.SelectedIndex = 0;
            }
            else
            {
                cmbGender.SelectedIndex = 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtDoctorID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            txtLicenseNumber.Text = "";
            txtSpeciality.Text = "";
            txtQualifications.Text = "";
            txtDepartment.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string docID = txtDoctorID.Text;
            string licenseNumber = txtLicenseNumber.Text;
            string statement = "SELECT * FROM doctor_details WHERE licenseNumber = '" + licenseNumber + "' OR doctorID = '" + docID + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Doctor ID or License Number already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO doctor_details " +
                                     "(doctorID, doctorFName, doctorLName,gender,mobileNumber,email,address,licenseNumber,speciality,qualification,department)" +
                                 "VALUES " +
                                     "(@doctorID, @doctorFName, @doctorLName, @gender, @mobileNumber, @email, @address, @licenseNumber, @speciality, @qualification, @department)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@doctorID", txtDoctorID.Text);
                    command.Parameters.AddWithValue("@doctorFName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@doctorLName", txtLastName.Text);
                    command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@mobileNumber", txtContactNumber.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@licenseNumber", txtLicenseNumber.Text);
                    command.Parameters.AddWithValue("@speciality", txtSpeciality.Text);
                    command.Parameters.AddWithValue("@qualification", txtQualifications.Text);
                    command.Parameters.AddWithValue("@department", txtDepartment.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_doctors_details();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();
            string docID = txtDoctorID.Text;
            string licenseNumber = txtLicenseNumber.Text;
            string statement = "SELECT * FROM doctor_details WHERE licenseNumber = '" + licenseNumber + "' AND doctorID != '" + docID + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* License Number already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string updateQuery = "UPDATE employee_details SET " +
                                        "doctorFName = @doctorFName," +
                                        "doctorLName = @doctorLName," +
                                        "gender = @gender," +
                                        "mobileNumber = @mobileNumber," +
                                        "email = @email," +
                                        "address = @address," +
                                        "licenseNumber = @licenseNumber," +
                                        "speciality = @speciality," +
                                        "qualification = @qualification," +
                                        "department = @department " +
                                    "WHERE " +
                                        "doctorID = '" + docID + "'";

                using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@doctorFName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@doctorLName", txtLastName.Text);
                    command.Parameters.AddWithValue("@gender", (cmbGender.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@mobileNumber", txtContactNumber.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@licenseNumber", txtLicenseNumber.Text);
                    command.Parameters.AddWithValue("@speciality", txtSpeciality.Text);
                    command.Parameters.AddWithValue("@qualification", txtQualifications.Text);
                    command.Parameters.AddWithValue("@department", txtDepartment.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_doctors_details();
            }
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            string docID = txtDoctorID.Text;
            string docName = txtFirstName.Text + " " + txtLastName.Text;

            if (docID != "")
            {
                var objuserViewDocSchedule = new adminDocSchedule(docID, docName);
                objuserViewDocSchedule.Show();
            }
        }
    }
}
