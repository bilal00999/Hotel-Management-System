using System;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmAddStaff : Form
    {
        private StaffClass staff = new StaffClass();
        private int editStaffId = -1;
        private bool isEditMode = false;

        public frmAddStaff(int staffId = -1)
        {
            InitializeComponent();
            if (staffId != -1)
            {
                editStaffId = staffId;
                isEditMode = true;
                LoadStaffData();
                this.Text = "Edit Staff";
                btnSave.Text = "Update Staff";
                txtPassword.Enabled = false;
                lblPasswordNote.Visible = true;
            }
            else
            {
                this.Text = "Add New Staff";
                btnSave.Text = "Add Staff";
                lblPasswordNote.Visible = false;
            }
        }

        private void LoadStaffData()
        {
            var dt = staff.GetStaffById(editStaffId);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                txtUsername.Text = row["Username"].ToString();
                txtFullName.Text = row["FullName"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                cmbRole.Text = row["Role"].ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isEditMode && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select role!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!isEditMode && staff.IsUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                bool success;
                string successMessage;

                if (isEditMode)
                {
                    success = staff.UpdateStaff(editStaffId, txtFullName.Text, txtEmail.Text, txtPhone.Text, cmbRole.Text);
                    successMessage = "Staff updated successfully!";
                }
                else
                {
                    success = staff.AddStaff(txtUsername.Text, txtPassword.Text, txtFullName.Text, txtEmail.Text, txtPhone.Text, cmbRole.Text);
                    successMessage = "Staff added successfully!";
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
    }
}