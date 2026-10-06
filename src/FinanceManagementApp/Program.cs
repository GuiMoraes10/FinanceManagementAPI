using FinanceManagementApp.Forms;

namespace FinanceManagementApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using LoginForm loginForm = new();

                if (loginForm.ShowDialog() != DialogResult.OK)
                    break;
                
                using MainForm mainForm = new();

                mainForm.ShowDialog();

                if (!mainForm.LogoutRequested)
                    break;
            }
        }
    }
}