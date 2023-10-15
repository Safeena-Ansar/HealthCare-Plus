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
    public partial class adminPatientReport : Form
    {
        public adminPatientReport()
        {
            InitializeComponent();
            Load_patient_report();
        }

        private void Load_patient_report()
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
                    dgvPatient.DataSource = patientbindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            DataGridView dgvPat = new DataGridView();
            dgvPat = dgvPatient;
            string patientCode = dgvPat.CurrentRow.Cells[0].Value.ToString();
            string patientName = dgvPat.CurrentRow.Cells[1].Value.ToString() + " " + dgvPat.CurrentRow.Cells[2].Value.ToString();

            if (patientCode != string.Empty)
            {
                var objviewPatient = new adminViewPatientDetails(patientCode, patientName);
                objviewPatient.Show();
            }
        }
    }
}
