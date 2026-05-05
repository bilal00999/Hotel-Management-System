using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmManageStaff : Form
    {
        private StaffClass staff = new StaffClass();
        private DataTable dtStaff;

        public frmManageStaff()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            dtStaff = staff.GetAllStaff();
            dgvStaff.DataSource = dtStaff;
            FormatGridView();
            UpdateStats();
        }

        private void FormatGridView()
        {
            if (dgvStaff.Columns.Contains("StaffID"))
                dgvStaff.Columns["StaffID"].Visible = false;
            if (dgvStaff.Columns.Contains("Password"))
                dgvStaff.Columns["Password"].Visible = false;

            dgvStaff.Columns["Username"].HeaderText = "Username";
            dgvStaff.Columns["FullName"].HeaderText = "Full Name";
            dgvStaff.Columns["Email"].HeaderText = "Email";
            dgvStaff.Columns["Phone"].HeaderText = "Phone";
            dgvStaff.Columns["Role"].HeaderText = "Role";
            dgvStaff.Columns["IsActive"].HeaderText = "Active";
            dgvStaff.Columns["CreatedDate"].HeaderText = "Created";

            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsActive"].Value))
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void UpdateStats()
        {
            int total = dtStaff.Rows.Count;
            int active = 0, inactive = 0;
            int receptionist = 0, manager = 0, admin = 0;

            foreach (DataRow row in dtStaff.Rows)
            {
                if (Convert.ToBoolean(row["IsActive"])) active++;
                else inactive++;

                string role = row["Role"].ToString();
                if (role == "Receptionist") receptionist++;
                else if (role == "Manager") manager++;
                else if (role == "SuperAdmin") admin++;
            }

            lblTotalStaff.Text = total.ToString();
            lblActiveStaff.Text = active.ToString();
            lblInactiveStaff.Text = inactive.ToString();
            lblReceptionists.Text = receptionist.ToString();
            lblManagers.Text = manager.ToString();
            lblAdmins.Text = admin.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            if (addStaff.ShowDialog() == DialogResult.OK)
                LoadStaff();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                int staffId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["StaffID"].Value);
                string currentRole = dgvStaff.SelectedRows[0].Cells["Role"].Value.ToString();

                if (currentRole == "SuperAdmin" && Session.StaffID != staffId)
                {
                    MessageBox.Show("Cannot edit another SuperAdmin account!", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmAddStaff editStaff = new frmAddStaff(staffId);
                if (editStaff.ShowDialog() == DialogResult.OK)
                    LoadStaff();
            }
            else
            {
                MessageBox.Show("Please select a staff member!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                int staffId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["StaffID"].Value);
                string username = dgvStaff.SelectedRows[0].Cells["Username"].Value.ToString();
                string role = dgvStaff.SelectedRows[0].Cells["Role"].Value.ToString();

                if (role == "SuperAdmin" && Session.StaffID != staffId)
                {
                    MessageBox.Show("Cannot reset password for another SuperAdmin!", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Reset password for '{username}' to default 'password123'?",
                    "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (staff.UpdateStaffPassword(staffId, "password123"))
                    {
                        MessageBox.Show("Password reset successfully!\nNew password: password123", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                int staffId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells["StaffID"].Value);
                string username = dgvStaff.SelectedRows[0].Cells["Username"].Value.ToString();
                bool isActive = Convert.ToBoolean(dgvStaff.SelectedRows[0].Cells["IsActive"].Value);
                string role = dgvStaff.SelectedRows[0].Cells["Role"].Value.ToString();

                if (role == "SuperAdmin" && Session.StaffID != staffId)
                {
                    MessageBox.Show("Cannot modify another SuperAdmin account!", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"{(isActive ? "Deactivate" : "Activate")} staff '{username}'?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (staff.DeactivateStaff(staffId, !isActive))
                    {
                        MessageBox.Show($"Staff {(isActive ? "deactivated" : "activated")} successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaff();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}