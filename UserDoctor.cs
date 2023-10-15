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
    public partial class UserDoctor : Form
    {
        public UserDoctor()
        {
            InitializeComponent();
            Load_doctors_user();
        }

        private void Load_doctors_user()
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

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvDoc = new DataGridView();
            dgvDoc = dgvDoctor;
            string docID = dgvDoc.CurrentRow.Cells[0].Value.ToString();
            string docName = dgvDoc.CurrentRow.Cells[1].Value.ToString() + " " + dgvDoc.CurrentRow.Cells[2].Value.ToString();

            if (docID != "")
            {
                var objuserViewDocSchedule = new userViewDocSchedule(docID, docName);
                objuserViewDocSchedule.Show();
            }
            else
            {
                lblWarningMessage.Show();
            }
        }
    }
}
