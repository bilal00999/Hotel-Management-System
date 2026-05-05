using HotelManagementSystem.Forms.Public;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    partial class frmManageStaff
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalStaff;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblActiveStaff;
        private System.Windows.Forms.Label lblActiveLabel;
        private System.Windows.Forms.Panel pnlInactive;
        private System.Windows.Forms.Label lblInactiveStaff;
        private System.Windows.Forms.Label lblInactiveLabel;
        private System.Windows.Forms.Panel pnlReceptionists;
        private System.Windows.Forms.Label lblReceptionists;
        private System.Windows.Forms.Label lblReceptionistsLabel;
        private System.Windows.Forms.Panel pnlManagers;
        private System.Windows.Forms.Label lblManagers;
        private System.Windows.Forms.Label lblManagersLabel;
        private System.Windows.Forms.Panel pnlAdmins;
        private System.Windows.Forms.Label lblAdmins;
        private System.Windows.Forms.Label lblAdminsLabel;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnToggleActive = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlAdmins = new System.Windows.Forms.Panel();
            this.lblAdmins = new System.Windows.Forms.Label();
            this.lblAdminsLabel = new System.Windows.Forms.Label();
            this.pnlManagers = new System.Windows.Forms.Panel();
            this.lblManagers = new System.Windows.Forms.Label();
            this.lblManagersLabel = new System.Windows.Forms.Label();
            this.pnlReceptionists = new System.Windows.Forms.Panel();
            this.lblReceptionists = new System.Windows.Forms.Label();
            this.lblReceptionistsLabel = new System.Windows.Forms.Label();
            this.pnlInactive = new System.Windows.Forms.Panel();
            this.lblInactiveStaff = new System.Windows.Forms.Label();
            this.lblInactiveLabel = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblActiveStaff = new System.Windows.Forms.Label();
            this.lblActiveLabel = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalStaff = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.pnlAdmins.SuspendLayout();
            this.pnlManagers.SuspendLayout();
            this.pnlReceptionists.SuspendLayout();
            this.pnlInactive.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 45);
            this.pnlHeader.TabIndex = 0;

            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(930, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Staff";

            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnToggleActive);
            this.pnlMain.Controls.Add(this.btnResetPassword);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.dgvStaff);
            this.pnlMain.Controls.Add(this.pnlStats);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1000, 500);
            this.pnlMain.TabIndex = 1;

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(900, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnToggleActive
            // 
            this.btnToggleActive.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleActive.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnToggleActive.ForeColor = System.Drawing.Color.White;
            this.btnToggleActive.Location = new System.Drawing.Point(310, 450);
            this.btnToggleActive.Name = "btnToggleActive";
            this.btnToggleActive.Size = new System.Drawing.Size(120, 32);
            this.btnToggleActive.TabIndex = 5;
            this.btnToggleActive.Text = "Toggle Active";
            this.btnToggleActive.UseVisualStyleBackColor = false;
            this.btnToggleActive.Click += new System.EventHandler(this.btnToggleActive_Click);

            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(200, 450);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(95, 32);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Reset Pwd";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(100, 450);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.Location = new System.Drawing.Point(15, 135);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(970, 300);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.pnlAdmins);
            this.pnlStats.Controls.Add(this.pnlManagers);
            this.pnlStats.Controls.Add(this.pnlReceptionists);
            this.pnlStats.Controls.Add(this.pnlInactive);
            this.pnlStats.Controls.Add(this.pnlActive);
            this.pnlStats.Controls.Add(this.pnlTotal);
            this.pnlStats.Location = new System.Drawing.Point(15, 12);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(970, 110);
            this.pnlStats.TabIndex = 0;

            // 
            // pnlAdmins
            // 
            this.pnlAdmins.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.pnlAdmins.Controls.Add(this.lblAdmins);
            this.pnlAdmins.Controls.Add(this.lblAdminsLabel);
            this.pnlAdmins.Location = new System.Drawing.Point(810, 15);
            this.pnlAdmins.Name = "pnlAdmins";
            this.pnlAdmins.Size = new System.Drawing.Size(140, 70);
            this.pnlAdmins.TabIndex = 5;

            // 
            // lblAdmins
            // 
            this.lblAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdmins.ForeColor = System.Drawing.Color.White;
            this.lblAdmins.Location = new System.Drawing.Point(0, 15);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(140, 25);
            this.lblAdmins.TabIndex = 1;
            this.lblAdmins.Text = "0";
            this.lblAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblAdminsLabel
            // 
            this.lblAdminsLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAdminsLabel.ForeColor = System.Drawing.Color.White;
            this.lblAdminsLabel.Location = new System.Drawing.Point(0, 45);
            this.lblAdminsLabel.Name = "lblAdminsLabel";
            this.lblAdminsLabel.Size = new System.Drawing.Size(140, 18);
            this.lblAdminsLabel.TabIndex = 0;
            this.lblAdminsLabel.Text = "SuperAdmins";
            this.lblAdminsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlManagers
            // 
            this.pnlManagers.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlManagers.Controls.Add(this.lblManagers);
            this.pnlManagers.Controls.Add(this.lblManagersLabel);
            this.pnlManagers.Location = new System.Drawing.Point(655, 15);
            this.pnlManagers.Name = "pnlManagers";
            this.pnlManagers.Size = new System.Drawing.Size(140, 70);
            this.pnlManagers.TabIndex = 4;

            // 
            // lblManagers
            // 
            this.lblManagers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblManagers.ForeColor = System.Drawing.Color.White;
            this.lblManagers.Location = new System.Drawing.Point(0, 15);
            this.lblManagers.Name = "lblManagers";
            this.lblManagers.Size = new System.Drawing.Size(140, 25);
            this.lblManagers.TabIndex = 1;
            this.lblManagers.Text = "0";
            this.lblManagers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblManagersLabel
            // 
            this.lblManagersLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblManagersLabel.ForeColor = System.Drawing.Color.White;
            this.lblManagersLabel.Location = new System.Drawing.Point(0, 45);
            this.lblManagersLabel.Name = "lblManagersLabel";
            this.lblManagersLabel.Size = new System.Drawing.Size(140, 18);
            this.lblManagersLabel.TabIndex = 0;
            this.lblManagersLabel.Text = "Managers";
            this.lblManagersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlReceptionists
            // 
            this.pnlReceptionists.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.pnlReceptionists.Controls.Add(this.lblReceptionists);
            this.pnlReceptionists.Controls.Add(this.lblReceptionistsLabel);
            this.pnlReceptionists.Location = new System.Drawing.Point(500, 15);
            this.pnlReceptionists.Name = "pnlReceptionists";
            this.pnlReceptionists.Size = new System.Drawing.Size(140, 70);
            this.pnlReceptionists.TabIndex = 3;

            // 
            // lblReceptionists
            // 
            this.lblReceptionists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReceptionists.ForeColor = System.Drawing.Color.White;
            this.lblReceptionists.Location = new System.Drawing.Point(0, 15);
            this.lblReceptionists.Name = "lblReceptionists";
            this.lblReceptionists.Size = new System.Drawing.Size(140, 25);
            this.lblReceptionists.TabIndex = 1;
            this.lblReceptionists.Text = "0";
            this.lblReceptionists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblReceptionistsLabel
            // 
            this.lblReceptionistsLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblReceptionistsLabel.ForeColor = System.Drawing.Color.White;
            this.lblReceptionistsLabel.Location = new System.Drawing.Point(0, 45);
            this.lblReceptionistsLabel.Name = "lblReceptionistsLabel";
            this.lblReceptionistsLabel.Size = new System.Drawing.Size(140, 18);
            this.lblReceptionistsLabel.TabIndex = 0;
            this.lblReceptionistsLabel.Text = "Receptionists";
            this.lblReceptionistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlInactive
            // 
            this.pnlInactive.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.pnlInactive.Controls.Add(this.lblInactiveStaff);
            this.pnlInactive.Controls.Add(this.lblInactiveLabel);
            this.pnlInactive.Location = new System.Drawing.Point(340, 15);
            this.pnlInactive.Name = "pnlInactive";
            this.pnlInactive.Size = new System.Drawing.Size(145, 70);
            this.pnlInactive.TabIndex = 2;

            // 
            // lblInactiveStaff
            // 
            this.lblInactiveStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInactiveStaff.ForeColor = System.Drawing.Color.White;
            this.lblInactiveStaff.Location = new System.Drawing.Point(0, 15);
            this.lblInactiveStaff.Name = "lblInactiveStaff";
            this.lblInactiveStaff.Size = new System.Drawing.Size(145, 25);
            this.lblInactiveStaff.TabIndex = 1;
            this.lblInactiveStaff.Text = "0";
            this.lblInactiveStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblInactiveLabel
            // 
            this.lblInactiveLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInactiveLabel.ForeColor = System.Drawing.Color.White;
            this.lblInactiveLabel.Location = new System.Drawing.Point(0, 45);
            this.lblInactiveLabel.Name = "lblInactiveLabel";
            this.lblInactiveLabel.Size = new System.Drawing.Size(145, 18);
            this.lblInactiveLabel.TabIndex = 0;
            this.lblInactiveLabel.Text = "Inactive";
            this.lblInactiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.pnlActive.Controls.Add(this.lblActiveStaff);
            this.pnlActive.Controls.Add(this.lblActiveLabel);
            this.pnlActive.Location = new System.Drawing.Point(185, 15);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(140, 70);
            this.pnlActive.TabIndex = 1;

            // 
            // lblActiveStaff
            // 
            this.lblActiveStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActiveStaff.ForeColor = System.Drawing.Color.White;
            this.lblActiveStaff.Location = new System.Drawing.Point(0, 15);
            this.lblActiveStaff.Name = "lblActiveStaff";
            this.lblActiveStaff.Size = new System.Drawing.Size(140, 25);
            this.lblActiveStaff.TabIndex = 1;
            this.lblActiveStaff.Text = "0";
            this.lblActiveStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblActiveLabel
            // 
            this.lblActiveLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblActiveLabel.ForeColor = System.Drawing.Color.White;
            this.lblActiveLabel.Location = new System.Drawing.Point(0, 45);
            this.lblActiveLabel.Name = "lblActiveLabel";
            this.lblActiveLabel.Size = new System.Drawing.Size(140, 18);
            this.lblActiveLabel.TabIndex = 0;
            this.lblActiveLabel.Text = "Active";
            this.lblActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlTotal.Controls.Add(this.lblTotalStaff);
            this.pnlTotal.Controls.Add(this.lblTotalLabel);
            this.pnlTotal.Location = new System.Drawing.Point(30, 15);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(140, 70);
            this.pnlTotal.TabIndex = 0;

            // 
            // lblTotalStaff
            // 
            this.lblTotalStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalStaff.ForeColor = System.Drawing.Color.White;
            this.lblTotalStaff.Location = new System.Drawing.Point(0, 15);
            this.lblTotalStaff.Name = "lblTotalStaff";
            this.lblTotalStaff.Size = new System.Drawing.Size(140, 25);
            this.lblTotalStaff.TabIndex = 1;
            this.lblTotalStaff.Text = "0";
            this.lblTotalStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.White;
            this.lblTotalLabel.Location = new System.Drawing.Point(0, 45);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(140, 18);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total Staff";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // frmManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 545);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Staff";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlAdmins.ResumeLayout(false);
            this.pnlManagers.ResumeLayout(false);
            this.pnlReceptionists.ResumeLayout(false);
            this.pnlInactive.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}