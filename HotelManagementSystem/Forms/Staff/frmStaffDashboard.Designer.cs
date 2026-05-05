using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Staff
{
    partial class frmStaffDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlTotalRooms;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblTotalRoomsLabel;
        private System.Windows.Forms.Panel pnlAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRoomsLabel;
        private System.Windows.Forms.Panel pnlBookedRooms;
        private System.Windows.Forms.Label lblBookedRooms;
        private System.Windows.Forms.Label lblBookedRoomsLabel;
        private System.Windows.Forms.Panel pnlOccupiedRooms;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label lblOccupiedRoomsLabel;
        private System.Windows.Forms.Panel pnlTodayRevenue;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Label lblTodayRevenueLabel;
        private System.Windows.Forms.Panel pnlMonthlyRevenue;
        private System.Windows.Forms.Label lblMonthlyRevenue;
        private System.Windows.Forms.Label lblMonthlyRevenueLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlMonthlyRevenue = new System.Windows.Forms.Panel();
            this.lblMonthlyRevenue = new System.Windows.Forms.Label();
            this.lblMonthlyRevenueLabel = new System.Windows.Forms.Label();
            this.pnlTodayRevenue = new System.Windows.Forms.Panel();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.lblTodayRevenueLabel = new System.Windows.Forms.Label();
            this.pnlOccupiedRooms = new System.Windows.Forms.Panel();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRoomsLabel = new System.Windows.Forms.Label();
            this.pnlBookedRooms = new System.Windows.Forms.Panel();
            this.lblBookedRooms = new System.Windows.Forms.Label();
            this.lblBookedRoomsLabel = new System.Windows.Forms.Label();
            this.pnlAvailableRooms = new System.Windows.Forms.Panel();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblAvailableRoomsLabel = new System.Windows.Forms.Label();
            this.pnlTotalRooms = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblTotalRoomsLabel = new System.Windows.Forms.Label();
            this.pnlStats.SuspendLayout();
            this.pnlMonthlyRevenue.SuspendLayout();
            this.pnlTodayRevenue.SuspendLayout();
            this.pnlOccupiedRooms.SuspendLayout();
            this.pnlBookedRooms.SuspendLayout();
            this.pnlAvailableRooms.SuspendLayout();
            this.pnlTotalRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.pnlMonthlyRevenue);
            this.pnlStats.Controls.Add(this.pnlTodayRevenue);
            this.pnlStats.Controls.Add(this.pnlOccupiedRooms);
            this.pnlStats.Controls.Add(this.pnlBookedRooms);
            this.pnlStats.Controls.Add(this.pnlAvailableRooms);
            this.pnlStats.Controls.Add(this.pnlTotalRooms);
            this.pnlStats.Location = new System.Drawing.Point(22, 23);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1425, 308);
            this.pnlStats.TabIndex = 0;
            // 
            // pnlMonthlyRevenue
            // 
            this.pnlMonthlyRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlMonthlyRevenue.Controls.Add(this.lblMonthlyRevenue);
            this.pnlMonthlyRevenue.Controls.Add(this.lblMonthlyRevenueLabel);
            this.pnlMonthlyRevenue.Location = new System.Drawing.Point(960, 154);
            this.pnlMonthlyRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMonthlyRevenue.Name = "pnlMonthlyRevenue";
            this.pnlMonthlyRevenue.Size = new System.Drawing.Size(435, 131);
            this.pnlMonthlyRevenue.TabIndex = 5;
            // 
            // lblMonthlyRevenue
            // 
            this.lblMonthlyRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRevenue.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyRevenue.Location = new System.Drawing.Point(0, 23);
            this.lblMonthlyRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            this.lblMonthlyRevenue.Size = new System.Drawing.Size(435, 54);
            this.lblMonthlyRevenue.TabIndex = 1;
            this.lblMonthlyRevenue.Text = "PKR 0";
            this.lblMonthlyRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyRevenueLabel
            // 
            this.lblMonthlyRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRevenueLabel.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyRevenueLabel.Location = new System.Drawing.Point(0, 85);
            this.lblMonthlyRevenueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyRevenueLabel.Name = "lblMonthlyRevenueLabel";
            this.lblMonthlyRevenueLabel.Size = new System.Drawing.Size(435, 31);
            this.lblMonthlyRevenueLabel.TabIndex = 0;
            this.lblMonthlyRevenueLabel.Text = "Monthly Revenue";
            this.lblMonthlyRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTodayRevenue
            // 
            this.pnlTodayRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlTodayRevenue.Controls.Add(this.lblTodayRevenue);
            this.pnlTodayRevenue.Controls.Add(this.lblTodayRevenueLabel);
            this.pnlTodayRevenue.Location = new System.Drawing.Point(960, 8);
            this.pnlTodayRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTodayRevenue.Name = "pnlTodayRevenue";
            this.pnlTodayRevenue.Size = new System.Drawing.Size(435, 131);
            this.pnlTodayRevenue.TabIndex = 4;
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTodayRevenue.Location = new System.Drawing.Point(0, 23);
            this.lblTodayRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(435, 54);
            this.lblTodayRevenue.TabIndex = 1;
            this.lblTodayRevenue.Text = "PKR 0";
            this.lblTodayRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayRevenueLabel
            // 
            this.lblTodayRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTodayRevenueLabel.ForeColor = System.Drawing.Color.White;
            this.lblTodayRevenueLabel.Location = new System.Drawing.Point(0, 85);
            this.lblTodayRevenueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayRevenueLabel.Name = "lblTodayRevenueLabel";
            this.lblTodayRevenueLabel.Size = new System.Drawing.Size(435, 31);
            this.lblTodayRevenueLabel.TabIndex = 0;
            this.lblTodayRevenueLabel.Text = "Today\'s Revenue";
            this.lblTodayRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOccupiedRooms
            // 
            this.pnlOccupiedRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlOccupiedRooms.Controls.Add(this.lblOccupiedRooms);
            this.pnlOccupiedRooms.Controls.Add(this.lblOccupiedRoomsLabel);
            this.pnlOccupiedRooms.Location = new System.Drawing.Point(645, 154);
            this.pnlOccupiedRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOccupiedRooms.Name = "pnlOccupiedRooms";
            this.pnlOccupiedRooms.Size = new System.Drawing.Size(300, 131);
            this.pnlOccupiedRooms.TabIndex = 3;
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(0, 15);
            this.lblOccupiedRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(300, 69);
            this.lblOccupiedRooms.TabIndex = 1;
            this.lblOccupiedRooms.Text = "0";
            this.lblOccupiedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOccupiedRoomsLabel
            // 
            this.lblOccupiedRoomsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOccupiedRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedRoomsLabel.Location = new System.Drawing.Point(0, 85);
            this.lblOccupiedRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupiedRoomsLabel.Name = "lblOccupiedRoomsLabel";
            this.lblOccupiedRoomsLabel.Size = new System.Drawing.Size(300, 31);
            this.lblOccupiedRoomsLabel.TabIndex = 0;
            this.lblOccupiedRoomsLabel.Text = "Occupied Rooms";
            this.lblOccupiedRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBookedRooms
            // 
            this.pnlBookedRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlBookedRooms.Controls.Add(this.lblBookedRooms);
            this.pnlBookedRooms.Controls.Add(this.lblBookedRoomsLabel);
            this.pnlBookedRooms.Location = new System.Drawing.Point(645, 8);
            this.pnlBookedRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBookedRooms.Name = "pnlBookedRooms";
            this.pnlBookedRooms.Size = new System.Drawing.Size(300, 131);
            this.pnlBookedRooms.TabIndex = 2;
            // 
            // lblBookedRooms
            // 
            this.lblBookedRooms.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBookedRooms.ForeColor = System.Drawing.Color.White;
            this.lblBookedRooms.Location = new System.Drawing.Point(0, 15);
            this.lblBookedRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookedRooms.Name = "lblBookedRooms";
            this.lblBookedRooms.Size = new System.Drawing.Size(300, 69);
            this.lblBookedRooms.TabIndex = 1;
            this.lblBookedRooms.Text = "0";
            this.lblBookedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookedRoomsLabel
            // 
            this.lblBookedRoomsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookedRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.lblBookedRoomsLabel.Location = new System.Drawing.Point(0, 85);
            this.lblBookedRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookedRoomsLabel.Name = "lblBookedRoomsLabel";
            this.lblBookedRoomsLabel.Size = new System.Drawing.Size(300, 31);
            this.lblBookedRoomsLabel.TabIndex = 0;
            this.lblBookedRoomsLabel.Text = "Booked Rooms";
            this.lblBookedRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAvailableRooms
            // 
            this.pnlAvailableRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlAvailableRooms.Controls.Add(this.lblAvailableRooms);
            this.pnlAvailableRooms.Controls.Add(this.lblAvailableRoomsLabel);
            this.pnlAvailableRooms.Location = new System.Drawing.Point(330, 154);
            this.pnlAvailableRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAvailableRooms.Name = "pnlAvailableRooms";
            this.pnlAvailableRooms.Size = new System.Drawing.Size(300, 131);
            this.pnlAvailableRooms.TabIndex = 1;
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.White;
            this.lblAvailableRooms.Location = new System.Drawing.Point(0, 15);
            this.lblAvailableRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(300, 69);
            this.lblAvailableRooms.TabIndex = 1;
            this.lblAvailableRooms.Text = "0";
            this.lblAvailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableRoomsLabel
            // 
            this.lblAvailableRoomsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailableRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.lblAvailableRoomsLabel.Location = new System.Drawing.Point(0, 85);
            this.lblAvailableRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableRoomsLabel.Name = "lblAvailableRoomsLabel";
            this.lblAvailableRoomsLabel.Size = new System.Drawing.Size(300, 31);
            this.lblAvailableRoomsLabel.TabIndex = 0;
            this.lblAvailableRoomsLabel.Text = "Available Rooms";
            this.lblAvailableRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalRooms
            // 
            this.pnlTotalRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlTotalRooms.Controls.Add(this.lblTotalRooms);
            this.pnlTotalRooms.Controls.Add(this.lblTotalRoomsLabel);
            this.pnlTotalRooms.Location = new System.Drawing.Point(328, 8);
            this.pnlTotalRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTotalRooms.Name = "pnlTotalRooms";
            this.pnlTotalRooms.Size = new System.Drawing.Size(300, 131);
            this.pnlTotalRooms.TabIndex = 0;
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRooms.ForeColor = System.Drawing.Color.White;
            this.lblTotalRooms.Location = new System.Drawing.Point(0, 15);
            this.lblTotalRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(300, 69);
            this.lblTotalRooms.TabIndex = 1;
            this.lblTotalRooms.Text = "0";
            this.lblTotalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRoomsLabel
            // 
            this.lblTotalRoomsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.lblTotalRoomsLabel.Location = new System.Drawing.Point(0, 85);
            this.lblTotalRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRoomsLabel.Name = "lblTotalRoomsLabel";
            this.lblTotalRoomsLabel.Size = new System.Drawing.Size(300, 31);
            this.lblTotalRoomsLabel.TabIndex = 0;
            this.lblTotalRoomsLabel.Text = "Total Rooms";
            this.lblTotalRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1470, 431);
            this.Controls.Add(this.pnlStats);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStaffDashboard";
            this.Text = "Staff Dashboard";
            this.pnlStats.ResumeLayout(false);
            this.pnlMonthlyRevenue.ResumeLayout(false);
            this.pnlTodayRevenue.ResumeLayout(false);
            this.pnlOccupiedRooms.ResumeLayout(false);
            this.pnlBookedRooms.ResumeLayout(false);
            this.pnlAvailableRooms.ResumeLayout(false);
            this.pnlTotalRooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}