using FinanceManagementApp.Entities;
using FinanceManagementApp.Forms;
using System.Runtime.InteropServices;

namespace FinanceManagementApp
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(User loginUser)
        {
            InitializeComponent();

            mainButtons = [DashboardBtn, TransactionsBtn, ScheduledTransactionsBtn, InvestmentsBtn, ProjectionsBtn, SettingsBtn];

            user = loginUser;

            OpenFormInPanel(new Home(user.Name));
        }

        private Form? _currentForm;
        private List<Button> mainButtons;
        public bool LogoutRequested { get; private set; }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void SetDefaultButtonsCollor()
        {
            foreach (Button button in mainButtons)
            {
                button.BackColor = Color.FromArgb(45, 45, 45);
            }
        }

        private void OpenFormInPanel(Form childForm)
        {
            _currentForm?.Close();
            _currentForm?.Dispose();

            _currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;

            childForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void SwPicturePb_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Home(user.Name));
            SetDefaultButtonsCollor();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Dashboard());
            SetDefaultButtonsCollor();
            DashboardBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void TransactionsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Transactions());
            SetDefaultButtonsCollor();
            TransactionsBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void ScheduledTransactionsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ScheduledTransactions());
            SetDefaultButtonsCollor();
            ScheduledTransactionsBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void InvestmentsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Investments());
            SetDefaultButtonsCollor();
            InvestmentsBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void ProjectionsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FinancialProjection());
            SetDefaultButtonsCollor();
            ProjectionsBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Settings());
            SetDefaultButtonsCollor();
            SettingsBtn.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void UserPb_Click(object sender, EventArgs e)
        {
            LogoutRequested = true;
            Close();
        }
    }
}
