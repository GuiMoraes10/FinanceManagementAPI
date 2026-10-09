using FinanceManagementApp.Controllers;
using FinanceManagementApp.Entities;
using FinanceManagementApp.Forms.PopUps;
using System.Runtime.InteropServices;

namespace FinanceManagementApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly LoginController controller = new();
        public User? AuthenticatedUser { get; private set; }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await controller.LoginUser(UserTextBox.Text, PasswordTextBox.Text);

                if (user != null)
                {
                    AuthenticatedUser = user;
                    MessagePopup.Show("Bem vindo!", "Login realizado com sucesso");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessagePopup.Show("Erro", "Usuário ou senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessagePopup.Show("Erro", ex.Message);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserRegisterPopup registerPopup = new();
            registerPopup.Show();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}
