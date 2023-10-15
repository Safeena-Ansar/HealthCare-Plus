using MySql.Data.MySqlClient;
using System.Drawing;

namespace HealthCare_Plus
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtUsername.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;
            lblLoginValidation.Hide();

            if (username == null)
            {
                lblVerifyUsername.Show();
            }
            else if (password == null)
            {
                lblVerifyPassword.Show();
            }
            else
            {
                verifyLogin(username, password);
            }
        }

        private void verifyLogin(string username, string password)
        {
            MySqlConnection conn = DBConnection.connectToDb();
            try
            {
                string columnName = "empNumber";
                string userTypeColumn = "userType";
                string statement = "SELECT * FROM user_login JOIN employee_details ON employee_details.empNumber = user_login.empNumber WHERE username = '" + username + "' AND password = '" + password + "'";
                MySqlCommand userQuery = new MySqlCommand(statement, conn);
                MySqlDataReader readData = userQuery.ExecuteReader();
                if (readData.Read())
                {
                    lblLoginValidation.Hide();
                    string empNumber = readData[columnName].ToString();
                    string userType = readData[userTypeColumn].ToString();
                    if(userType == "1")
                    {
                        var objadminDashboard = new adminDashboard(empNumber);
                        objadminDashboard.Show();
                    } else if(userType == "2")
                    {
                        var objUserDashboard = new UserDashboard(empNumber);
                        objUserDashboard.Show();
                        
                    }
                    else if (userType == "3")
                    {
                        var objofficialDashboard = new officialDashboard(empNumber);
                        objofficialDashboard.Show(); 
                    }
                    else if (userType == "4")
                    {
                        var objlabDashboard = new labDashboard(empNumber);
                        objlabDashboard.Show(); 
                    }
                    Visible = false;
                }
                else
                {
                    lblLoginValidation.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            lblVerifyPassword.Hide();
            lblLoginValidation.Hide();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            lblVerifyUsername.Hide();
            lblLoginValidation.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}