using FinanceManagementApp.Services.Auxiliar;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace FinanceManagementApp.Services.APIs
{
    public class HttpService
    {
        // HttpClient compartilhado para evitar socket exhaustion
        private static readonly HttpClient _httpClient = new()
        {
            // Timeout gerenciado manualmente via CancellationTokenSource; evita conflitos de Timeout entre requisições
            Timeout = System.Threading.Timeout.InfiniteTimeSpan
        };

        private readonly BackofService backofService = new(200);

        // Parâmetros padrão de retry/timeout
        private const int DefaultTimeoutSeconds = 10;
        private const int DefaultMaxRetries = 2;

        public async Task<string?> AzureRequestGet(string address, string command, int timeoutSeconds = DefaultTimeoutSeconds, int maxRetries = DefaultMaxRetries)
        {
            Uri url = new(address + command);

            int attempt = 0;
            TimeSpan timeout = TimeSpan.FromSeconds(Math.Max(1, timeoutSeconds));

            while (true)
            {
                try
                {
                    using var cts = new CancellationTokenSource(timeout);
                    using var request = new HttpRequestMessage(HttpMethod.Get, url);

                    // Apenas lê o conteúdo quando o response estiver pronto
                    using HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cts.Token).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                    else
                    {
                        // Erro de HTTP (4xx/5xx) — retorna null
                        return null;
                    }
                }
                catch (OperationCanceledException oce)
                {
                    // Timeout ou cancelamento
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        // Depois de esgotar retries, lança exceção com contexto
                        throw new Exception("Tempo limite excedido ao enviar requisicao ao banco de dados", oce);
                    }

                    // Backoff simples antes de tentar novamente (leve)
                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (HttpRequestException hre)
                {
                    // Erro de rede transitório: tenta novamente até maxRetries
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Falha de rede ao enviar requisicao ao banco de dados", hre);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (Exception ex)
                {
                    // Outros erros
                    throw new Exception("Falha ao enviar requisicao ao banco de dados", ex);
                }
            }
        }

        public async Task<bool> AzureRequestDelete(string address, string command, int timeoutSeconds = DefaultTimeoutSeconds, int maxRetries = DefaultMaxRetries)
        {
            Uri url = new(address + command);

            int attempt = 0;
            TimeSpan timeout = TimeSpan.FromSeconds(Math.Max(1, timeoutSeconds));

            while (true)
            {
                try
                {
                    using var cts = new CancellationTokenSource(timeout);
                    using var request = new HttpRequestMessage(HttpMethod.Delete, url);

                    //// Apenas lê o conteúdo quando o response estiver pronto
                    using HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cts.Token).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        // Erro de HTTP (4xx/5xx) — retorna false
                        return false;
                    }
                }
                catch (OperationCanceledException oce)
                {
                    // Timeout ou cancelamento
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        // Depois de esgotar retries, lança exceção com contexto
                        throw new Exception("Tempo limite excedido ao enviar requisicao ao banco de dados", oce);
                    }

                    // Backoff simples antes de tentar novament
                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (HttpRequestException hre)
                {
                    // Erro de rede transitório: tenta novamente até maxRetries
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Falha de rede ao enviar requisicao ao banco de dados", hre);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (Exception ex)
                {
                    // Outros erros
                    throw new Exception("Falha ao enviar requisicao ao banco de dados", ex);
                }
            }
        }

        public async Task<bool> AzureRequestPatch<T>(string address, string command, T? body, int timeoutSeconds = DefaultTimeoutSeconds, int maxRetries = DefaultMaxRetries)
        {
            Uri url = new(address + command);

            int attempt = 0;
            TimeSpan timeout = TimeSpan.FromSeconds(Math.Max(1, timeoutSeconds));

            while (true)
            {
                try
                {
                    using var cts = new CancellationTokenSource(timeout);
                    using var request = new HttpRequestMessage(HttpMethod.Patch, url);

                    if (body != null)
                    {
                        if (body is string stringBody)
                        {
                            // Define o conteúdo JSON no body // para requisicoes sem objeto pronto
                            request.Content = new StringContent(
                                JsonConvert.SerializeObject(stringBody),
                                Encoding.UTF8,
                                "application/json");
                        }
                        else
                        {
                            // Define o conteudo do JSON no body // para requisicoes com objeto pronto
                            request.Content = JsonContent.Create(body);
                        }
                    }

                    using HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cts.Token).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        // Retornar null em erros HTTP
                        return false;
                    }
                }
                catch (OperationCanceledException oce)
                {
                    // Timeout ou cancelamento
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Tempo limite excedido ao enviar requisicao ao banco de dados", oce);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (HttpRequestException hre)
                {
                    // Erro de rede transitório: tenta novamente até maxRetries
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Falha de rede ao enviar requisicao ao banco de dados", hre);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (Exception ex)
                {
                    throw new Exception("Falha ao enviar requisicao ao banco de dados", ex);
                }
            }
        }

        public async Task<bool> AzureRequestPost<T>(string address, string command, T? body, int timeoutSeconds = DefaultTimeoutSeconds, int maxRetries = DefaultMaxRetries)
        {
            Uri url = new(address + command);

            int attempt = 0;
            TimeSpan timeout = TimeSpan.FromSeconds(Math.Max(1, timeoutSeconds));

            while (true)
            {
                try
                {
                    using var cts = new CancellationTokenSource(timeout);
                    using var request = new HttpRequestMessage(HttpMethod.Post, url);

                    if (body != null)
                    {
                        if (body is string stringBody)
                        {
                            // Define o conteúdo JSON no body // para requisicoes sem objeto pronto
                            request.Content = new StringContent(
                                JsonConvert.SerializeObject(stringBody),
                                Encoding.UTF8,
                                "application/json");
                        }
                        else
                        {
                            // Define o conteudo do JSON no body // para requisicoes com objeto pronto
                            request.Content = JsonContent.Create(body);
                        }
                    }

                    using HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cts.Token).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        // Retornar null em erros HTTP
                        return false;
                    }
                }
                catch (OperationCanceledException oce)
                {
                    // Timeout ou cancelamento
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Tempo limite excedido ao enviar requisicao ao banco de dados", oce);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (HttpRequestException hre)
                {
                    // Erro de rede transitório: tenta novamente até maxRetries
                    attempt++;
                    if (attempt > maxRetries)
                    {
                        throw new Exception("Falha de rede ao enviar requisicao ao banco de dados", hre);
                    }

                    await Task.Delay(backofService.GetBackoffDelayMs(attempt), CancellationToken.None).ConfigureAwait(false);
                    continue;
                }
                catch (Exception ex)
                {
                    throw new Exception("Falha ao enviar requisicao ao banco de dados", ex);
                }
            }
        }
    }
}
