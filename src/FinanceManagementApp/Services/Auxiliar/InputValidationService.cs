namespace FinanceManagementApp.Services.Auxiliar
{
    public static class InputValidationService
    {
        public static bool LoginInputIsValid(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName) || userName.Contains('/') || userName.Contains(' '))
            {
                return false;
            }
            return true;
        }
    }
}
