using FinanceManagementApp.Controllers;
using FinanceManagementApp.DTOs.Dashboard;
using FinanceManagementApp.Forms.PopUps;

namespace FinanceManagementApp.Forms
{
    public partial class Dashboard : Form
    {
        private readonly DashboardController controller = new();
        private readonly string userId;

        public Dashboard(string loggedUserId)
        {
            InitializeComponent();

            userId = loggedUserId;

            _ = UpdateDashboard();
        }

        private async Task UpdateDashboard()
        {
            DashboardDto? dto = await controller.GetDashboardData(userId);

            if (dto is null)
            {
                MessagePopup.Show("Erro", "Erro ao buscar dados de usuário");
                return;
            }

            BalanceValueLabel.Text = $"R$ {dto.Balance:F2}";
            IncomingsValueLabel.Text = $"R$ {dto.Incomes:F2}";
            ExpensesValueLabel.Text = $"R$ {dto.Expenses:F2}";
            BalanceProjectionValueLabel.Text = $"R$ {dto.ProjectedBalance:F2}";
            InvestmentsValueLabel.Text = $"R$ {dto.Investments:F2}";
            LastTransactionsRtb.Text = FormatLastTransactionsText(dto.LastTransactions);
            BiggestScheduledRtb.Text = FormatBiggestScheduledTransactionsText(dto.BiggestScheduledTransactions);
        }

        private string FormatLastTransactionsText(List<Entities.Transaction> transactions)
        {
            string formatedText = "";

            foreach (Entities.Transaction transaction in transactions)
            {
                string type;

                if (transaction.Type == Enums.TransactionType.Income)
                {
                    type = "lucro";
                }
                else
                {
                    type = "gasto";
                }

                string transactionText = type + ", " + transaction.Name + ": " + transaction.Value + ", " + transaction.Date + "\n";

                formatedText += transactionText;
            }

            return formatedText;
        }

        private string FormatBiggestScheduledTransactionsText(List<Entities.ScheduledTransaction> transactions)
        {
            string formatedText = "";

            foreach (Entities.ScheduledTransaction transaction in transactions)
            {
                string type;

                if (transaction.Type == Enums.TransactionType.Income)
                {
                    type = "lucro";
                }
                else
                {
                    type = "gasto";
                }

                string transactionText = type + ", " + transaction.Name + ": " + transaction.Value + ", dia " + transaction.Day + "\n";

                formatedText += transactionText;
            }

            return formatedText;
        }
    }
}
