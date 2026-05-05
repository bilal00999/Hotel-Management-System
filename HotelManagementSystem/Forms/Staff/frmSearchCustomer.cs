using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Staff
{
    public partial class frmSearchCustomer : Form
    {
        private CustomerClass customer = new CustomerClass();
        private DataTable dtCustomers;

        public frmSearchCustomer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter search term!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtCustomers = customer.SearchCustomer(searchTerm);
            dgvCustomers.DataSource = dtCustomers;
            FormatGridView();
            lblResultCount.Text = $"Found {dtCustomers.Rows.Count} customer(s)";
        }

        private void FormatGridView()
        {
            if (dgvCustomers.Columns.Contains("CustomerID"))
                dgvCustomers.Columns["CustomerID"].Visible = false;

            dgvCustomers.Columns["CustomerNumber"].HeaderText = "Customer No";
            dgvCustomers.Columns["Name"].HeaderText = "Name";
            dgvCustomers.Columns["Phone"].HeaderText = "Phone";
            dgvCustomers.Columns["Email"].HeaderText = "Email";
            dgvCustomers.Columns["TotalVisits"].HeaderText = "Visits";
            dgvCustomers.Columns["TotalSpent"].HeaderText = "Total Spent";
            dgvCustomers.Columns["IsVIP"].HeaderText = "VIP";

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (Convert.ToBoolean(row.Cells["IsVIP"].Value))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                string customerName = dgvCustomers.SelectedRows[0].Cells["Name"].Value.ToString();

                Session.SetCurrentCustomer(customerId, customerName);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a customer!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                DataTable dt = customer.GetCustomerById(customerId);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string details = $"Customer Details\n\n" +
                                    $"Customer No: {row["CustomerNumber"]}\n" +
                                    $"Name: {row["Name"]}\n" +
                                    $"Phone: {row["Phone"]}\n" +
                                    $"Email: {row["Email"]}\n" +
                                    $"Address: {row["Address"]}\n" +
                                    $"ID Proof: {row["IDProof"]}\n" +
                                    $"ID Number: {row["IDNumber"]}\n" +
                                    $"Nationality: {row["Nationality"]}\n" +
                                    $"VIP: {(Convert.ToBoolean(row["IsVIP"]) ? "Yes" : "No")}\n" +
                                    $"Total Visits: {row["TotalVisits"]}\n" +
                                    $"Total Spent: PKR {Convert.ToDecimal(row["TotalSpent"]):N2}";

                    MessageBox.Show(details, "Customer Details",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            frmCreateCustomer createCustomer = new frmCreateCustomer();
            if (createCustomer.ShowDialog() == DialogResult.OK)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }
    }
}