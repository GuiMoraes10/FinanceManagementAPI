using FinanceApp.Entities;
using FinanceApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace FinanceApp.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly PasswordHasher<User> _hasher = new();

        public string HashPassword(User user, string password)
        {
            return _hasher.HashPassword(user, password);
        }

        public bool VerifyPassword(User user, string password, string passwordHash)
        {
            var result = _hasher.VerifyHashedPassword(user, passwordHash, password);

            return result == PasswordVerificationResult.Success;
        }
    }
}
