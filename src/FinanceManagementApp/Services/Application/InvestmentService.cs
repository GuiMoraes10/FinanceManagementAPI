using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.APIs;

namespace FinanceManagementApp.Services.Application
{
    public class InvestmentService
    {
        private readonly ApiService apiService = new();

        public async Task<List<Investment>?> GetInvestments(string userId)
        {
            return await apiService.GetInvestmentsByUserId(userId);
        }

        public List<Investment> GetBiggestInvestments(List<Investment>? investments)
        {
            if (investments == null)
                return [];

            return investments
                .OrderByDescending(x => x.Balance)
                .Take(5)
                .ToList();
        }

        public decimal CalculateInvestedValue(List<Investment>? investments)
        {
            decimal investmentBalance = 0;

            if (investments is null || investments.Count == 0)
                return investmentBalance;

            foreach (var investment in investments)
            {
                investmentBalance += investment.Balance;
            }

            return investmentBalance;
        }
    }
}
