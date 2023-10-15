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
    public partial class adminReport : Form
    {
        public adminReport()
        {
            InitializeComponent();
            Load_department_drop();
            Load_speciality_drop();
            Load_doctor_report();
        }

        private void Load_department_drop()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT department FROM doctor_details GROUP BY department";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbDepartment.Items.Add(readPatData["department"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Load_speciality_drop()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string patientQuery = "SELECT speciality FROM doctor_details GROUP BY speciality";
                MySqlCommand patQuery = new MySqlCommand(patientQuery, conn);

                using (MySqlDataReader readPatData = patQuery.ExecuteReader())
                {
                    while (readPatData.Read())
                    {
                        cmbSpeciality.Items.Add(readPatData["speciality"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Load_doctor_report()
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

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            string department = cmbDepartment.Text;
            string speciality = cmbSpeciality.Text;
            string gender = cmbGender.Text;
            string where = "";
            string genderInt = "";

            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT doctorID AS `Doctor ID`,doctorFName AS `First Name`,doctorLName AS `Last Name`,CASE WHEN gender = 1 THEN 'Male' WHEN gender = 2 THEN 'Female' END AS `Gender`,mobileNumber AS `Mobile Number`,email AS `Email`,address AS `Address`,licenseNumber AS `Licensce Number`,speciality AS `Speciality`,qualification AS `Qualification`,department AS `Department` FROM doctor_details";

            if (!string.IsNullOrEmpty(department))
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
                query += "department LIKE '%" + department + "%'";
            }
            if (!string.IsNullOrEmpty(speciality))
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
                query += " speciality LIKE '%" + speciality + "%'";
            }
            if (!string.IsNullOrEmpty(gender))
            {
                if (gender == "Male")
                {
                    genderInt = 1.ToString();
                }
                else
                {
                    genderInt = 2.ToString();
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
                query += " gender ='" + genderInt + "'";
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
            cmbDepartment.Text = string.Empty;
            cmbSpeciality.Text = string.Empty;
            cmbGender.Text = string.Empty;
            btnLoadReport_Click(sender, e);
        }
    }
}
