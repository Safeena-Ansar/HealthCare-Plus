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
    public partial class adminRooms : Form
    {
        public adminRooms()
        {
            InitializeComponent();
        }

        private void adminRooms_Load(object sender, EventArgs e)
        {
            load_room_details();
        }

        private void load_room_details()
        {
            MySqlConnection conn = DBConnection.connectToDb();
            string query = $"SELECT roomNumber AS `Room Number`, CASE WHEN roomType=1 THEN 'Private' WHEN roomType=2 THEN 'Ward' WHEN roomType=3 THEN 'ICU' WHEN roomType=4 THEN 'PCU' END AS `Room Type`, roomCapacity AS `Room Capacity`, roomRate AS `Room Price`, note AS `Notes` FROM room_details";
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable roomTable = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(roomTable);
                    BindingSource roomBindingSource = new BindingSource();
                    roomBindingSource.DataSource = roomTable;
                    dgvRooms.DataSource = roomBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblWarningMessage.Hide();
            DataGridView dgvRoom = new DataGridView();
            dgvRoom = dgvRooms;
            txtRoomNumber.Text = dgvRoom.CurrentRow.Cells[0].Value.ToString();
            txtRoomCapacity.Text = dgvRoom.CurrentRow.Cells[2].Value.ToString();
            txtRoomPrice.Text = dgvRoom.CurrentRow.Cells[3].Value.ToString();
            txtNote.Text = dgvRoom.CurrentRow.Cells[4].Value.ToString();

            if (dgvRoom.CurrentRow.Cells[1].Value.ToString() == "Private")
            {
                cmbRoomType.SelectedIndex = 0;
            }
            else if (dgvRoom.CurrentRow.Cells[1].Value.ToString() == "Ward")
            {
                cmbRoomType.SelectedIndex = 1;
            }
            else if (dgvRoom.CurrentRow.Cells[1].Value.ToString() == "ICU")
            {
                cmbRoomType.SelectedIndex = 2;
            }
            else if (dgvRoom.CurrentRow.Cells[1].Value.ToString() == "PCU")
            {
                cmbRoomType.SelectedIndex = 3;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            txtRoomNumber.Text = "";
            txtRoomCapacity.Text = "";
            txtRoomPrice.Text = "";
            txtNote.Text = "";
            cmbRoomType.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string roomNumber = txtRoomNumber.Text;
            string statement = "SELECT * FROM room_details WHERE roomNumber = '" + roomNumber + "'";
            MySqlCommand userQuery = new MySqlCommand(statement, conn);
            MySqlDataReader readData = userQuery.ExecuteReader();
            if (readData.Read())
            {
                lblWarningMessage.Text = "* Room Number already Exist.";
                lblWarningMessage.Show();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string insertQuery = "INSERT INTO room_details " +
                                     "(roomNumber, roomType, roomCapacity, roomRate, note)" +
                                 "VALUES " +
                                     "(@roomNumber, @roomType, @roomCapacity, @roomRate, @note)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@roomNumber", txtRoomNumber.Text);
                    command.Parameters.AddWithValue("@roomType", (cmbRoomType.SelectedIndex) + 1);
                    command.Parameters.AddWithValue("@roomCapacity", txtRoomCapacity.Text);
                    command.Parameters.AddWithValue("@roomRate", txtRoomPrice.Text);
                    command.Parameters.AddWithValue("@note", txtNote.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                load_room_details();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblWarningMessage.Hide();
            MySqlConnection conn = DBConnection.connectToDb();

            string roomNumber = txtRoomNumber.Text;
            string updateQuery = "UPDATE room_details SET " +
                                    "roomType = @roomType," +
                                    "roomCapacity = @roomCapacity," +
                                    "roomRate = @roomRate," +
                                    "note = @note " +
                                "WHERE " +
                                    "roomNumber = '" + roomNumber + "'";

            using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
            {
                command.Parameters.AddWithValue("@roomType", (cmbRoomType.SelectedIndex) + 1);
                command.Parameters.AddWithValue("@roomCapacity", txtRoomCapacity.Text);
                command.Parameters.AddWithValue("@roomRate", txtRoomPrice.Text);
                command.Parameters.AddWithValue("@note", txtNote.Text);

                int rowsAffected = command.ExecuteNonQuery();
            }
            load_room_details();
        }
    }
}
