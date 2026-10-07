using FinanceApp.DTOs.User;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    public class UserService(IUserRepository repository, IPasswordService passwordService) : IUserService
    {
        private readonly IUserRepository _repository = repository;
        private readonly IPasswordService _passwordService = passwordService;

        public async Task<User?> CreateNewUser(UserRegisterDto dto)
        {
            var userName = dto.UserName.Trim().ToLowerInvariant();

            var existingUser = await _repository.GetByUserNameAsync(userName);

            if (existingUser is not null)
                return null;

            User user = new()
            {
                Name = dto.Name,
                UserName = userName,
            };

            user.PasswordHash = _passwordService.HashPassword(user, dto.Password);

            return await _repository.CreateAsync(user);
        }

        public async Task<User?> GetUserById(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<User?> GetUserByUserName(string userName)
        {
            userName = userName.Trim().ToLowerInvariant();

            return await _repository.GetByUserNameAsync(userName);
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<bool> SetUserBalance(string id, decimal value)
        {
            User? user = await _repository.GetByIdAsync(id);

            if (user is null)
                return false;

            user.Balance = value;

            user = await _repository.UpdateAsync(user);

            return user.Balance == value;
        }

        public async Task<User?> UpdateUser(string id, UserUpdateDto dto)
        {
            var userName = dto.UserName.Trim().ToLowerInvariant();

            User? user = await _repository.GetByIdAsync(id);

            if (user is null)
                return null;

            User? existingUser = await _repository.GetByUserNameAsync(userName);

            if (existingUser is not null && existingUser.Id != id)
                return null;

            user.Name = dto.Name;
            user.UserName = userName;

            user = await _repository.UpdateAsync(user);

            return user;
        }

        public async Task<bool> SetUserPassword(string id, ChangePasswordDto dto)
        {
            User? user = await _repository.GetByIdAsync(id);

            if (user is null)
                return false;

            var validPassword = _passwordService.VerifyPassword(user, dto.CurrentPassword, user.PasswordHash);

            if (!validPassword)
                return false;

            user.PasswordHash = _passwordService.HashPassword(user, dto.NewPassword);

            await _repository.UpdateAsync(user);

            return true;
        }

        public async Task<bool> LoginAsync(string userName, string password)
        {
            userName = userName.Trim().ToLowerInvariant();

            var user = await _repository.GetByUserNameAsync(userName);

            if (user is null)
                return false;

            return _passwordService.VerifyPassword(user, password, user.PasswordHash);
        }
    }
}
