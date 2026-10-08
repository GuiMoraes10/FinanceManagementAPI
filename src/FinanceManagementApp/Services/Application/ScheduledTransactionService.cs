using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.APIs;

namespace FinanceManagementApp.Services.Application
{
    public class ScheduledTransactionService
    {
        private readonly ApiService apiService = new();

        public async Task<List<ScheduledTransaction>?> GetScheduledTransactions(string userId)
        {
            return await apiService.GetScheduledTransactionsByUserId(userId);
        }

        public List<ScheduledTransaction> GetBiggestTransactions(List<ScheduledTransaction>? transactions)
        {
            if (transactions == null)
                return [];

            return transactions
                .OrderByDescending(x => x.Value)
                .Take(5)
                .ToList();
        }

        public (decimal expenses, decimal incomings) CalculateValues(List<ScheduledTransaction>? scheduledTransactions)
        {
            decimal expensesValue = 0;
            decimal incomingsValue = 0;

            if (scheduledTransactions is null || scheduledTransactions.Count == 0)
            {
                return (expensesValue, incomingsValue);
            }

            foreach (var transactions in scheduledTransactions)
            {
                if (transactions.Type == Enums.TransactionType.Income)
                {
                    incomingsValue += transactions.Value;
                }
                else
                {
                    expensesValue += transactions.Value;
                }
            }

            return (expensesValue, incomingsValue);
        }
    }
}
