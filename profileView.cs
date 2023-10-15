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
    public partial class profileView : Form
    {
        public profileView(string empNumber)
        {
            InitializeComponent();

            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT * FROM employee_details WHERE empNumber = '" + empNumber + "';";
            MySqlCommand command = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtFirstName.Text = reader["empFName"].ToString();
                    txtLastName.Text = reader["empLName"].ToString();
                    txtNICnumber.Text = reader["NICnumber"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtContactNumber.Text = reader["contactNumber"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                    txtEmpNumber.Text = reader["empNumber"].ToString();

                    string gender = reader["gender"].ToString();
                    if (gender == "1")
                    {
                        txtGender.Text = "Male";
                    }
                    else
                    {
                        txtGender.Text = "Female";
                    }

                    string userType = reader["userType"].ToString();
                    if (userType == "1")
                    {
                        txtUserType.Text = "Administrator";
                    }
                    else if (userType == "2")
                    {
                        txtGender.Text = "Basic User";
                    }
                    else if (userType == "3")
                    {
                        txtGender.Text = "Health Officials";
                    }
                    else if (userType == "4")
                    {
                        txtGender.Text = "Laboratory Users";
                    }

                    lblUserName.Text = reader["empFName"].ToString() + reader["empLName"].ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profileView_Load(object sender, EventArgs e)
        {

        }
    }
}