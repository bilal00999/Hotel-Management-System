using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Public
{
    public partial class frmStaffLogin : Form
    {
        private StaffClass staff = new StaffClass();

        public frmStaffLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = staff.Login(username, password);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Session.StaffID = Convert.ToInt32(row["StaffID"]);
                    Session.StaffName = row["FullName"].ToString();
                    Session.StaffRole = row["Role"].ToString();
                    Session.StaffUsername = row["Username"].ToString();

                    MessageBox.Show($"Welcome {Session.StaffName}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!\nPlease check your credentials.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}