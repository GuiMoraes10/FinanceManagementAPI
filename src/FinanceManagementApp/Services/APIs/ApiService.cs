using FinanceManagementApp.DTOs.User;
using FinanceManagementApp.Entities;
using Newtonsoft.Json;

namespace FinanceManagementApp.Services.APIs
{
    public class ApiService
    {
        private readonly HttpService httpService = new();
        private readonly string Address = "https://localhost:7164";

        public async Task<bool> LoginUser(string username, string password)
        {
            UserLoginDto dto = new()
            {
                UserName = username,
                Password = password
            };

            return await httpService.AzureRequestPost(Address, "/user/login", dto);
        }

        public async Task<bool> RegisterUser(string name, string username, string password)
        {
            UserRegisterDto dto = new()
            {
                Name = name,
                UserName = username,
                Password = password
            };

            return await httpService.AzureRequestPost(Address, "/user", dto);
        }

        public async Task<User?> GetUserByUserName(string username)
        {
            username = username.Trim().ToLowerInvariant();

            var result = await httpService.AzureRequestGet(Address, "/user/username/" + username);

            if (string.IsNullOrEmpty(result))
                return null;

            return JsonConvert.DeserializeObject<User>(result);
        }

        public async Task<User?> GetUserById(string id)
        {
            var result = await httpService.AzureRequestGet(Address, "/user/" + id);

            if (string.IsNullOrEmpty(result))
                return null;

            return JsonConvert.DeserializeObject<User>(result);
        }

        public async Task<List<ScheduledTransaction>?> GetScheduledTransactionsByUserId(string userId)
        {
            var result = await httpService.AzureRequestGet(Address, "/scheduledtransaction/" + userId);

            if (string.IsNullOrEmpty(result))
                return null;

            return JsonConvert.DeserializeObject<List<ScheduledTransaction>>(result);
        }

        public async Task<List<Investment>?> GetInvestmentsByUserId(string userId)
        {
            var result = await httpService.AzureRequestGet(Address, "/investment/" + userId);

            if (string.IsNullOrEmpty(result))
                return null;

            return JsonConvert.DeserializeObject<List<Investment>>(result);
        }

        public async Task<List<Transaction>?> GetTransactionsByUserId(string userId)
        {
            var result = await httpService.AzureRequestGet(Address, "/transaction/" + userId);

            if (string.IsNullOrEmpty(result))
                return null;

            return JsonConvert.DeserializeObject<List<Transaction>>(result);
        }
    }
}
