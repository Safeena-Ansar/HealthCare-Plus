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
    public partial class adminTheaters : Form
    {
        public adminTheaters()
        {
            InitializeComponent();
        }

        private void adminTheaters_Load(object sender, EventArgs e)
        {
            load_theater_details();
        }

        private void load_theater_details()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT theaterRoomNumber AS `Theater Number`, CASE WHEN theaterRoomType = 1 THEN 'Operating Room' WHEN theaterRoomType = 2 THEN 'Surgical Suite' END AS `Theater Type`, theaterRoomCapacity AS `Theater Capacity`, theaterRoomRate AS `Theater Rate`, note AS `Notes` FROM theater_details";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable theaterTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(theaterTable);
                    BindingSource theaterBindingSource = new BindingSource();
                    theaterBindingSource.DataSource = theaterTable;
                    dgvTheaters.DataSource = theaterBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvTheaters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvTheater = new DataGridView();
            dgvTheater = dgvTheaters;
            txtTheaterNumber.Text = dgvTheater.CurrentRow.Cells[0].Value.ToString();
            txtTheaterCapacity.Text = dgvTheater.CurrentRow.Cells[2].Value.ToString();
            txtTheaterPrice.Text = dgvTheater.CurrentRow.Cells[3].Value.ToString();
            txtNote.Text = dgvTheater.CurrentRow.Cells[4].Value.ToString();

            if (dgvTheater.CurrentRow.Cells[1].Value.ToString() == "Operating Room")
            {
                cmbTheaterType.SelectedIndex = 0;
            }
            else if (dgvTheater.CurrentRow.Cells[1].Value.ToString() == "Surgical Suite")
            {
                cmbTheaterType.SelectedIndex = 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtTheaterNumber.Text = "";
            txtTheaterCapacity.Text = "";
            txtTheaterPrice.Text = "";
            txtNote.Text = "";
            cmbTheaterType.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string theaterNumber = txtTheaterNumber.Text;
            string statement = "SELECT * FROM theater_details WHERE theaterRoomNumber = '" + theaterNumber + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Theater Number already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO theater_details " +
                                     "(theaterRoomNumber, theaterRoomType, theaterRoomCapacity, theaterRoomRate, note)" +
                                 "VALUES " +
                                     "(@theaterRoomNumber, @theaterRoomType, @theaterRoomCapacity, @theaterRoomRate, @note)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@theaterRoomNumber", txtTheaterNumber.Text);
                    command.Parameters.AddWithValue("@theaterRoomType", (cmbTheaterType.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@theaterRoomCapacity", txtTheaterCapacity.Text);
                    command.Parameters.AddWithValue("@theaterRoomRate", txtTheaterPrice.Text);
                    command.Parameters.AddWithValue("@note", txtNote.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_theater_details();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string theaterNumber = txtTheaterNumber.Text;
            string updateQuery = "UPDATE theater_details SET " +
                                    "theaterRoomType = @theaterRoomType," +
                                    "theaterRoomCapacity = @theaterRoomCapacity," +
                                    "theaterRoomRate = @theaterRoomRate," +
                                    "note = @note " +
                                "WHERE " +
                                    "theaterRoomNumber = '" + theaterNumber + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@theaterRoomType", (cmbTheaterType.SelectedIndex) + 1);
                command.Parameters.AddWithValue("@theaterRoomCapacity", txtTheaterCapacity.Text);
                command.Parameters.AddWithValue("@theaterRoomRate", txtTheaterPrice.Text);
                command.Parameters.AddWithValue("@note", txtNote.Text);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_theater_details();
        }
    }
}
