using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.APIs;

namespace FinanceManagementApp.Services.Application
{
    public class UserService
    {
        private readonly ApiService apiService = new();

        public async Task<User?> LoginUser(string userName, string password)
        {
            var result = await apiService.LoginUser(userName, password);

            if (result)
            {
                return await apiService.GetUserByUserName(userName);
            }

            return null;
        }

        public async Task<bool> RegisterUser(string name, string userName, string password)
        {
            return await apiService.RegisterUser(name, userName, password);
        }
    }
}
