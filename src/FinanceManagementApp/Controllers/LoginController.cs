using FinanceManagementApp.Entities;
using FinanceManagementApp.Services.Application;
using FinanceManagementApp.Services.Auxiliar;

namespace FinanceManagementApp.Controllers
{
    public class LoginController
    {
        private readonly UserService userService = new();

        public async Task<User?> LoginUser(string userName, string password)
        {
            if (!InputValidationService.LoginInputIsValid(userName))
                throw new ArgumentException("Nome de usuário inválido");

            if (!InputValidationService.LoginInputIsValid(password))
                throw new ArgumentException("Senha inválida");

            return await userService.LoginUser(userName, password);
        }

        public async Task<bool> RegisterUser(string userName, string password)
        {
            return false;
        }
    }
}
