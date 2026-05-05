using System;
using System.Windows.Forms;
using HotelManagementSystem.Forms.Public;

namespace HotelManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show splash screen
            using (frmSplash splash = new frmSplash())
            {
                if (splash.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmStaffLogin());
                }
            }
        }
    }
}