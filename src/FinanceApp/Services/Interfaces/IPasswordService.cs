using FinanceApp.Entities;

namespace FinanceApp.Services.Interfaces
{
    public interface IPasswordService
    {
        public string HashPassword(User user, string password);
        public bool VerifyPassword(User user, string password, string passwordHash);
    }
}
