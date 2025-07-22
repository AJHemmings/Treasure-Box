using System;
using System.Windows.Forms;

namespace TreasurySettingsEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Startup Error");
                System.IO.File.WriteAllText("error.log", ex.ToString());
            }
        }

    }
}

