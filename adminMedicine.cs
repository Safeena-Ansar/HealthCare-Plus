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
    public partial class adminMedicine : Form
    {
        public adminMedicine()
        {
            InitializeComponent();
        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminMedicine_Load(object sender, EventArgs e)
        {
            load_medicines();
        }

        private void load_medicines()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT medicineCode AS `Medicine Code`, medicineName AS `Medicine Name`, genericName AS `Generic Name`, costPrice AS `Cost Price`, sellingPrice AS `Selling Price`, CASE WHEN status=1 THEN 'In Use' WHEN status=2 THEN 'Not In Use' END AS `Status` FROM medicine_details";
            MySqlCommand command = new MySqlCommand(query, conn);

            DataTable medicineTable = new DataTable();

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(medicineTable);
                    BindingSource MedBindingSource = new BindingSource();
                    MedBindingSource.DataSource = medicineTable;
                    dgvMedicine.DataSource = MedBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvMed = new DataGridView();
            dgvMed = dgvMedicine;
            txtMedicineCode.Text = dgvMedicine.CurrentRow.Cells[0].Value.ToString();
            txtMedicineName.Text = dgvMedicine.CurrentRow.Cells[1].Value.ToString();
            txtGenericName.Text = dgvMedicine.CurrentRow.Cells[2].Value.ToString();
            txtCostPrice.Text = dgvMedicine.CurrentRow.Cells[3].Value.ToString();
            txtSellingPrice.Text = dgvMedicine.CurrentRow.Cells[4].Value.ToString();

            if (dgvMedicine.CurrentRow.Cells[5].Value.ToString() == "In Use")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtMedicineCode.Text = "";
            txtMedicineName.Text = "";
            txtGenericName.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            cmbStatus.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string medicineCode = txtMedicineCode.Text;
            string statement = "SELECT * FROM medicine_details WHERE medicineCode = '" + medicineCode + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Medicine Code already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO medicine_details " +
                                     "(medicineCode, medicineName, genericName, costPrice, sellingPrice, status)" +
                                 "VALUES " +
                                     "(@medicineCode, @medicineName, @genericName, @costPrice, @sellingPrice, @status)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@medicineCode", txtMedicineCode.Text);
                    command.Parameters.AddWithValue("@medicineName", txtMedicineName.Text);
                    command.Parameters.AddWithValue("@genericName", txtGenericName.Text);
                    command.Parameters.AddWithValue("@costPrice", txtCostPrice.Text);
                    command.Parameters.AddWithValue("@sellingPrice", txtSellingPrice.Text);
                    command.Parameters.AddWithValue("@status", (cmbStatus.SelectedIndex) + 1);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_medicines();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string medicineCode = txtMedicineCode.Text;
            string updateQuery = "UPDATE medicine_details SET " +
                                    "medicineName = @medicineName," +
                                    "genericName = @genericName," +
                                    "costPrice = @costPrice," +
                                    "sellingPrice = @sellingPrice," +
                                    "status = @status " +
                                "WHERE " +
                                    "medicineCode = '" + medicineCode + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@medicineName", txtMedicineName.Text);
                command.Parameters.AddWithValue("@genericName", txtGenericName.Text);
                command.Parameters.AddWithValue("@costPrice", txtCostPrice.Text);
                command.Parameters.AddWithValue("@sellingPrice", txtSellingPrice.Text);
                command.Parameters.AddWithValue("@status", (cmbStatus.SelectedIndex) + 1);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_medicines();
        }
    }
}
