using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.GroupBox groupDateRange;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTotal;
        private System.Windows.Forms.Label lblSummaryConfirmed;
        private System.Windows.Forms.Label lblSummaryCancelled;
        private System.Windows.Forms.Label lblSummaryRevenue;
        private System.Windows.Forms.Label lblSummaryPeriod;
        private System.Windows.Forms.Label lblChartSummary;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.groupDateRange = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.groupReportType = new System.Windows.Forms.GroupBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartSummary = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryPeriod = new System.Windows.Forms.Label();
            this.lblSummaryRevenue = new System.Windows.Forms.Label();
            this.lblSummaryCancelled = new System.Windows.Forms.Label();
            this.lblSummaryConfirmed = new System.Windows.Forms.Label();
            this.lblSummaryTotal = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDateRange.SuspendLayout();
            this.groupReportType.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.pnlSummary.SuspendLayout();
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

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports";

            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.btnGenerateReport);
            this.pnlMain.Controls.Add(this.groupDateRange);
            this.pnlMain.Controls.Add(this.groupReportType);
            this.pnlMain.Controls.Add(this.tabControl);
            this.pnlMain.Controls.Add(this.pnlSummary);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1000, 520);
            this.pnlMain.TabIndex = 1;

            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(890, 450);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 32);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(640, 70);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(110, 30);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            // 
            // groupDateRange
            // 
            this.groupDateRange.Controls.Add(this.lblTo);
            this.groupDateRange.Controls.Add(this.dtpEndDate);
            this.groupDateRange.Controls.Add(this.dtpStartDate);
            this.groupDateRange.Controls.Add(this.lblDateRange);
            this.groupDateRange.Location = new System.Drawing.Point(230, 12);
            this.groupDateRange.Name = "groupDateRange";
            this.groupDateRange.Size = new System.Drawing.Size(330, 65);
            this.groupDateRange.TabIndex = 3;
            this.groupDateRange.TabStop = false;
            this.groupDateRange.Text = "Date Range";

            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(170, 38);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To:";

            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(200, 35);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpEndDate.TabIndex = 2;

            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(80, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(90, 20);
            this.dtpStartDate.TabIndex = 1;

            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Location = new System.Drawing.Point(15, 38);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(58, 13);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "Date From:";

            // 
            // groupReportType
            // 
            this.groupReportType.Controls.Add(this.cmbReportType);
            this.groupReportType.Controls.Add(this.lblReportType);
            this.groupReportType.Location = new System.Drawing.Point(15, 12);
            this.groupReportType.Name = "groupReportType";
            this.groupReportType.Size = new System.Drawing.Size(200, 65);
            this.groupReportType.TabIndex = 2;
            this.groupReportType.TabStop = false;
            this.groupReportType.Text = "Report Type";

            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Location = new System.Drawing.Point(15, 38);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(170, 21);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);

            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(15, 18);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(74, 13);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Select Report:";

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabReport);
            this.tabControl.Controls.Add(this.tabChart);
            this.tabControl.Location = new System.Drawing.Point(15, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(970, 340);
            this.tabControl.TabIndex = 1;

            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.dgvReport);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(962, 314);
            this.tabReport.TabIndex = 0;
            this.tabReport.Text = "Report Data";
            this.tabReport.UseVisualStyleBackColor = true;

            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 3);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(956, 308);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.chartRevenue);
            this.tabChart.Controls.Add(this.lblChartSummary);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(962, 314);
            this.tabChart.TabIndex = 1;
            this.tabChart.Text = "Chart View";
            this.tabChart.UseVisualStyleBackColor = true;

            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(3, 3);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(956, 270);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chartRevenue";

            // 
            // lblChartSummary
            // 
            this.lblChartSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChartSummary.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblChartSummary.Location = new System.Drawing.Point(3, 273);
            this.lblChartSummary.Name = "lblChartSummary";
            this.lblChartSummary.Size = new System.Drawing.Size(956, 38);
            this.lblChartSummary.TabIndex = 1;
            this.lblChartSummary.Text = "Summary";
            this.lblChartSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlSummary.Controls.Add(this.lblSummaryPeriod);
            this.pnlSummary.Controls.Add(this.lblSummaryRevenue);
            this.pnlSummary.Controls.Add(this.lblSummaryCancelled);
            this.pnlSummary.Controls.Add(this.lblSummaryConfirmed);
            this.pnlSummary.Controls.Add(this.lblSummaryTotal);
            this.pnlSummary.Location = new System.Drawing.Point(15, 450);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(860, 28);
            this.pnlSummary.TabIndex = 0;

            // 
            // lblSummaryPeriod
            // 
            this.lblSummaryPeriod.AutoSize = true;
            this.lblSummaryPeriod.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSummaryPeriod.Location = new System.Drawing.Point(650, 7);
            this.lblSummaryPeriod.Name = "lblSummaryPeriod";
            this.lblSummaryPeriod.Size = new System.Drawing.Size(37, 12);
            this.lblSummaryPeriod.TabIndex = 4;
            this.lblSummaryPeriod.Text = "Period";

            // 
            // lblSummaryRevenue
            // 
            this.lblSummaryRevenue.AutoSize = true;
            this.lblSummaryRevenue.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSummaryRevenue.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblSummaryRevenue.Location = new System.Drawing.Point(500, 7);
            this.lblSummaryRevenue.Name = "lblSummaryRevenue";
            this.lblSummaryRevenue.Size = new System.Drawing.Size(49, 12);
            this.lblSummaryRevenue.TabIndex = 3;
            this.lblSummaryRevenue.Text = "Revenue";

            // 
            // lblSummaryCancelled
            // 
            this.lblSummaryCancelled.AutoSize = true;
            this.lblSummaryCancelled.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSummaryCancelled.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblSummaryCancelled.Location = new System.Drawing.Point(340, 7);
            this.lblSummaryCancelled.Name = "lblSummaryCancelled";
            this.lblSummaryCancelled.Size = new System.Drawing.Size(56, 12);
            this.lblSummaryCancelled.TabIndex = 2;
            this.lblSummaryCancelled.Text = "Cancelled";

            // 
            // lblSummaryConfirmed
            // 
            this.lblSummaryConfirmed.AutoSize = true;
            this.lblSummaryConfirmed.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSummaryConfirmed.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblSummaryConfirmed.Location = new System.Drawing.Point(170, 7);
            this.lblSummaryConfirmed.Name = "lblSummaryConfirmed";
            this.lblSummaryConfirmed.Size = new System.Drawing.Size(58, 12);
            this.lblSummaryConfirmed.TabIndex = 1;
            this.lblSummaryConfirmed.Text = "Confirmed";

            // 
            // lblSummaryTotal
            // 
            this.lblSummaryTotal.AutoSize = true;
            this.lblSummaryTotal.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotal.Location = new System.Drawing.Point(15, 7);
            this.lblSummaryTotal.Name = "lblSummaryTotal";
            this.lblSummaryTotal.Size = new System.Drawing.Size(35, 12);
            this.lblSummaryTotal.TabIndex = 0;
            this.lblSummaryTotal.Text = "Total: 0";

            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Dashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupDateRange.ResumeLayout(false);
            this.groupDateRange.PerformLayout();
            this.groupReportType.ResumeLayout(false);
            this.groupReportType.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}