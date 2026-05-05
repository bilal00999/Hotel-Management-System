using System;
using System.Data;
using System.Windows.Forms;
using HotelManagementSystem.Forms.Public; 

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmManageRooms : Form
    {
        private RoomClass room = new RoomClass();
        private DataTable dtRooms;

        public frmManageRooms()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            dtRooms = room.GetAllRooms();
            dgvRooms.DataSource = dtRooms;
            FormatGridView();
        }

        private void FormatGridView()
        {
            if (dgvRooms.Columns.Contains("RoomID"))
                dgvRooms.Columns["RoomID"].Visible = false;
            if (dgvRooms.Columns.Contains("CreatedDate"))
                dgvRooms.Columns["CreatedDate"].Visible = false;

            dgvRooms.Columns["RoomNumber"].HeaderText = "Room No";
            dgvRooms.Columns["RoomType"].HeaderText = "Room Type";
            dgvRooms.Columns["Price"].HeaderText = "Price/Night";
            dgvRooms.Columns["Status"].HeaderText = "Status";
            dgvRooms.Columns["Capacity"].HeaderText = "Capacity";
            dgvRooms.Columns["Floor"].HeaderText = "Floor";
            dgvRooms.Columns["Description"].HeaderText = "Description";

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "Available")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
                frmAddRoom editRoom = new frmAddRoom(roomId);
                editRoom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a room to edit!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
                string roomNumber = dgvRooms.SelectedRows[0].Cells["RoomNumber"].Value.ToString();
                string status = dgvRooms.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Booked")
                {
                    MessageBox.Show("Cannot delete a room that is currently booked!", "Delete Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete Room #{roomNumber}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = room.DeleteRoom(roomId);
                    if (success)
                    {
                        MessageBox.Show("Room deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRooms();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete room.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}