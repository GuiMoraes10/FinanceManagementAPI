using System.Runtime.InteropServices;

namespace FinanceManagementApp.Forms.PopUps
{
    public partial class MessagePopup : Form
    {
        public MessagePopup()
        {
            InitializeComponent();
        }

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

        public static void Show(string title, string text)
        {
            using var msgBox = new MessagePopup();

            msgBox.TitleLabel.Text = title;
            msgBox.MessageLabel.Text = text;

            msgBox.BringToFront();   // Garante que fique na frente
            msgBox.Activate();       // Garante que receba o foco

            msgBox.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
