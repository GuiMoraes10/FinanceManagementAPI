using FinanceManagementApp.Controllers;
using FinanceManagementApp.Entities;
using System.Runtime.InteropServices;

namespace FinanceManagementApp.Forms.PopUps
{
    public partial class ChangeBalancePopup : Form
    {
        private readonly DashboardController controller = new();
        private readonly User user;


        public ChangeBalancePopup(User user)
        {
            InitializeComponent();

            Shown += (s, e) => NewBalanceTextBox.Focus();

            this.user = user;

            UpdateBalance();
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void UpdateBalance()
        {
            BalanceValueLabel.Text = user.Balance.ToString("F2");
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (await controller.UpdateUserBalance(user.Id, NewBalanceTextBox.Text))
                {
                    MessagePopup.Show("Concluído", "Saldo atualizado com sucesso");
                    this.Close();
                }
                else
                {
                    MessagePopup.Show("Erro", "Ocorreu um erro ao atualizar o saldo");
                }
            }
            catch (Exception ex)
            {
                MessagePopup.Show("Erro", ex.Message);
            }
        }

        private void NewBalanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateBtn_Click(sender, e);
            }
        }

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
    }
}
