using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Public
{
    public partial class frmSplash : Form
    {
        private Timer timer;
        private int progressValue = 0;

        public frmSplash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressValue += 2;

            if (progressBar != null)
                progressBar.Value = Math.Min(progressValue, 100);

            if (lblPercentage != null)
                lblPercentage.Text = Math.Min(progressValue, 100) + "%";

            if (progressValue >= 100)
            {
                timer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}