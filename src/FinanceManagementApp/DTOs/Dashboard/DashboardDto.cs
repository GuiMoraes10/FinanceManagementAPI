using FinanceManagementApp.Entities;

namespace FinanceManagementApp.DTOs.Dashboard
{
    public class DashboardDto
    {
        public decimal Balance { get; set; }
        public decimal Incomes { get; set; }
        public decimal Expenses { get; set; }
        public decimal Investments { get; set; }
        public decimal ProjectedBalance { get; set; }
        public List<Entities.Transaction> LastTransactions { get; set; } = [];
        public List<Entities.ScheduledTransaction> BiggestScheduledTransactions { get; set; } = [];
    }
}
