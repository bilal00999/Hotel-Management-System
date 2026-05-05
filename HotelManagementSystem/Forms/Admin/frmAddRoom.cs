using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmAddRoom : Form
    {
        private RoomClass room = new RoomClass();
        private int editRoomId = -1;
        private bool isEditMode = false;

        public frmAddRoom(int roomId = -1)
        {
            InitializeComponent();
            if (roomId != -1)
            {
                editRoomId = roomId;
                isEditMode = true;
                LoadRoomData();
                this.Text = "Edit Room";
                btnSave.Text = "Update Room";
            }
            else
            {
                this.Text = "Add New Room";
                btnSave.Text = "Add Room";
            }
        }

        private void LoadRoomData()
        {
            var dt = room.GetRoomById(editRoomId);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                txtRoomNumber.Text = row["RoomNumber"].ToString();
                cmbRoomType.Text = row["RoomType"].ToString();
                txtPrice.Text = row["Price"].ToString();
                numCapacity.Value = Convert.ToInt32(row["Capacity"]);
                numFloor.Value = Convert.ToInt32(row["Floor"]);
                txtDescription.Text = row["Description"].ToString();
                txtFeatures.Text = row["Features"].ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter room number!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomNumber.Focus();
                return false;
            }

            if (cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select room type!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                int roomNumber = Convert.ToInt32(txtRoomNumber.Text);
                string roomType = cmbRoomType.SelectedItem.ToString();
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int capacity = (int)numCapacity.Value;
                int floor = (int)numFloor.Value;
                string description = txtDescription.Text;
                string features = txtFeatures.Text;

                bool success;
                string successMessage;

                if (isEditMode)
                {
                    success = room.UpdateRoom(editRoomId, roomNumber, roomType, price, description, capacity, floor, features);
                    successMessage = "Room updated successfully!";
                }
                else
                {
                    if (room.IsRoomNumberExists(roomNumber))
                    {
                        MessageBox.Show("Room number already exists!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    success = room.AddRoom(roomNumber, roomType, price, description, capacity, floor, features);
                    successMessage = "Room added successfully!";
                }

                if (success)
                {
                    MessageBox.Show(successMessage, "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation failed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}