using FinanceManagementApp.Controllers;
using System.Runtime.InteropServices;

namespace FinanceManagementApp.Forms.PopUps
{
    public partial class UserRegisterPopup : Form
    {
        public UserRegisterPopup()
        {
            InitializeComponent();
        }

        private readonly LoginController controller = new();

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
            this.Close();
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (await controller.RegisterUser(NameTextBox.Text, UserTextBox.Text, PasswordTextBox.Text, CofirmPasswordTextBox.Text))
                {
                    MessagePopup.Show("Sucesso", "Usuário registrado com sucesso");
                    this.Close();
                }
                else
                {
                    MessagePopup.Show("Falha", "Falha ao registrar usuário");
                }
            }
            catch (Exception ex)
            {
                MessagePopup.Show("Erro", ex.Message);
            }
        }

        private void CofirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterBtn_Click(sender, e);
            }
        }
    }
}
