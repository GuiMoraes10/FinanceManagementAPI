using FinanceManagementApp.DTOs.Dashboard;
using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.Application;
using FinanceManagementApp.Services.Auxiliar;

namespace FinanceManagementApp.Controllers
{
    public class DashboardController
    {
        private readonly UserService userService = new();
        private readonly TransactionService transactionService = new();
        private readonly InvestmentService investmentService = new();
        private readonly ScheduledTransactionService scheduledTransactionService = new();

        public async Task<bool> UpdateUserBalance(string userId, string balance)
        {
            if (!InputValidationService.BalanceValueIsValid(balance))
                throw new ArgumentException("Valor de saldo inválido");

            return await userService.UpdateBalance(userId, balance);
        }

        public async Task<User> GetUser(string userId)
        {
            var user = await userService.GetUser(userId);

            return user is null ? throw new ArgumentException("Erro ao encontrar dados de usuário") : user;
        }

        public async Task<DashboardDto?> GetDashboardData(string userId)
        {
            var user = await userService.GetUser(userId);

            if (user == null)
                return null;

            var scheduledTransactions = await scheduledTransactionService.GetScheduledTransactions(userId);

            var biggestScheduledTransactions = scheduledTransactionService.GetBiggestTransactions(scheduledTransactions);

            var scheduledValues = scheduledTransactionService.CalculateValues(scheduledTransactions);

            var investments = await investmentService.GetInvestments(userId);

            decimal investmentBalance = investmentService.CalculateInvestedValue(investments);

            var transactions = await transactionService.GetTransactions(userId);

            var lastTransactions = transactionService.GetLastTransactions(transactions);

            DashboardDto dto = new()
            {
                Balance = user.Balance,
                Incomes = scheduledValues.incomings,
                Expenses = scheduledValues.expenses,
                BiggestScheduledTransactions = biggestScheduledTransactions,
                Investments = investmentBalance,
                LastTransactions = lastTransactions,
                ProjectedBalance = user.Balance + scheduledValues.incomings - scheduledValues.expenses,
            };

            return dto;
        }
    }
}
