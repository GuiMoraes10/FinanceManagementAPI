namespace FinanceManagementApp.Services.Auxiliar
{
    public class BackofService(int delay)
    {
        private readonly int DelayMs = delay;

        private static readonly Random _jitterer = new();

        public int GetBackoffDelayMs(int attempt)
        {
            // Exponencial leve com jitter: base * 2^(attempt-1) + jitter
            int exponential = DelayMs * (int)Math.Pow(2, Math.Max(0, attempt - 1));
            int jitter = _jitterer.Next(0, 100);
            return exponential + jitter;
        }

        public Task DelayWithBackoffAsync(int attempt, CancellationToken cancellationToken)
        {
            // backoff exponencial: base * 2^(attempt-1) + jitter
            int exponential = DelayMs * (int)Math.Pow(2, Math.Max(0, attempt - 1));
            int jitter = _jitterer.Next(0, 100);
            int delay = exponential + jitter;
            return Task.Delay(delay, cancellationToken);
        }
    }
}
