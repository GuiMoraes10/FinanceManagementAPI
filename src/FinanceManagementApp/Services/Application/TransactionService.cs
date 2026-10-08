using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.APIs;

namespace FinanceManagementApp.Services.Application
{
    public class TransactionService
    {
        private readonly ApiService apiService = new();

        public async Task<List<Transaction>?> GetTransactions(string userId)
        {
            return await apiService.GetTransactionsByUserId(userId);
        }

        public List<Transaction> GetLastTransactions(List<Transaction>? transactions)
        {
            if (transactions == null)
                return [];

            return transactions
                .OrderByDescending(x => x.Date)
                .Take(5)
                .ToList();
        }
    }
}
