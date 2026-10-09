using System.Text.RegularExpressions;

namespace FinanceManagementApp.Services.Auxiliar
{
    public static class InputValidationService
    {
        public static bool LoginInputIsValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || Regex.IsMatch(input, @"[^\p{L}\p{N}_-]") || input.Contains(' '))
            {
                return false;
            }
            return true;
        }

        public static bool NameValueIsValid(string input)
        {
            if (string.IsNullOrEmpty(input) || !input.All(char.IsLetter))
            {
                return false;
            }
            return true;
        }

        public static bool BalanceValueIsValid(string input)
        {
            if (decimal.TryParse(input, out var balance))
            {
                if (balance >= 0)
                    return true;
            }
            return false;
        }
    }
}
