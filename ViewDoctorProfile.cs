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
    public partial class ViewDoctorProfile : Form
    {
        public ViewDoctorProfile(string DocID)
        {
            InitializeComponent();
            Load_doctor_details(DocID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Load_doctor_details(string DocID)
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string query = "SELECT doctorID, CONCAT(doctorFName, ' ', doctorLName) AS doctorName, CASE WHEN gender = 1 THEN 'Male' WHEN gender = 2 THEN 'Female' END as gender, licenseNumber, speciality, qualification, department FROM doctor_details WHERE doctorID = '" + DocID + "'";
                MySqlCommand userQuery = new MySqlCommand(query, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    lblDoctorNameView.Text = readData["doctorName"].ToString();
                    lblDoctorIDView.Text = DocID;
                    lblQualificationView.Text = readData["qualification"].ToString();
                    lblDepartmentView.Text = readData["department"].ToString();
                    lblSpecialityView.Text = readData["speciality"].ToString();
                    lblGenderView.Text = readData["gender"].ToString();
                    lblLicenceNoView.Text = readData["licenseNumber"].ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
