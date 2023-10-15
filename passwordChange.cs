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
    public partial class passwordChange : Form
    {
        private string empNumber;
        public passwordChange(string empNumber, string empName)
        {
            InitializeComponent();
            lblChangePassword.Text = "Change Password for " + empName;
            this.empNumber = empNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard objadminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
            if (objadminDashboard != null)
            {
                objadminDashboard.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string empPassword = txtEmpPassword.Text;
            string empUserName = txtUserName.Text;

            if (empNumber != "")
            {
                MySqlConnection conn = DBConnection.connectToDb();
                string statement = "SELECT * FROM user_login WHERE empNumber = '" + empNumber + "'";
                MySqlCommand userQuery = new MySqlCommand(statement, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    conn.Close();
                    conn.Open();
                    string updateQuery = "UPDATE user_login SET " +
                                            "username = @username," +
                                            "password = @password " +
                                        "WHERE " +
                                            "empNumber = '" + empNumber + "'";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@username", empUserName);
                        command.Parameters.AddWithValue("@password", empPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                    }

                    this.Close();
                    adminDashboard objadminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
                    if (objadminDashboard != null)
                    {
                        objadminDashboard.Focus();
                    }
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string insertQuery = "INSERT INTO user_login " +
                                        "(username, password, empNumber)" +
                                    "VALUES " +
                                        "(@username, @password, @empNumber)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@username", empUserName);
                        command.Parameters.AddWithValue("@password", empPassword);
                        command.Parameters.AddWithValue("@empNumber", empNumber);

                        int rowsAffected = command.ExecuteNonQuery();
                    }

                    this.Close();
                    adminDashboard objadminDashboard = Application.OpenForms.OfType<adminDashboard>().FirstOrDefault();
                    if (objadminDashboard != null)
                    {
                        objadminDashboard.Focus();
                    }
                }
            }
        }
    }
}
